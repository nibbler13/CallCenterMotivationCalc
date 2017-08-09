using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CallCenterMotivationCalc {
	public partial class FormMain : Form {
		private Dictionary<Button, Control[]> controls;

		public FormMain() {
			InitializeComponent();

			controls = new Dictionary<Button, Control[]>();
			controls.Add(buttonEmployeesList, new Control[2] { textBoxEmployeesList, groupBoxEmployeesList });
			controls.Add(buttonTimetablePlan, new Control[2] { textBoxTimetablePlan, groupBoxTimetablePlan });
			controls.Add(buttonTimetableFactPartsAdd, new Control[2] { listViewTimetableFactParts, groupBoxTimetableFactParts });
			controls.Add(buttonOperatorsQualityPartsAdd, new Control[2] { listViewOperatorsQualityParts, groupBoxOperatorsQualityParts });
			controls.Add(buttonOperatorsWorktime, new Control[2] { textBoxOperatorsWorktime, groupBoxOperatorsWorktime });
			controls.Add(buttonAcceptedAndMissedCalls, new Control[2] { textBoxAcceptedAndMissedCalls, groupBoxAcceptedAndMissedCalls });

			foreach (Button button in controls.Keys) {
				button.Click += ButtonSelectFile_Click;
				controls[button][1].AllowDrop = true;
				controls[button][1].DragEnter += GroupBoxEmployeesList_DragEnter;
				controls[button][1].DragDrop += GroupBoxEmployeesList_DragDrop;
			}

			buttonTimetableFactPartsRemove.Click += ButtonRemove_Click;
			buttonOperatorsQualityPartsRemove.Click += ButtonRemove_Click;

			if (IsDebug(Assembly.GetExecutingAssembly())) {
				textBoxEmployeesList.Text = Environment.CurrentDirectory + "\\Образцы исходных данных\\Отчет_Сотрудники ИЦ.xlsx";
				textBoxTimetablePlan.Text = Environment.CurrentDirectory + "\\Образцы исходных данных\\График работы УК май.xlsx";
				listViewTimetableFactParts.Items.Add(Environment.CurrentDirectory + "\\Образцы исходных данных\\Табель учета рабочего времени 01.05.17  по 15.05.17.xlsx");
				listViewTimetableFactParts.Items.Add(Environment.CurrentDirectory + "\\Образцы исходных данных\\Табель учета рабочего времени 16.05.17  по 31.05.17.xlsx");
				listViewOperatorsQualityParts.Items.Add(Environment.CurrentDirectory + "\\Образцы исходных данных\\Дерендяева Е.А..xlsx");
				textBoxOperatorsWorktime.Text = Environment.CurrentDirectory + "\\Образцы исходных данных\\Отчет_ опер_шаблон_new_загрузка_исходные.xls";
				textBoxAcceptedAndMissedCalls.Text = Environment.CurrentDirectory + "\\Образцы исходных данных\\Отчет_ Отвеченные и неотвеченные звонки.xls";
				CheckForEnableCalcButton();
			}

			listViewTimetableFactParts.Columns[0].Width = listViewTimetableFactParts.Width - 5;
			listViewOperatorsQualityParts.Columns[0].Width = listViewOperatorsQualityParts.Width - 5;
		}

		private void ButtonRemove_Click(object sender, EventArgs e) {
			ListView listView = (sender == buttonTimetableFactPartsRemove) ? listViewTimetableFactParts : listViewOperatorsQualityParts;
			foreach (ListViewItem item in listView.SelectedItems)
				listView.Items.Remove(item);
			CheckForEnableCalcButton();
		}

		private void GroupBoxEmployeesList_DragDrop(object sender, DragEventArgs e) {
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

			bool isWrongData = false;

			if (files.Length != 1) {
				isWrongData = true;
			} else {
				FileAttributes fileAttribute = File.GetAttributes(files[0]);
				if ((fileAttribute & FileAttributes.Directory) == FileAttributes.Directory)
					isWrongData = true;

				if (!files[0].EndsWith(".xls") &&
					!files[0].EndsWith(".xlsx") &&
					!files[0].EndsWith(".xlsm"))
					isWrongData = true;
			}

			if (isWrongData) {
				MessageBox.Show("Разрешается добавление только одного файла в формате книги Excel (.xls | .xlsx | .xlsm)", 
					"Добавление файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			GroupBox groupBox = (GroupBox)sender;

			foreach (KeyValuePair<Button, Control[]> pair in controls) {
				if (!pair.Value.Contains(groupBox))
					continue;

				if (pair.Value[0] is TextBox) {
					pair.Value[0].Text = files[0];
				} else {
					ListView listView = (ListView)pair.Value[0];
					if (listView.Items.ContainsKey(files[0]))
						break;

					ListViewItem listViewItem = new ListViewItem(files[0]);
					listViewItem.Name = files[0];
					listView.Items.Add(listViewItem);
				}
				
				CheckForEnableCalcButton();
				break;
			}
		}

		private void GroupBoxEmployeesList_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Link;
		}

		private void ButtonCalc_Click(object sender, EventArgs e) {
			List<string> timetableFactParts = new List<string>();
			foreach (ListViewItem item in listViewTimetableFactParts.Items)
				timetableFactParts.Add(item.SubItems[0].Text);

			List<string> operatorsQualityParts = new List<string>();
			foreach (ListViewItem item in listViewOperatorsQualityParts.Items)
				operatorsQualityParts.Add(item.SubItems[0].Text);

			ExcelParser excelParser = new ExcelParser(
				textBoxEmployeesList.Text,
				textBoxTimetablePlan.Text, 
				timetableFactParts.ToArray(),
				operatorsQualityParts.ToArray(),
				textBoxOperatorsWorktime.Text,
				textBoxAcceptedAndMissedCalls.Text,
				dateTimePicker.Value);

			FormDetails form = new FormDetails(excelParser);
			form.Width = Width;
			form.Height = Height;
			form.ShowDialog();
		}

		private void ButtonSelectFile_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Книга Excel|*.xls;*.xlsx;*xlsm";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.Multiselect = 
				sender == buttonTimetableFactPartsAdd ||
				sender == buttonOperatorsQualityPartsAdd;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				foreach (string fileName in openFileDialog.FileNames) {
					if (!fileName.Contains(".xls") &&
						!fileName.Contains(".xlsx") &&
						!fileName.Contains(".xlsm"))
						continue;

					if (openFileDialog.Multiselect) {
						ListView listView = (ListView)controls[(sender as Button)][0];
						if (listView.Items.ContainsKey(fileName))
							continue;

						ListViewItem listViewItem = new ListViewItem(fileName);
						listViewItem.Name = fileName;
						listView.Items.Add(listViewItem);
					} else {
						controls[(sender as Button)][0].Text = fileName;
					}
				}

				CheckForEnableCalcButton();
			}
		}

		private void CheckForEnableCalcButton() {
			bool isAllFilled = true;

			foreach (KeyValuePair<Button, Control[]> pair in controls) {
				Control control = pair.Value[0];
				if (control is TextBox) {
					if (string.IsNullOrEmpty(control.Text))
						isAllFilled = false;
				} else {
					if (((ListView)control).Items.Count == 0)
						isAllFilled = false;
				}
			}
			
			buttonCalc.Enabled = isAllFilled;
		}

		public static bool IsDebug(Assembly assembly) {
			object[] attributes = assembly.GetCustomAttributes(typeof(DebuggableAttribute), true);
			if (attributes == null || attributes.Length == 0)
				return true;

			var d = (DebuggableAttribute)attributes[0];
			if (d.IsJITTrackingEnabled) return true;
			return false;
		}

		private void buttonSettings_Click(object sender, EventArgs e) {
			FormSettings formSettings = new FormSettings();
			formSettings.ShowDialog();
		}

		private void buttonAbout_Click(object sender, EventArgs e) {
			AboutBox aboutBox = new AboutBox();
			aboutBox.ShowDialog();
		}
	}
}
