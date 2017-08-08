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
			MessageBox.Show("Completed");
			Cursor = Cursors.Default;

			if (e.Error != null) {
				Console.WriteLine(e.Error.Message + " " + e.Error.StackTrace);
			}
		}
	}
}
