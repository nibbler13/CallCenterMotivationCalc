using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterMotivationCalc {
	public partial class FormSettings : Form {
		public FormSettings() {
			InitializeComponent();

			textBoxEmployeesListPfrColumn.Text = Properties.Settings.Default.EmployeesListPfrColumn;
			textBoxEmployeesListRateColumn.Text = Properties.Settings.Default.EmployeesListRateColumn;
			textBoxEmployeesListSalaryColumn.Text = Properties.Settings.Default.EmployeesListSalaryColumn;
			textBoxEmployeesListPositionColumn.Text = Properties.Settings.Default.EmployeesListPositionColumn;
			textBoxEmployeesListFullnameColumn.Text = Properties.Settings.Default.EmployeesListFullnameColumn;
			textBoxEmployeesListShortnameColumn.Text = Properties.Settings.Default.EmployeesListShortnameColumn;
			textBoxEmployeesListFirstRow.Text = Properties.Settings.Default.EmployeesListFirstRow.ToString();
			textBoxEmployeesListSheetName.Text = Properties.Settings.Default.EmployeesListSheetName;

			textBoxTimetablePlanTotalHoursColumn.Text = Properties.Settings.Default.TimetablePlanTotalHoursColumn;
			textBoxTimetablePlanShortNameColumn.Text = Properties.Settings.Default.TimetablePlanShortNameColumn;
			textBoxTimetablePlanFirstRow.Text = Properties.Settings.Default.TimetablePlanFirstRow.ToString();
			textBoxTimetablePlanSheetName.Text = Properties.Settings.Default.TimetablePlanSheetName;

			textBoxTimetableFactNightHoursColumn.Text = Properties.Settings.Default.TimetableFactNightHoursColumn;
			textBoxTimetableFactLastDayColumn.Text = Properties.Settings.Default.TimetableFactLastDayColumn;
			textBoxTimetableFactFirstDayColumn.Text = Properties.Settings.Default.TimetableFactFirstDayColumn;
			textBoxTimetableFactTotalHoursColumn.Text = Properties.Settings.Default.TimetableFactTotalHoursColumn;
			textBoxTimetableFactShortNameColumn.Text = Properties.Settings.Default.TimetableFactShortNameColumn;
			textBoxTimetableFactFirstRow.Text = Properties.Settings.Default.TimetableFactFirstRow.ToString();
			textBoxTimetableFactSheetName.Text = Properties.Settings.Default.TimetableFactSheetName;

			textBoxOperatorsQualityMaxCoefficient.Text = Properties.Settings.Default.OperatorsQualityMaxCoefficient.ToString();
			textBoxOperatorsQualityDesiredValue.Text = Properties.Settings.Default.OperatorsQualityDesiredValue.ToString();
			textBoxOperatorsQualityStandardValue.Text = Properties.Settings.Default.OperatorsQualityStandardValue.ToString();
			textBoxOperatorsQualityAverageScoreColumn.Text = Properties.Settings.Default.OperatorsQualityAverageScoreColumn;
			textBoxOperatorsQualityFullNameColumn.Text = Properties.Settings.Default.OperatorsQualityFullNameColumn;
			textBoxOperatorsQualityFirstRow.Text = Properties.Settings.Default.OperatorsQualityFirstRow.ToString();
			textBoxOperatorsQualitySheetName.Text = Properties.Settings.Default.OperatorsQualitySheetName;

			textBoxOperatorsWorktimeDesiredValue.Text = Properties.Settings.Default.OperatorsWorktimeDesiredValue.ToString();
			textBoxOperatorsWorktimeStandardValue.Text = Properties.Settings.Default.OperatorsWorktimeStandardValue.ToString();
			textBoxOperatorsWorktimePauseTimeColumn.Text = Properties.Settings.Default.OperatorsWorktimePauseTimeColumn;
			textBoxOperatorsWorktimeRemainingTimeColumn.Text = Properties.Settings.Default.OperatorsWorktimeRemainingTimeColumn;
			textBoxOperatorsWorktimeTotalCallsTimeColumn.Text = Properties.Settings.Default.OperatorsWorktimeTotalCallsTimeColumn;
			textBoxOperatorsWorktimeFullNameColumn.Text = Properties.Settings.Default.OperatorsWorktimeFullNameColumn;
			textBoxOperatorsWorktimeFirstRow.Text = Properties.Settings.Default.OperatorsWorktimeFirstRow.ToString();
			textBoxOperatorsWorktimeSheetName.Text = Properties.Settings.Default.OperatorsWorktimeSheetName;
			textBoxOperatorsWorktimeMaxCoefficient.Text = Properties.Settings.Default.OperatorsWorktimeMaxCoefficient.ToString();

			textBoxAcceptedAndMissedCallsDesiredValue.Text = Properties.Settings.Default.AcceptedAndMissedCallsDesiredValue.ToString();
			textBoxAcceptedAndMissedCallsStandardValue.Text = Properties.Settings.Default.AcceptedAndMissedCallsStandardValue.ToString();
			textBoxAcceptedAndMissedCallsWrongCallsColumn.Text = Properties.Settings.Default.AcceptedAndMissedCallsWrongCallsColumn;
			textBoxAcceptedAndMissedCallsMissedCallsColumn.Text = Properties.Settings.Default.AcceptedAndMissedCallsMissedCallsColumn;
			textBoxAcceptedAndMissedCallsTotalCallsColumn.Text = Properties.Settings.Default.AcceptedAndMissedCallsTotalCallsColumn;
			textBoxAcceptedAndMissedCallsDateTimeColumn.Text = Properties.Settings.Default.AcceptedAndMissedCallsDateTimeColumn;
			textBoxAcceptedAndMissedCallsFirstRow.Text = Properties.Settings.Default.AcceptedAndMissedCallsFirstRow.ToString();
			textBoxAcceptedAndMissedCallsSheetName.Text = Properties.Settings.Default.AcceptedAndMissedCallsSheetName;
			textBoxAcceptedAndMissedCallsMorningLastHour.Text = Properties.Settings.Default.AcceptedAndMissedCallsMorningLastHour.ToString();
			textBoxAcceptedAndMissedCallsNightFirstHour.Text = Properties.Settings.Default.AcceptedAndMissedCallsNightFirstHour.ToString();
			textBoxAcceptedAndMissedCallsMaxCoefficient.Text = Properties.Settings.Default.AcceptedAndMissedCallsMaxCoefficient.ToString();
		}

		private void buttonSave_Click(object sender, EventArgs e) {
			try {
				Properties.Settings.Default.EmployeesListPfrColumn = textBoxEmployeesListPfrColumn.Text;
				Properties.Settings.Default.EmployeesListRateColumn = textBoxEmployeesListRateColumn.Text;
				Properties.Settings.Default.EmployeesListSalaryColumn = textBoxEmployeesListSalaryColumn.Text;
				Properties.Settings.Default.EmployeesListPositionColumn = textBoxEmployeesListPositionColumn.Text;
				Properties.Settings.Default.EmployeesListFullnameColumn = textBoxEmployeesListFullnameColumn.Text;
				Properties.Settings.Default.EmployeesListShortnameColumn = textBoxEmployeesListShortnameColumn.Text;
				Properties.Settings.Default.EmployeesListFirstRow = int.Parse(textBoxEmployeesListFirstRow.Text);
				Properties.Settings.Default.EmployeesListSheetName = textBoxEmployeesListSheetName.Text;

				Properties.Settings.Default.TimetablePlanTotalHoursColumn = textBoxTimetablePlanTotalHoursColumn.Text;
				Properties.Settings.Default.TimetablePlanShortNameColumn = textBoxTimetablePlanShortNameColumn.Text;
				Properties.Settings.Default.TimetablePlanFirstRow = int.Parse(textBoxTimetablePlanFirstRow.Text);
				Properties.Settings.Default.TimetablePlanSheetName = textBoxTimetablePlanSheetName.Text;

				Properties.Settings.Default.TimetableFactNightHoursColumn = textBoxTimetableFactNightHoursColumn.Text;
				Properties.Settings.Default.TimetableFactLastDayColumn = textBoxTimetableFactLastDayColumn.Text;
				Properties.Settings.Default.TimetableFactFirstDayColumn = textBoxTimetableFactFirstDayColumn.Text;
				Properties.Settings.Default.TimetableFactTotalHoursColumn = textBoxTimetableFactTotalHoursColumn.Text;
				Properties.Settings.Default.TimetableFactShortNameColumn = textBoxTimetableFactShortNameColumn.Text;
				Properties.Settings.Default.TimetableFactFirstRow = int.Parse(textBoxTimetableFactFirstRow.Text);
				Properties.Settings.Default.TimetableFactSheetName = textBoxTimetableFactSheetName.Text;

				Properties.Settings.Default.OperatorsQualityMaxCoefficient = float.Parse(textBoxOperatorsQualityMaxCoefficient.Text);
				Properties.Settings.Default.OperatorsQualityDesiredValue = float.Parse(textBoxOperatorsQualityDesiredValue.Text);
				Properties.Settings.Default.OperatorsQualityStandardValue = float.Parse(textBoxOperatorsQualityStandardValue.Text);
				Properties.Settings.Default.OperatorsQualityAverageScoreColumn = textBoxOperatorsQualityAverageScoreColumn.Text;
				Properties.Settings.Default.OperatorsQualityFullNameColumn = textBoxOperatorsQualityFullNameColumn.Text;
				Properties.Settings.Default.OperatorsQualityFirstRow = int.Parse(textBoxOperatorsQualityFirstRow.Text);
				Properties.Settings.Default.OperatorsQualitySheetName = textBoxOperatorsQualitySheetName.Text;

				Properties.Settings.Default.OperatorsWorktimeDesiredValue = float.Parse(textBoxOperatorsWorktimeDesiredValue.Text);
				Properties.Settings.Default.OperatorsWorktimeStandardValue = float.Parse(textBoxOperatorsWorktimeStandardValue.Text);
				Properties.Settings.Default.OperatorsWorktimePauseTimeColumn = textBoxOperatorsWorktimePauseTimeColumn.Text;
				Properties.Settings.Default.OperatorsWorktimeRemainingTimeColumn = textBoxOperatorsWorktimeRemainingTimeColumn.Text;
				Properties.Settings.Default.OperatorsWorktimeTotalCallsTimeColumn = textBoxOperatorsWorktimeTotalCallsTimeColumn.Text;
				Properties.Settings.Default.OperatorsWorktimeFullNameColumn = textBoxOperatorsWorktimeFullNameColumn.Text;
				Properties.Settings.Default.OperatorsWorktimeFirstRow = int.Parse(textBoxOperatorsWorktimeFirstRow.Text);
				Properties.Settings.Default.OperatorsWorktimeSheetName = textBoxOperatorsWorktimeSheetName.Text;
				Properties.Settings.Default.OperatorsWorktimeMaxCoefficient = float.Parse(textBoxOperatorsWorktimeMaxCoefficient.Text);

				Properties.Settings.Default.AcceptedAndMissedCallsDesiredValue = float.Parse(textBoxAcceptedAndMissedCallsDesiredValue.Text);
				Properties.Settings.Default.AcceptedAndMissedCallsStandardValue = float.Parse(textBoxAcceptedAndMissedCallsStandardValue.Text);
				Properties.Settings.Default.AcceptedAndMissedCallsWrongCallsColumn = textBoxAcceptedAndMissedCallsWrongCallsColumn.Text;
				Properties.Settings.Default.AcceptedAndMissedCallsMissedCallsColumn = textBoxAcceptedAndMissedCallsMissedCallsColumn.Text;
				Properties.Settings.Default.AcceptedAndMissedCallsTotalCallsColumn = textBoxAcceptedAndMissedCallsTotalCallsColumn.Text;
				Properties.Settings.Default.AcceptedAndMissedCallsDateTimeColumn = textBoxAcceptedAndMissedCallsDateTimeColumn.Text;
				Properties.Settings.Default.AcceptedAndMissedCallsFirstRow = int.Parse(textBoxAcceptedAndMissedCallsFirstRow.Text);
				Properties.Settings.Default.AcceptedAndMissedCallsSheetName = textBoxAcceptedAndMissedCallsSheetName.Text;
				Properties.Settings.Default.AcceptedAndMissedCallsMorningLastHour = int.Parse(textBoxAcceptedAndMissedCallsMorningLastHour.Text);
				Properties.Settings.Default.AcceptedAndMissedCallsNightFirstHour = int.Parse(textBoxAcceptedAndMissedCallsNightFirstHour.Text);
				Properties.Settings.Default.AcceptedAndMissedCallsMaxCoefficient = float.Parse(textBoxAcceptedAndMissedCallsMaxCoefficient.Text);

				Properties.Settings.Default.Save();
			} catch (Exception exception) {
				MessageBox.Show(this, exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show(this, "Успешно", "Настройки сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
