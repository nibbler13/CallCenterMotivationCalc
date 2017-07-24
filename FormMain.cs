using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CallCenterMotivationCalc {
	public partial class FormMain : Form {
		private Dictionary<Button, Control[]> controls;

		public FormMain() {
			InitializeComponent();

			controls = new Dictionary<Button, Control[]>();
			controls.Add(buttonWorkersList, new Control[2] { textBoxWorkersList, groupBoxWorkersList });
			controls.Add(buttonTimesheetPlan, new Control[2] { textBoxTimesheetPlan, groupBoxTimesheetPlan });
			controls.Add(buttonTimesheetFact1, new Control[2] { textBoxTimesheetFact1, groupBoxTimesheetFact1 });
			controls.Add(buttonTimesheetFact2, new Control[2] { textBoxTimesheetFact2, groupBoxTimesheetFact2 });
			controls.Add(buttonKok, new Control[2] { textBoxKok, groupBoxKok });
			controls.Add(buttonOperatorsWorkTime, new Control[2] { textBoxOperatorsWorkTime, groupBoxOperatorsWorkTime });
			controls.Add(buttonAcceptedAndMissedCalls, new Control[2] { textBoxAcceptedAndMissedCalls, groupBoxAcceptedAndMissedCalls });

			foreach (Button button in controls.Keys) {
				button.Click += ButtonSelectFile_Click;
				controls[button][1].AllowDrop = true;
				controls[button][1].DragEnter += GroupBoxWorkersList_DragEnter;
				controls[button][1].DragDrop += GroupBoxWorkersList_DragDrop;
			}

			buttonCalc.Click += ButtonCalc_Click;
		}

		private void GroupBoxWorkersList_DragDrop(object sender, DragEventArgs e) {
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

			foreach(KeyValuePair<Button, Control[]> pair in controls)
				if (pair.Value.Contains(groupBox)) {
					pair.Value[0].Text = files[0];
					CheckForEnableCalcButton();
					break;
				}
		}

		private void GroupBoxWorkersList_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Link;
		}

		private void ButtonCalc_Click(object sender, EventArgs e) {
			FormDetails form = new FormDetails();
			form.StartPosition = FormStartPosition.Manual;
			form.ShowDialog(this);
		}

		private void ButtonSelectFile_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Книга Excel|*.xls;*.xlsx;*xlsm";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				string fileName = openFileDialog.FileName;
				if (!fileName.Contains(".xls") &&
					!fileName.Contains(".xlsx") &&
					!fileName.Contains(".xlsm"))
					return;

				controls[(sender as Button)][0].Text = fileName;
				CheckForEnableCalcButton();
			}
		}

		private void CheckForEnableCalcButton() {
			bool isAllFilled = true;

			foreach (KeyValuePair<Button, Control[]> pair in controls)
				if (pair.Value[0].Text == "")
					isAllFilled = false;

			//if (isAllFilled)
				buttonCalc.Enabled = true;
		}
	}
}
