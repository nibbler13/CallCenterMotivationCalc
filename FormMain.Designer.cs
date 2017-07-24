namespace CallCenterMotivationCalc {
	partial class FormMain {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.labelTitle = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonCalc = new System.Windows.Forms.Button();
			this.textBoxWorkersList = new System.Windows.Forms.TextBox();
			this.groupBoxWorkersList = new System.Windows.Forms.GroupBox();
			this.buttonWorkersList = new System.Windows.Forms.Button();
			this.groupBoxTimesheetPlan = new System.Windows.Forms.GroupBox();
			this.buttonTimesheetPlan = new System.Windows.Forms.Button();
			this.textBoxTimesheetPlan = new System.Windows.Forms.TextBox();
			this.groupBoxTimesheetFact1 = new System.Windows.Forms.GroupBox();
			this.buttonTimesheetFact1 = new System.Windows.Forms.Button();
			this.textBoxTimesheetFact1 = new System.Windows.Forms.TextBox();
			this.groupBoxKok = new System.Windows.Forms.GroupBox();
			this.buttonKok = new System.Windows.Forms.Button();
			this.textBoxKok = new System.Windows.Forms.TextBox();
			this.groupBoxOperatorsWorkTime = new System.Windows.Forms.GroupBox();
			this.buttonOperatorsWorkTime = new System.Windows.Forms.Button();
			this.textBoxOperatorsWorkTime = new System.Windows.Forms.TextBox();
			this.groupBoxAcceptedAndMissedCalls = new System.Windows.Forms.GroupBox();
			this.buttonAcceptedAndMissedCalls = new System.Windows.Forms.Button();
			this.textBoxAcceptedAndMissedCalls = new System.Windows.Forms.TextBox();
			this.groupBoxTimesheetFact2 = new System.Windows.Forms.GroupBox();
			this.buttonTimesheetFact2 = new System.Windows.Forms.Button();
			this.textBoxTimesheetFact2 = new System.Windows.Forms.TextBox();
			this.groupBoxWorkersList.SuspendLayout();
			this.groupBoxTimesheetPlan.SuspendLayout();
			this.groupBoxTimesheetFact1.SuspendLayout();
			this.groupBoxKok.SuspendLayout();
			this.groupBoxOperatorsWorkTime.SuspendLayout();
			this.groupBoxAcceptedAndMissedCalls.SuspendLayout();
			this.groupBoxTimesheetFact2.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(12, 9);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(305, 13);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Задайте расположение необходимых для расчета файлов:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 504);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 13);
			this.label7.TabIndex = 6;
			// 
			// buttonCalc
			// 
			this.buttonCalc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonCalc.Enabled = false;
			this.buttonCalc.Location = new System.Drawing.Point(141, 395);
			this.buttonCalc.Name = "buttonCalc";
			this.buttonCalc.Size = new System.Drawing.Size(125, 23);
			this.buttonCalc.TabIndex = 8;
			this.buttonCalc.Text = "Выполнить расчет";
			this.buttonCalc.UseVisualStyleBackColor = true;
			// 
			// textBoxWorkersList
			// 
			this.textBoxWorkersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxWorkersList.Location = new System.Drawing.Point(6, 17);
			this.textBoxWorkersList.Name = "textBoxWorkersList";
			this.textBoxWorkersList.ReadOnly = true;
			this.textBoxWorkersList.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxWorkersList.Size = new System.Drawing.Size(338, 20);
			this.textBoxWorkersList.TabIndex = 0;
			// 
			// groupBoxWorkersList
			// 
			this.groupBoxWorkersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxWorkersList.Controls.Add(this.buttonWorkersList);
			this.groupBoxWorkersList.Controls.Add(this.textBoxWorkersList);
			this.groupBoxWorkersList.Location = new System.Drawing.Point(12, 38);
			this.groupBoxWorkersList.Name = "groupBoxWorkersList";
			this.groupBoxWorkersList.Size = new System.Drawing.Size(382, 45);
			this.groupBoxWorkersList.TabIndex = 9;
			this.groupBoxWorkersList.TabStop = false;
			this.groupBoxWorkersList.Text = "Список сотрудников";
			// 
			// buttonWorkersList
			// 
			this.buttonWorkersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonWorkersList.AutoSize = true;
			this.buttonWorkersList.Location = new System.Drawing.Point(350, 15);
			this.buttonWorkersList.Name = "buttonWorkersList";
			this.buttonWorkersList.Size = new System.Drawing.Size(26, 23);
			this.buttonWorkersList.TabIndex = 1;
			this.buttonWorkersList.Text = "...";
			this.buttonWorkersList.UseVisualStyleBackColor = true;
			// 
			// groupBoxTimesheetPlan
			// 
			this.groupBoxTimesheetPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxTimesheetPlan.Controls.Add(this.buttonTimesheetPlan);
			this.groupBoxTimesheetPlan.Controls.Add(this.textBoxTimesheetPlan);
			this.groupBoxTimesheetPlan.Location = new System.Drawing.Point(12, 89);
			this.groupBoxTimesheetPlan.Name = "groupBoxTimesheetPlan";
			this.groupBoxTimesheetPlan.Size = new System.Drawing.Size(382, 45);
			this.groupBoxTimesheetPlan.TabIndex = 10;
			this.groupBoxTimesheetPlan.TabStop = false;
			this.groupBoxTimesheetPlan.Text = "Табель (план на месяц)";
			// 
			// buttonTimesheetPlan
			// 
			this.buttonTimesheetPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimesheetPlan.AutoSize = true;
			this.buttonTimesheetPlan.Location = new System.Drawing.Point(350, 15);
			this.buttonTimesheetPlan.Name = "buttonTimesheetPlan";
			this.buttonTimesheetPlan.Size = new System.Drawing.Size(26, 23);
			this.buttonTimesheetPlan.TabIndex = 2;
			this.buttonTimesheetPlan.Text = "...";
			this.buttonTimesheetPlan.UseVisualStyleBackColor = true;
			// 
			// textBoxTimesheetPlan
			// 
			this.textBoxTimesheetPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTimesheetPlan.Location = new System.Drawing.Point(6, 17);
			this.textBoxTimesheetPlan.Name = "textBoxTimesheetPlan";
			this.textBoxTimesheetPlan.ReadOnly = true;
			this.textBoxTimesheetPlan.Size = new System.Drawing.Size(338, 20);
			this.textBoxTimesheetPlan.TabIndex = 0;
			// 
			// groupBoxTimesheetFact1
			// 
			this.groupBoxTimesheetFact1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxTimesheetFact1.Controls.Add(this.buttonTimesheetFact1);
			this.groupBoxTimesheetFact1.Controls.Add(this.textBoxTimesheetFact1);
			this.groupBoxTimesheetFact1.Location = new System.Drawing.Point(12, 140);
			this.groupBoxTimesheetFact1.Name = "groupBoxTimesheetFact1";
			this.groupBoxTimesheetFact1.Size = new System.Drawing.Size(382, 45);
			this.groupBoxTimesheetFact1.TabIndex = 11;
			this.groupBoxTimesheetFact1.TabStop = false;
			this.groupBoxTimesheetFact1.Text = "Табель (факт за первую половину)";
			// 
			// buttonTimesheetFact1
			// 
			this.buttonTimesheetFact1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimesheetFact1.AutoSize = true;
			this.buttonTimesheetFact1.Location = new System.Drawing.Point(350, 15);
			this.buttonTimesheetFact1.Name = "buttonTimesheetFact1";
			this.buttonTimesheetFact1.Size = new System.Drawing.Size(26, 23);
			this.buttonTimesheetFact1.TabIndex = 3;
			this.buttonTimesheetFact1.Text = "...";
			this.buttonTimesheetFact1.UseVisualStyleBackColor = true;
			// 
			// textBoxTimesheetFact1
			// 
			this.textBoxTimesheetFact1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTimesheetFact1.Location = new System.Drawing.Point(6, 17);
			this.textBoxTimesheetFact1.Name = "textBoxTimesheetFact1";
			this.textBoxTimesheetFact1.ReadOnly = true;
			this.textBoxTimesheetFact1.Size = new System.Drawing.Size(338, 20);
			this.textBoxTimesheetFact1.TabIndex = 0;
			// 
			// groupBoxKok
			// 
			this.groupBoxKok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxKok.Controls.Add(this.buttonKok);
			this.groupBoxKok.Controls.Add(this.textBoxKok);
			this.groupBoxKok.Location = new System.Drawing.Point(12, 242);
			this.groupBoxKok.Name = "groupBoxKok";
			this.groupBoxKok.Size = new System.Drawing.Size(382, 45);
			this.groupBoxKok.TabIndex = 12;
			this.groupBoxKok.TabStop = false;
			this.groupBoxKok.Text = "КОК (сводный)";
			// 
			// buttonKok
			// 
			this.buttonKok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonKok.AutoSize = true;
			this.buttonKok.Location = new System.Drawing.Point(350, 15);
			this.buttonKok.Name = "buttonKok";
			this.buttonKok.Size = new System.Drawing.Size(26, 23);
			this.buttonKok.TabIndex = 5;
			this.buttonKok.Text = "...";
			this.buttonKok.UseVisualStyleBackColor = true;
			// 
			// textBoxKok
			// 
			this.textBoxKok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxKok.Location = new System.Drawing.Point(6, 17);
			this.textBoxKok.Name = "textBoxKok";
			this.textBoxKok.ReadOnly = true;
			this.textBoxKok.Size = new System.Drawing.Size(338, 20);
			this.textBoxKok.TabIndex = 0;
			// 
			// groupBoxOperatorsWorkTime
			// 
			this.groupBoxOperatorsWorkTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxOperatorsWorkTime.Controls.Add(this.buttonOperatorsWorkTime);
			this.groupBoxOperatorsWorkTime.Controls.Add(this.textBoxOperatorsWorkTime);
			this.groupBoxOperatorsWorkTime.Location = new System.Drawing.Point(12, 293);
			this.groupBoxOperatorsWorkTime.Name = "groupBoxOperatorsWorkTime";
			this.groupBoxOperatorsWorkTime.Size = new System.Drawing.Size(382, 45);
			this.groupBoxOperatorsWorkTime.TabIndex = 13;
			this.groupBoxOperatorsWorkTime.TabStop = false;
			this.groupBoxOperatorsWorkTime.Text = "Время работы операторов";
			// 
			// buttonOperatorsWorkTime
			// 
			this.buttonOperatorsWorkTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOperatorsWorkTime.AutoSize = true;
			this.buttonOperatorsWorkTime.Location = new System.Drawing.Point(350, 15);
			this.buttonOperatorsWorkTime.Name = "buttonOperatorsWorkTime";
			this.buttonOperatorsWorkTime.Size = new System.Drawing.Size(26, 23);
			this.buttonOperatorsWorkTime.TabIndex = 6;
			this.buttonOperatorsWorkTime.Text = "...";
			this.buttonOperatorsWorkTime.UseVisualStyleBackColor = true;
			// 
			// textBoxOperatorsWorkTime
			// 
			this.textBoxOperatorsWorkTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOperatorsWorkTime.Location = new System.Drawing.Point(6, 17);
			this.textBoxOperatorsWorkTime.Name = "textBoxOperatorsWorkTime";
			this.textBoxOperatorsWorkTime.ReadOnly = true;
			this.textBoxOperatorsWorkTime.Size = new System.Drawing.Size(338, 20);
			this.textBoxOperatorsWorkTime.TabIndex = 0;
			// 
			// groupBoxAcceptedAndMissedCalls
			// 
			this.groupBoxAcceptedAndMissedCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAcceptedAndMissedCalls.Controls.Add(this.buttonAcceptedAndMissedCalls);
			this.groupBoxAcceptedAndMissedCalls.Controls.Add(this.textBoxAcceptedAndMissedCalls);
			this.groupBoxAcceptedAndMissedCalls.Location = new System.Drawing.Point(12, 344);
			this.groupBoxAcceptedAndMissedCalls.Name = "groupBoxAcceptedAndMissedCalls";
			this.groupBoxAcceptedAndMissedCalls.Size = new System.Drawing.Size(382, 45);
			this.groupBoxAcceptedAndMissedCalls.TabIndex = 14;
			this.groupBoxAcceptedAndMissedCalls.TabStop = false;
			this.groupBoxAcceptedAndMissedCalls.Text = "Отвеченные и неотвеченные звонки";
			// 
			// buttonAcceptedAndMissedCalls
			// 
			this.buttonAcceptedAndMissedCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAcceptedAndMissedCalls.AutoSize = true;
			this.buttonAcceptedAndMissedCalls.Location = new System.Drawing.Point(350, 15);
			this.buttonAcceptedAndMissedCalls.Name = "buttonAcceptedAndMissedCalls";
			this.buttonAcceptedAndMissedCalls.Size = new System.Drawing.Size(26, 23);
			this.buttonAcceptedAndMissedCalls.TabIndex = 7;
			this.buttonAcceptedAndMissedCalls.Text = "...";
			this.buttonAcceptedAndMissedCalls.UseVisualStyleBackColor = true;
			// 
			// textBoxAcceptedAndMissedCalls
			// 
			this.textBoxAcceptedAndMissedCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAcceptedAndMissedCalls.Location = new System.Drawing.Point(6, 17);
			this.textBoxAcceptedAndMissedCalls.Name = "textBoxAcceptedAndMissedCalls";
			this.textBoxAcceptedAndMissedCalls.ReadOnly = true;
			this.textBoxAcceptedAndMissedCalls.Size = new System.Drawing.Size(338, 20);
			this.textBoxAcceptedAndMissedCalls.TabIndex = 0;
			// 
			// groupBoxTimesheetFact2
			// 
			this.groupBoxTimesheetFact2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxTimesheetFact2.Controls.Add(this.buttonTimesheetFact2);
			this.groupBoxTimesheetFact2.Controls.Add(this.textBoxTimesheetFact2);
			this.groupBoxTimesheetFact2.Location = new System.Drawing.Point(12, 191);
			this.groupBoxTimesheetFact2.Name = "groupBoxTimesheetFact2";
			this.groupBoxTimesheetFact2.Size = new System.Drawing.Size(382, 45);
			this.groupBoxTimesheetFact2.TabIndex = 12;
			this.groupBoxTimesheetFact2.TabStop = false;
			this.groupBoxTimesheetFact2.Text = "Табель (факт за вторую половину)";
			// 
			// buttonTimesheetFact2
			// 
			this.buttonTimesheetFact2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimesheetFact2.AutoSize = true;
			this.buttonTimesheetFact2.Location = new System.Drawing.Point(350, 15);
			this.buttonTimesheetFact2.Name = "buttonTimesheetFact2";
			this.buttonTimesheetFact2.Size = new System.Drawing.Size(26, 23);
			this.buttonTimesheetFact2.TabIndex = 4;
			this.buttonTimesheetFact2.Text = "...";
			this.buttonTimesheetFact2.UseVisualStyleBackColor = true;
			// 
			// textBoxTimesheetFact2
			// 
			this.textBoxTimesheetFact2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTimesheetFact2.Location = new System.Drawing.Point(6, 17);
			this.textBoxTimesheetFact2.Name = "textBoxTimesheetFact2";
			this.textBoxTimesheetFact2.ReadOnly = true;
			this.textBoxTimesheetFact2.Size = new System.Drawing.Size(338, 20);
			this.textBoxTimesheetFact2.TabIndex = 0;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 427);
			this.Controls.Add(this.groupBoxTimesheetFact2);
			this.Controls.Add(this.groupBoxAcceptedAndMissedCalls);
			this.Controls.Add(this.groupBoxOperatorsWorkTime);
			this.Controls.Add(this.groupBoxKok);
			this.Controls.Add(this.groupBoxTimesheetFact1);
			this.Controls.Add(this.groupBoxTimesheetPlan);
			this.Controls.Add(this.groupBoxWorkersList);
			this.Controls.Add(this.buttonCalc);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Расчет мотивации для сотрудников колл-центра";
			this.groupBoxWorkersList.ResumeLayout(false);
			this.groupBoxWorkersList.PerformLayout();
			this.groupBoxTimesheetPlan.ResumeLayout(false);
			this.groupBoxTimesheetPlan.PerformLayout();
			this.groupBoxTimesheetFact1.ResumeLayout(false);
			this.groupBoxTimesheetFact1.PerformLayout();
			this.groupBoxKok.ResumeLayout(false);
			this.groupBoxKok.PerformLayout();
			this.groupBoxOperatorsWorkTime.ResumeLayout(false);
			this.groupBoxOperatorsWorkTime.PerformLayout();
			this.groupBoxAcceptedAndMissedCalls.ResumeLayout(false);
			this.groupBoxAcceptedAndMissedCalls.PerformLayout();
			this.groupBoxTimesheetFact2.ResumeLayout(false);
			this.groupBoxTimesheetFact2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonCalc;
		private System.Windows.Forms.TextBox textBoxWorkersList;
		private System.Windows.Forms.GroupBox groupBoxWorkersList;
		private System.Windows.Forms.Button buttonWorkersList;
		private System.Windows.Forms.GroupBox groupBoxTimesheetPlan;
		private System.Windows.Forms.Button buttonTimesheetPlan;
		private System.Windows.Forms.TextBox textBoxTimesheetPlan;
		private System.Windows.Forms.GroupBox groupBoxTimesheetFact1;
		private System.Windows.Forms.Button buttonTimesheetFact1;
		private System.Windows.Forms.TextBox textBoxTimesheetFact1;
		private System.Windows.Forms.GroupBox groupBoxKok;
		private System.Windows.Forms.Button buttonKok;
		private System.Windows.Forms.TextBox textBoxKok;
		private System.Windows.Forms.GroupBox groupBoxOperatorsWorkTime;
		private System.Windows.Forms.Button buttonOperatorsWorkTime;
		private System.Windows.Forms.TextBox textBoxOperatorsWorkTime;
		private System.Windows.Forms.GroupBox groupBoxAcceptedAndMissedCalls;
		private System.Windows.Forms.Button buttonAcceptedAndMissedCalls;
		private System.Windows.Forms.TextBox textBoxAcceptedAndMissedCalls;
		private System.Windows.Forms.GroupBox groupBoxTimesheetFact2;
		private System.Windows.Forms.Button buttonTimesheetFact2;
		private System.Windows.Forms.TextBox textBoxTimesheetFact2;
	}
}

