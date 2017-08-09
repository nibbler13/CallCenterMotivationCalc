using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterMotivationCalc {
	public partial class FormDetails : Form {
		private ExcelParser excelParser;

		public FormDetails(ExcelParser excelParser) {
			InitializeComponent();
			this.excelParser = excelParser;
		}

		private void FormDetails_Load(object sender, EventArgs e) {
			Console.WriteLine("FormLoad");

			Cursor = Cursors.WaitCursor;
			backgroundWorker.RunWorkerAsync();
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
			excelParser.AnalyzeFiles(textBox, progressBar);
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			Cursor = Cursors.Default;

			if (e.Error == null) {
				MessageBox.Show(this, "Все операции завершены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				MessageBox.Show(this, e.Error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
