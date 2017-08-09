using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace CallCenterMotivationCalc {
	public class ExcelParser {
		private string fileNameEmployeesList;
		private string fileNameTimetableMonthPlan;
		private string[] fileNameTimetableFactParts;
		private string[] fileNameOperatorsQualityParts;
		private string fileNameOperatorsWorktime;
		private string fileNameAcceptedAndMissedCalls;
		private DateTime dateTimePeriod;
		private System.Windows.Forms.TextBox textBox;
		private ProgressBar progressBar;
		private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

		public ExcelParser(
			string fileNameEmployeesList,
			string fileNameTimetableMonthPlan,
			string[] fileNameTimetableFactParts,
			string[] fileNameOperatorsQualityParts,
			string fileNameOperatorsWorktime,
			string fileNameAcceptedAndMissedCalls,
			DateTime dateTimePeriod) {
			this.fileNameEmployeesList = fileNameEmployeesList;
			this.fileNameTimetableMonthPlan = fileNameTimetableMonthPlan;
			this.fileNameTimetableFactParts = fileNameTimetableFactParts;
			this.fileNameOperatorsQualityParts = fileNameOperatorsQualityParts;
			this.fileNameOperatorsWorktime = fileNameOperatorsWorktime;
			this.fileNameAcceptedAndMissedCalls = fileNameAcceptedAndMissedCalls;
			this.dateTimePeriod = dateTimePeriod;
		}

		public void AnalyzeFiles(System.Windows.Forms.TextBox textBox, ProgressBar progressBar) {
			this.textBox = textBox;
			this.progressBar = progressBar;

			UpdateProgressBar(0);
			UpdateTextBox("Чтение информации из указанных файлов");

			ReadEmployeesWorkbook();
			if (employees.Count == 0) {
				UpdateTextBox("Список сотрудников не содержит записей", true);
				return;
			}
			
			UpdateTextBox("Считано записей: " + employees.Count);
			UpdateProgressBar(10);

			ReadTimetablePlan();
			UpdateProgressBar(20);

			ReadTimetableFact();
			UpdateProgressBar(45);

			ReadOperatorsQuality();
			UpdateProgressBar(70);

			ReadOperatorsWorktime();
			UpdateProgressBar(80);

			ReadAcceptedAndMissedCalls();
			UpdateProgressBar(90);

			UpdateTextBox("Итоговый список:", false, true);
			List<string> keys = employees.Keys.ToList();
			keys.Sort();
			foreach (string key in keys)
				UpdateTextBox(employees[key].ToString());

			WriteToExcel();
			UpdateProgressBar(100);
		}

		private void WriteToExcel() {
			UpdateTextBox("Выгрузка данных в Excel", false, true);

			Excel.Application xlApp = new Excel.Application();
			if (xlApp == null) {
				UpdateTextBox("Не удалось открыть приложение Excel", true);
				return;
			}

			xlApp.Visible = true;

			Excel.Workbook xlWb = xlApp.Workbooks.Open(Environment.CurrentDirectory + "\\Шаблон итоговой таблицы.xlsx", ReadOnly: true);
			if (xlWb == null) {
				UpdateTextBox("Не удалось открыть файл с шаблоном итоговой таблицы", true);
				return;
			}

			Excel.Worksheet xlWs = xlWb.Sheets["Лист1"];
			if (xlWs == null) {
				UpdateTextBox("Не удалось найти лист1 в шаблоне итоговой таблицы", true);
				return;
			}

			try {
				List<string> keys = employees.Keys.ToList();
				keys.Sort();
				int row = 6;

				string title = xlWs.Range["A1"].Value;
				title = title.Replace("*month*", dateTimePeriod.ToString("MMMMM")).Replace("*year*", dateTimePeriod.ToString("yyyy"));
				xlWs.Range["A1"].Value = title;

				string subtitle = xlWs.Range["A2"].Value;
				subtitle = subtitle.Replace("*month*", dateTimePeriod.ToString("MMMMM")).Replace("*year*", dateTimePeriod.ToString("yyyy"));
				xlWs.Range["A2"].Value = subtitle;

				foreach (string key in keys) {
					Employee employee = employees[key];
					xlWs.Range["A" + row].Value = row - 5;
					xlWs.Range["B" + row].Value = employee.FullName;
					xlWs.Range["C" + row].Value = employee.Position;
					xlWs.Range["D" + row].Value = employee.Rate;
					xlWs.Range["E" + row].Value = employee.Pfr;
					xlWs.Range["F" + row].Value = employee.Salary;
					xlWs.Range["G" + row].Value = employee.GetSpentTime();
					xlWs.Range["H" + row].Value = employee.GetQualityResult();
					xlWs.Range["I" + row].Value = employee.GetQualityCoefficient();

					if (!employee.HasNightHours) {
						xlWs.Range["J" + row].Value = employee.GetWorktimeCongestion();
						xlWs.Range["K" + row].Value = employee.GetWorktimeCoefficient();
					} else {
						xlWs.Range["L" + row].Value = employee.GetAcceptedAndMissedResult();
						xlWs.Range["M" + row].Value = employee.GetAcceptedAndMissedCoefficient();
					}

					xlWs.Range["N" + row].Formula = "=I$+K$+M$".Replace("$", row.ToString());
					xlWs.Range["O" + row].Formula = "=F$*N$*G$".Replace("$", row.ToString());

					row++;
				}

				string savePath = Environment.CurrentDirectory + "\\Результаты\\Итоговая таблица " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".xlsx";
				xlWb.SaveAs(savePath);
				UpdateTextBox("Результат сохранен в файл: " + savePath);
			} catch (Exception e) {
				UpdateTextBox(e.Message, true);
				return;
			}

			UpdateTextBox("Выгружено успешно");
		}

		private void ReadAcceptedAndMissedCalls() {
			UpdateTextBox("Обработка принятых и непринятых звонков", false, true);
			UpdateTextBox("Файл: " + fileNameAcceptedAndMissedCalls);

			DataTable dataTable = ReadExcelFile(Properties.Settings.Default.AcceptedAndMissedCallsSheetName, fileNameAcceptedAndMissedCalls);

			for (int i = Properties.Settings.Default.AcceptedAndMissedCallsFirstRow - 1; i < dataTable.Rows.Count; i++) {
				try {
					string dateTimeStr = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.OperatorsWorktimeFullNameColumn)].ToString();
					if (string.IsNullOrEmpty(dateTimeStr))
						continue;

					DateTime dateTime = new DateTime();
					if (!DateTime.TryParse(dateTimeStr, out dateTime)) {
						UpdateTextBox("Не удалось разобрать строку с датой и временем: " + dateTimeStr, true);
					}

					int hour = dateTime.TimeOfDay.Hours;
					int morningLastHour = Properties.Settings.Default.AcceptedAndMissedCallsMorningLastHour;
					int nightFirstHour = Properties.Settings.Default.AcceptedAndMissedCallsNightFirstHour;
					if (hour > morningLastHour && hour < nightFirstHour)
						continue;

					int day = dateTime.Day;
					List<Employee> thisDayHourEmployees = new List<Employee>();

					foreach (Employee employee in employees.Values) {
						if (!employee.HasNightHours)
							continue;

						if (hour <= morningLastHour) {
							if (employee.IsDayInMorningHours(day))
								thisDayHourEmployees.Add(employee);
						} else if (hour >= nightFirstHour) {
							if (employee.IsDayInNightHours(day)) {
								thisDayHourEmployees.Add(employee);
							}
						}
					}

					if (thisDayHourEmployees.Count == 0) {
						UpdateTextBox("Не удалось найти сотрудников, работавших в это время: " + dateTimeStr, true);
						continue;
					}

					string acceptedAndMissedCallsTotal = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.AcceptedAndMissedCallsTotalCallsColumn)].ToString();
					string acceptedAndMissedCallsMissed = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.AcceptedAndMissedCallsMissedCallsColumn)].ToString();
					string acceptedAndMissedCallsWrong = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.AcceptedAndMissedCallsWrongCallsColumn)].ToString();

					foreach (Employee employee in thisDayHourEmployees) {
						employee.AddAcceptedAndMissedTotalCalls(acceptedAndMissedCallsTotal);
						employee.AddAcceptedAndMissedMissedCalls(acceptedAndMissedCallsMissed);
						employee.AddAcceptedAndMissedWrongCalls(acceptedAndMissedCallsWrong);
					}
				} catch (Exception e) {
					UpdateTextBox("\tНе удалось обработать строку: " + i + ", " + e.Message, true);
				}
			}
		}

		private void ReadOperatorsWorktime() {
			UpdateTextBox("Обработка времени работы операторов", false, true);
			UpdateTextBox("Файл: " + fileNameOperatorsWorktime);

			DataTable dataTable = ReadExcelFile(Properties.Settings.Default.OperatorsWorktimeSheetName, fileNameOperatorsWorktime);

			for (int i = Properties.Settings.Default.OperatorsWorktimeFirstRow - 1; i < dataTable.Rows.Count; i++) {
				try {
					string fullName = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.OperatorsWorktimeFullNameColumn)].ToString();

					if (string.IsNullOrEmpty(fullName))
						continue;

					string employeeKey = GetEmployeeKeyByName(fullName, false);

					if (string.IsNullOrEmpty(employeeKey)) {
						UpdateTextBox("\tНе удалось найти в списке сотрудников запись: " + fullName, true);
						continue;
					}

					string operatorWorktimeTotal = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.OperatorsWorktimeTotalCallsTimeColumn)].ToString();
					string operatorWorktimeRemaining = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.OperatorsWorktimeRemainingTimeColumn)].ToString();
					string operatorWorktimePause = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.OperatorsWorktimePauseTimeColumn)].ToString();

					employees[employeeKey].SetWorktimeTotalCallsTime(operatorWorktimeTotal);
					employees[employeeKey].SetWorktimeRemainingTime(operatorWorktimeRemaining);
					employees[employeeKey].SetWorktimePauseTime(operatorWorktimePause);
				} catch (Exception e) {
					UpdateTextBox("\tНе удалось обработать строку: " + i + ", " + e.Message, true);
				}
			}
		}

		private void ReadOperatorsQuality() {
			UpdateTextBox("Обработка качества работы операторов", false, true);

			foreach (string fileName in fileNameOperatorsQualityParts) {
				UpdateTextBox("Файл: " + fileName);

				DataTable dataTable = ReadExcelFile(Properties.Settings.Default.OperatorsQualitySheetName, fileName);

				for (int i = Properties.Settings.Default.OperatorsQualityFirstRow - 1; i < dataTable.Rows.Count; i++) {
					try {
						string fullName = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.OperatorsQualityFullNameColumn)].ToString();

						if (string.IsNullOrEmpty(fullName))
							continue;

						string employeeKey = GetEmployeeKeyByName(fullName, false);

						if (string.IsNullOrEmpty(employeeKey)) {
							UpdateTextBox("\tНе удалось найти в списке сотрудников запись: " + fullName, true);
							continue;
						}

						string operatorQualityAverageScore = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.OperatorsQualityAverageScoreColumn)].ToString();
						if (operatorQualityAverageScore.ToLower().Contains("не оценивался"))
							continue;
						
						employees[employeeKey].SetQualityAverageScore(operatorQualityAverageScore);
					} catch (Exception e) {
						UpdateTextBox("\tНе удалось обработать строку: " + i + ", " + e.Message, true);
					}
				}
			}
		}

		private void ReadTimetableFact() {
			UpdateTextBox("Обработка табеля (факт)", false, true);

			foreach (string file in fileNameTimetableFactParts) {
				UpdateTextBox("Файл: " + file);

				DataTable dataTable = ReadExcelFile(Properties.Settings.Default.TimetableFactSheetName, file);

				for (int i = Properties.Settings.Default.TimetableFactFirstRow - 1; i < dataTable.Rows.Count; i += 2) {
					try {
						if (i + 1 >= dataTable.Rows.Count)
							break;

						string shortName1 = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.TimetableFactShortNameColumn)].ToString();
						string shortName2 = dataTable.Rows[i + 1]["F" + GetExcelColumnNumber(Properties.Settings.Default.TimetableFactShortNameColumn)].ToString();

						//line with header
						if (shortName1.Equals("2")) {
							i--;
							continue;
						}

						string shortName = shortName1 + shortName2;

						if (string.IsNullOrEmpty(shortName) ||
							shortName.ToLower().Equals("2") ||
							shortName.ToLower().Contains("фамилия"))
							continue;

						string employeeKey = GetEmployeeKeyByName(shortName, true);

						if (string.IsNullOrEmpty(employeeKey)) {
							UpdateTextBox("\tНе удалось найти в списке сотрудников запись: " + shortName, true);
							continue;
						}

						string totalHours = 
							dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.TimetableFactTotalHoursColumn)].ToString() +
							dataTable.Rows[i + 1]["F" + GetExcelColumnNumber(Properties.Settings.Default.TimetableFactTotalHoursColumn)].ToString();

						employees[employeeKey].AddTotalHoursFact(totalHours);

						string nightHours = 
							dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.TimetableFactNightHoursColumn)].ToString() +
							dataTable.Rows[i + 1]["F" + GetExcelColumnNumber(Properties.Settings.Default.TimetableFactNightHoursColumn)].ToString();
						if (string.IsNullOrEmpty(nightHours))
							continue;

						int nightHoursValue = 0;
						int.TryParse(nightHours, out nightHoursValue);
						if (nightHoursValue == 0)
							continue;
						
						employees[employeeKey].HasNightHours = true;

						int firstDayColumn = GetExcelColumnNumber(Properties.Settings.Default.TimetableFactFirstDayColumn);
						int lastDayColumn = GetExcelColumnNumber(Properties.Settings.Default.TimetableFactLastDayColumn);

						int currentDay = 0;
						for (int line = 0; line <= 1; line++) {
							for (int dayColumn = firstDayColumn; dayColumn <= lastDayColumn; dayColumn++) {
								//emptyCell with X value
								if (line == 0 && dayColumn == lastDayColumn)
									continue;
								
								currentDay++;

								string dayValue = dataTable.Rows[i + line]["F" + dayColumn].ToString().ToLower();
								if (string.IsNullOrEmpty(dayValue))
									continue;

								if (dayValue.Contains("у"))
									employees[employeeKey].AddDayToMorningHours(currentDay);

								if (dayValue.Contains("н"))
									employees[employeeKey].AddDayToNightHours(currentDay);
							}
						}



					} catch (Exception e) {
						UpdateTextBox("\tНе удалось обработать строку: " + i + ", " + e.Message, true);
					}
				}
			}
		}


		private void ReadTimetablePlan() {
			UpdateTextBox("Обработка табеля (план на месяц)", false, true);
			UpdateTextBox("Файл: " + fileNameTimetableMonthPlan);

			DataTable dataTable = ReadExcelFile(Properties.Settings.Default.TimetablePlanSheetName, fileNameTimetableMonthPlan);

			for (int i = Properties.Settings.Default.TimetablePlanFirstRow - 1; i < dataTable.Rows.Count; i++) {
				try {
					string shortName = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.TimetablePlanShortNameColumn)].ToString();
					if (string.IsNullOrEmpty(shortName) ||
						shortName.ToLower().Contains("время перерыва") ||
						shortName.ToLower().Contains("руководитель") ||
						shortName.ToLower().Contains("согласовано"))
						continue;

					string employeeKey = GetEmployeeKeyByName(shortName, true);

					if (string.IsNullOrEmpty(employeeKey)) {
						UpdateTextBox("\tНе удалось найти в списке сотрудников запись: " + shortName, true);
						continue;
					}

					employees[employeeKey].SetTotalHours(dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.TimetablePlanTotalHoursColumn)].ToString());
				} catch (Exception e) {
					UpdateTextBox("\tНе удалось обработать строку: " + i + ", " + e.Message, true);
				}
			}
		}

		private string GetEmployeeKeyByName(string name, bool isShortName) {
			name = Employee.TrimWhitespacesFromString(name);

			if (employees.ContainsKey(name))
				return name;

			string loweredFamily = name.ToLower();
			if (loweredFamily.Contains(" "))
				loweredFamily = loweredFamily.Split(' ')[0];

			bool isKeyUnique = true;
			string employeeKey = "";

			foreach (string key in employees.Keys) {
				if (!key.ToLower().Contains(loweredFamily))
					continue;

				if (string.IsNullOrEmpty(employeeKey)) {
					employeeKey = key;
				} else {
					isKeyUnique = false;
				}
			}

			if (!isShortName && (string.IsNullOrEmpty(employeeKey) || !isKeyUnique)) {
				isKeyUnique = true;
				employeeKey = "";

				foreach (string key in employees.Keys) {
					name = name.ToLower();
					if (!employees[key].FullName.ToLower().Equals(name))
						continue;

					if (string.IsNullOrEmpty(employeeKey)) {
						employeeKey = key;
					} else {
						isKeyUnique = false;
					}
				}
			}

			return isKeyUnique ? employeeKey : "";
		}


		private void ReadEmployeesWorkbook() {
			UpdateTextBox("Обработка списка сотрудников", false, true);
			UpdateTextBox("Файл: " + fileNameEmployeesList);
			Dictionary<string, Employee> readedEmployees = new Dictionary<string, Employee>();
			DataTable dataTable = ReadExcelFile(Properties.Settings.Default.EmployeesListSheetName, fileNameEmployeesList);

			for (int i = Properties.Settings.Default.EmployeesListFirstRow - 1; i < dataTable.Rows.Count; i++) {
				Employee employee = new Employee();
				try {
					employee.ShortName = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.EmployeesListShortnameColumn)].ToString();

					if (readedEmployees.ContainsKey(employee.ShortName)) {
						UpdateTextBox("\tНе удалось добавить сотрудника " + employee.ShortName + " (строка " + i +
							"), такая запись уже присутвует в списке", true);
						continue;
					}

					employee.FullName = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.EmployeesListFullnameColumn)].ToString();
					employee.Position = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.EmployeesListPositionColumn)].ToString();
					employee.SetSalary(dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.EmployeesListSalaryColumn)].ToString());
					employee.Rate = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.EmployeesListRateColumn)].ToString();
					employee.Pfr = dataTable.Rows[i]["F" + GetExcelColumnNumber(Properties.Settings.Default.EmployeesListPfrColumn)].ToString();
					readedEmployees.Add(employee.ShortName, employee);
				} catch (Exception e) {
					UpdateTextBox("\tНе удалось обработать строку: " + i + ", " + e.Message, true);
				}
			}

			employees = readedEmployees;
		}




		private DataTable ReadExcelFile(string sheetName, string path) {
			DataTable dataTable = new DataTable();

			try {
				using (OleDbConnection conn = new OleDbConnection()) {
					conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";" + "Extended Properties='Excel 12.0 Xml;HDR=NO;'";

					using (OleDbCommand comm = new OleDbCommand()) {
						comm.CommandText = "Select * from [" + sheetName + "$]";
						comm.Connection = conn;

						using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter()) {
							oleDbDataAdapter.SelectCommand = comm;
							oleDbDataAdapter.Fill(dataTable);
						}
					}
				}
			} catch (Exception e) {
				UpdateTextBox(e.Message);
			}

			return dataTable;
		}

		public int GetExcelColumnNumber(string columnName) {
			if (string.IsNullOrEmpty(columnName)) throw new ArgumentNullException("columnName");

			columnName = columnName.ToUpperInvariant();

			int sum = 0;

			for (int i = 0; i < columnName.Length; i++) {
				sum *= 26;
				sum += (columnName[i] - 'A' + 1);
			}

			return sum;
		}

		private string GetExcelColumnName(int columnNumber) {
			int dividend = columnNumber;
			string columnName = String.Empty;
			int modulo;

			while (dividend > 0) {
				modulo = (dividend - 1) % 26;
				columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
				dividend = (int)((dividend - modulo) / 26);
			}

			return columnName;
		}


		private void UpdateTextBox(string message, bool isError = false, bool isNewSection = false) {
			if (textBox == null) return;

			textBox.BeginInvoke((MethodInvoker)delegate {
				if (isError)
					message = "---ОШИБКА--- " + message;

				if (isNewSection)
					textBox.AppendText("-------------------------------" + Environment.NewLine);

				textBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + message + Environment.NewLine);
			});
		}

		private void UpdateProgressBar(int percentage) {
			if (progressBar == null) return;
			progressBar.BeginInvoke((MethodInvoker)delegate {
				progressBar.Value = percentage;
			});
		}
	}
}
