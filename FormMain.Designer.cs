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
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.labelTitle = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonCalc = new System.Windows.Forms.Button();
			this.textBoxEmployeesList = new System.Windows.Forms.TextBox();
			this.groupBoxEmployeesList = new System.Windows.Forms.GroupBox();
			this.buttonEmployeesList = new System.Windows.Forms.Button();
			this.groupBoxTimetablePlan = new System.Windows.Forms.GroupBox();
			this.buttonTimetablePlan = new System.Windows.Forms.Button();
			this.textBoxTimetablePlan = new System.Windows.Forms.TextBox();
			this.groupBoxTimetableFactParts = new System.Windows.Forms.GroupBox();
			this.buttonTimetableFactPartsRemove = new System.Windows.Forms.Button();
			this.listViewTimetableFactParts = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonTimetableFactPartsAdd = new System.Windows.Forms.Button();
			this.groupBoxOperatorsQualityParts = new System.Windows.Forms.GroupBox();
			this.buttonOperatorsQualityPartsRemove = new System.Windows.Forms.Button();
			this.listViewOperatorsQualityParts = new System.Windows.Forms.ListView();
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonOperatorsQualityPartsAdd = new System.Windows.Forms.Button();
			this.groupBoxOperatorsWorktime = new System.Windows.Forms.GroupBox();
			this.buttonOperatorsWorktime = new System.Windows.Forms.Button();
			this.textBoxOperatorsWorktime = new System.Windows.Forms.TextBox();
			this.groupBoxAcceptedAndMissedCalls = new System.Windows.Forms.GroupBox();
			this.buttonAcceptedAndMissedCalls = new System.Windows.Forms.Button();
			this.textBoxAcceptedAndMissedCalls = new System.Windows.Forms.TextBox();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.buttonSettings = new System.Windows.Forms.Button();
			this.buttonAbout = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			this.groupBoxEmployeesList.SuspendLayout();
			this.groupBoxTimetablePlan.SuspendLayout();
			this.groupBoxTimetableFactParts.SuspendLayout();
			this.groupBoxOperatorsQualityParts.SuspendLayout();
			this.groupBoxOperatorsWorktime.SuspendLayout();
			this.groupBoxAcceptedAndMissedCalls.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(129, 429);
			label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(104, 13);
			label1.TabIndex = 16;
			label1.Text = "Расчетный период:";
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
			this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCalc.Enabled = false;
			this.buttonCalc.Location = new System.Drawing.Point(347, 458);
			this.buttonCalc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.buttonCalc.Name = "buttonCalc";
			this.buttonCalc.Size = new System.Drawing.Size(125, 23);
			this.buttonCalc.TabIndex = 8;
			this.buttonCalc.Text = "Выполнить расчет";
			this.buttonCalc.UseVisualStyleBackColor = true;
			this.buttonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
			// 
			// textBoxEmployeesList
			// 
			this.textBoxEmployeesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxEmployeesList.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxEmployeesList.Location = new System.Drawing.Point(6, 17);
			this.textBoxEmployeesList.Name = "textBoxEmployeesList";
			this.textBoxEmployeesList.ReadOnly = true;
			this.textBoxEmployeesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxEmployeesList.Size = new System.Drawing.Size(416, 20);
			this.textBoxEmployeesList.TabIndex = 0;
			// 
			// groupBoxEmployeesList
			// 
			this.groupBoxEmployeesList.Controls.Add(this.buttonEmployeesList);
			this.groupBoxEmployeesList.Controls.Add(this.textBoxEmployeesList);
			this.groupBoxEmployeesList.Location = new System.Drawing.Point(12, 32);
			this.groupBoxEmployeesList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.groupBoxEmployeesList.Name = "groupBoxEmployeesList";
			this.groupBoxEmployeesList.Size = new System.Drawing.Size(460, 45);
			this.groupBoxEmployeesList.TabIndex = 9;
			this.groupBoxEmployeesList.TabStop = false;
			this.groupBoxEmployeesList.Text = "Список сотрудников";
			// 
			// buttonEmployeesList
			// 
			this.buttonEmployeesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEmployeesList.AutoSize = true;
			this.buttonEmployeesList.Location = new System.Drawing.Point(428, 15);
			this.buttonEmployeesList.Name = "buttonEmployeesList";
			this.buttonEmployeesList.Size = new System.Drawing.Size(26, 23);
			this.buttonEmployeesList.TabIndex = 1;
			this.buttonEmployeesList.Text = "...";
			this.buttonEmployeesList.UseVisualStyleBackColor = true;
			// 
			// groupBoxTimetablePlan
			// 
			this.groupBoxTimetablePlan.Controls.Add(this.buttonTimetablePlan);
			this.groupBoxTimetablePlan.Controls.Add(this.textBoxTimetablePlan);
			this.groupBoxTimetablePlan.Location = new System.Drawing.Point(12, 83);
			this.groupBoxTimetablePlan.Name = "groupBoxTimetablePlan";
			this.groupBoxTimetablePlan.Size = new System.Drawing.Size(460, 45);
			this.groupBoxTimetablePlan.TabIndex = 10;
			this.groupBoxTimetablePlan.TabStop = false;
			this.groupBoxTimetablePlan.Text = "Табель (план на месяц)";
			// 
			// buttonTimetablePlan
			// 
			this.buttonTimetablePlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimetablePlan.AutoSize = true;
			this.buttonTimetablePlan.Location = new System.Drawing.Point(428, 15);
			this.buttonTimetablePlan.Name = "buttonTimetablePlan";
			this.buttonTimetablePlan.Size = new System.Drawing.Size(26, 23);
			this.buttonTimetablePlan.TabIndex = 2;
			this.buttonTimetablePlan.Text = "...";
			this.buttonTimetablePlan.UseVisualStyleBackColor = true;
			// 
			// textBoxTimetablePlan
			// 
			this.textBoxTimetablePlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTimetablePlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxTimetablePlan.Location = new System.Drawing.Point(6, 17);
			this.textBoxTimetablePlan.Name = "textBoxTimetablePlan";
			this.textBoxTimetablePlan.ReadOnly = true;
			this.textBoxTimetablePlan.Size = new System.Drawing.Size(416, 20);
			this.textBoxTimetablePlan.TabIndex = 0;
			// 
			// groupBoxTimetableFactParts
			// 
			this.groupBoxTimetableFactParts.Controls.Add(this.buttonTimetableFactPartsRemove);
			this.groupBoxTimetableFactParts.Controls.Add(this.listViewTimetableFactParts);
			this.groupBoxTimetableFactParts.Controls.Add(this.buttonTimetableFactPartsAdd);
			this.groupBoxTimetableFactParts.Location = new System.Drawing.Point(12, 134);
			this.groupBoxTimetableFactParts.Name = "groupBoxTimetableFactParts";
			this.groupBoxTimetableFactParts.Size = new System.Drawing.Size(460, 85);
			this.groupBoxTimetableFactParts.TabIndex = 11;
			this.groupBoxTimetableFactParts.TabStop = false;
			this.groupBoxTimetableFactParts.Text = "Табель (факт, один или несколько файлов)";
			// 
			// buttonTimetableFactPartsRemove
			// 
			this.buttonTimetableFactPartsRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimetableFactPartsRemove.AutoSize = true;
			this.buttonTimetableFactPartsRemove.Location = new System.Drawing.Point(428, 56);
			this.buttonTimetableFactPartsRemove.Name = "buttonTimetableFactPartsRemove";
			this.buttonTimetableFactPartsRemove.Size = new System.Drawing.Size(26, 23);
			this.buttonTimetableFactPartsRemove.TabIndex = 5;
			this.buttonTimetableFactPartsRemove.Text = "–";
			this.buttonTimetableFactPartsRemove.UseVisualStyleBackColor = true;
			// 
			// listViewTimetableFactParts
			// 
			this.listViewTimetableFactParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewTimetableFactParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listViewTimetableFactParts.FullRowSelect = true;
			this.listViewTimetableFactParts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTimetableFactParts.Location = new System.Drawing.Point(6, 19);
			this.listViewTimetableFactParts.Name = "listViewTimetableFactParts";
			this.listViewTimetableFactParts.ShowItemToolTips = true;
			this.listViewTimetableFactParts.Size = new System.Drawing.Size(416, 60);
			this.listViewTimetableFactParts.TabIndex = 4;
			this.listViewTimetableFactParts.UseCompatibleStateImageBehavior = false;
			this.listViewTimetableFactParts.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Имя файла";
			this.columnHeader1.Width = 365;
			// 
			// buttonTimetableFactPartsAdd
			// 
			this.buttonTimetableFactPartsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimetableFactPartsAdd.AutoSize = true;
			this.buttonTimetableFactPartsAdd.Location = new System.Drawing.Point(428, 19);
			this.buttonTimetableFactPartsAdd.Name = "buttonTimetableFactPartsAdd";
			this.buttonTimetableFactPartsAdd.Size = new System.Drawing.Size(26, 23);
			this.buttonTimetableFactPartsAdd.TabIndex = 3;
			this.buttonTimetableFactPartsAdd.Text = "+";
			this.buttonTimetableFactPartsAdd.UseVisualStyleBackColor = true;
			// 
			// groupBoxOperatorsQualityParts
			// 
			this.groupBoxOperatorsQualityParts.Controls.Add(this.buttonOperatorsQualityPartsRemove);
			this.groupBoxOperatorsQualityParts.Controls.Add(this.listViewOperatorsQualityParts);
			this.groupBoxOperatorsQualityParts.Controls.Add(this.buttonOperatorsQualityPartsAdd);
			this.groupBoxOperatorsQualityParts.Location = new System.Drawing.Point(12, 225);
			this.groupBoxOperatorsQualityParts.Name = "groupBoxOperatorsQualityParts";
			this.groupBoxOperatorsQualityParts.Size = new System.Drawing.Size(460, 85);
			this.groupBoxOperatorsQualityParts.TabIndex = 12;
			this.groupBoxOperatorsQualityParts.TabStop = false;
			this.groupBoxOperatorsQualityParts.Text = "Качество работы операторов (один или несколько файлов)";
			// 
			// buttonOperatorsQualityPartsRemove
			// 
			this.buttonOperatorsQualityPartsRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOperatorsQualityPartsRemove.AutoSize = true;
			this.buttonOperatorsQualityPartsRemove.Location = new System.Drawing.Point(428, 56);
			this.buttonOperatorsQualityPartsRemove.Name = "buttonOperatorsQualityPartsRemove";
			this.buttonOperatorsQualityPartsRemove.Size = new System.Drawing.Size(26, 23);
			this.buttonOperatorsQualityPartsRemove.TabIndex = 7;
			this.buttonOperatorsQualityPartsRemove.Text = "–";
			this.buttonOperatorsQualityPartsRemove.UseVisualStyleBackColor = true;
			// 
			// listViewOperatorsQualityParts
			// 
			this.listViewOperatorsQualityParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewOperatorsQualityParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
			this.listViewOperatorsQualityParts.FullRowSelect = true;
			this.listViewOperatorsQualityParts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewOperatorsQualityParts.Location = new System.Drawing.Point(6, 19);
			this.listViewOperatorsQualityParts.Name = "listViewOperatorsQualityParts";
			this.listViewOperatorsQualityParts.ShowItemToolTips = true;
			this.listViewOperatorsQualityParts.Size = new System.Drawing.Size(416, 60);
			this.listViewOperatorsQualityParts.TabIndex = 6;
			this.listViewOperatorsQualityParts.UseCompatibleStateImageBehavior = false;
			this.listViewOperatorsQualityParts.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Имя файла";
			this.columnHeader2.Width = 365;
			// 
			// buttonOperatorsQualityPartsAdd
			// 
			this.buttonOperatorsQualityPartsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOperatorsQualityPartsAdd.AutoSize = true;
			this.buttonOperatorsQualityPartsAdd.Location = new System.Drawing.Point(428, 19);
			this.buttonOperatorsQualityPartsAdd.Name = "buttonOperatorsQualityPartsAdd";
			this.buttonOperatorsQualityPartsAdd.Size = new System.Drawing.Size(26, 23);
			this.buttonOperatorsQualityPartsAdd.TabIndex = 5;
			this.buttonOperatorsQualityPartsAdd.Text = "+";
			this.buttonOperatorsQualityPartsAdd.UseVisualStyleBackColor = true;
			// 
			// groupBoxOperatorsWorktime
			// 
			this.groupBoxOperatorsWorktime.Controls.Add(this.buttonOperatorsWorktime);
			this.groupBoxOperatorsWorktime.Controls.Add(this.textBoxOperatorsWorktime);
			this.groupBoxOperatorsWorktime.Location = new System.Drawing.Point(12, 316);
			this.groupBoxOperatorsWorktime.Name = "groupBoxOperatorsWorktime";
			this.groupBoxOperatorsWorktime.Size = new System.Drawing.Size(460, 45);
			this.groupBoxOperatorsWorktime.TabIndex = 13;
			this.groupBoxOperatorsWorktime.TabStop = false;
			this.groupBoxOperatorsWorktime.Text = "Время работы операторов (дневная смена)";
			// 
			// buttonOperatorsWorktime
			// 
			this.buttonOperatorsWorktime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOperatorsWorktime.AutoSize = true;
			this.buttonOperatorsWorktime.Location = new System.Drawing.Point(428, 15);
			this.buttonOperatorsWorktime.Name = "buttonOperatorsWorktime";
			this.buttonOperatorsWorktime.Size = new System.Drawing.Size(26, 23);
			this.buttonOperatorsWorktime.TabIndex = 6;
			this.buttonOperatorsWorktime.Text = "...";
			this.buttonOperatorsWorktime.UseVisualStyleBackColor = true;
			// 
			// textBoxOperatorsWorktime
			// 
			this.textBoxOperatorsWorktime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOperatorsWorktime.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxOperatorsWorktime.Location = new System.Drawing.Point(6, 17);
			this.textBoxOperatorsWorktime.Name = "textBoxOperatorsWorktime";
			this.textBoxOperatorsWorktime.ReadOnly = true;
			this.textBoxOperatorsWorktime.Size = new System.Drawing.Size(416, 20);
			this.textBoxOperatorsWorktime.TabIndex = 0;
			// 
			// groupBoxAcceptedAndMissedCalls
			// 
			this.groupBoxAcceptedAndMissedCalls.Controls.Add(this.buttonAcceptedAndMissedCalls);
			this.groupBoxAcceptedAndMissedCalls.Controls.Add(this.textBoxAcceptedAndMissedCalls);
			this.groupBoxAcceptedAndMissedCalls.Location = new System.Drawing.Point(12, 367);
			this.groupBoxAcceptedAndMissedCalls.Name = "groupBoxAcceptedAndMissedCalls";
			this.groupBoxAcceptedAndMissedCalls.Size = new System.Drawing.Size(460, 45);
			this.groupBoxAcceptedAndMissedCalls.TabIndex = 14;
			this.groupBoxAcceptedAndMissedCalls.TabStop = false;
			this.groupBoxAcceptedAndMissedCalls.Text = "Отвеченные и неотвеченные звонки (ночная смена)";
			// 
			// buttonAcceptedAndMissedCalls
			// 
			this.buttonAcceptedAndMissedCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAcceptedAndMissedCalls.AutoSize = true;
			this.buttonAcceptedAndMissedCalls.Location = new System.Drawing.Point(428, 15);
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
			this.textBoxAcceptedAndMissedCalls.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxAcceptedAndMissedCalls.Location = new System.Drawing.Point(6, 17);
			this.textBoxAcceptedAndMissedCalls.Name = "textBoxAcceptedAndMissedCalls";
			this.textBoxAcceptedAndMissedCalls.ReadOnly = true;
			this.textBoxAcceptedAndMissedCalls.Size = new System.Drawing.Size(416, 20);
			this.textBoxAcceptedAndMissedCalls.TabIndex = 0;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "MMMM yyyy";
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(239, 425);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(116, 20);
			this.dateTimePicker.TabIndex = 15;
			// 
			// buttonSettings
			// 
			this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSettings.Location = new System.Drawing.Point(12, 458);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(125, 23);
			this.buttonSettings.TabIndex = 17;
			this.buttonSettings.Text = "Настройки";
			this.buttonSettings.UseVisualStyleBackColor = true;
			this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
			// 
			// buttonAbout
			// 
			this.buttonAbout.Location = new System.Drawing.Point(452, 9);
			this.buttonAbout.Margin = new System.Windows.Forms.Padding(0);
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.Size = new System.Drawing.Size(23, 23);
			this.buttonAbout.TabIndex = 18;
			this.buttonAbout.Text = "?";
			this.buttonAbout.UseVisualStyleBackColor = true;
			this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 493);
			this.Controls.Add(this.buttonAbout);
			this.Controls.Add(this.buttonSettings);
			this.Controls.Add(label1);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.groupBoxAcceptedAndMissedCalls);
			this.Controls.Add(this.groupBoxOperatorsWorktime);
			this.Controls.Add(this.groupBoxOperatorsQualityParts);
			this.Controls.Add(this.groupBoxTimetableFactParts);
			this.Controls.Add(this.groupBoxTimetablePlan);
			this.Controls.Add(this.groupBoxEmployeesList);
			this.Controls.Add(this.buttonCalc);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Расчет мотивации для сотрудников колл-центра";
			this.groupBoxEmployeesList.ResumeLayout(false);
			this.groupBoxEmployeesList.PerformLayout();
			this.groupBoxTimetablePlan.ResumeLayout(false);
			this.groupBoxTimetablePlan.PerformLayout();
			this.groupBoxTimetableFactParts.ResumeLayout(false);
			this.groupBoxTimetableFactParts.PerformLayout();
			this.groupBoxOperatorsQualityParts.ResumeLayout(false);
			this.groupBoxOperatorsQualityParts.PerformLayout();
			this.groupBoxOperatorsWorktime.ResumeLayout(false);
			this.groupBoxOperatorsWorktime.PerformLayout();
			this.groupBoxAcceptedAndMissedCalls.ResumeLayout(false);
			this.groupBoxAcceptedAndMissedCalls.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonCalc;
		private System.Windows.Forms.TextBox textBoxEmployeesList;
		private System.Windows.Forms.GroupBox groupBoxEmployeesList;
		private System.Windows.Forms.Button buttonEmployeesList;
		private System.Windows.Forms.GroupBox groupBoxTimetablePlan;
		private System.Windows.Forms.Button buttonTimetablePlan;
		private System.Windows.Forms.TextBox textBoxTimetablePlan;
		private System.Windows.Forms.GroupBox groupBoxTimetableFactParts;
		private System.Windows.Forms.Button buttonTimetableFactPartsAdd;
		private System.Windows.Forms.GroupBox groupBoxOperatorsQualityParts;
		private System.Windows.Forms.Button buttonOperatorsQualityPartsAdd;
		private System.Windows.Forms.GroupBox groupBoxOperatorsWorktime;
		private System.Windows.Forms.Button buttonOperatorsWorktime;
		private System.Windows.Forms.TextBox textBoxOperatorsWorktime;
		private System.Windows.Forms.GroupBox groupBoxAcceptedAndMissedCalls;
		private System.Windows.Forms.Button buttonAcceptedAndMissedCalls;
		private System.Windows.Forms.TextBox textBoxAcceptedAndMissedCalls;
		private System.Windows.Forms.Button buttonTimetableFactPartsRemove;
		private System.Windows.Forms.ListView listViewTimetableFactParts;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button buttonOperatorsQualityPartsRemove;
		private System.Windows.Forms.ListView listViewOperatorsQualityParts;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Button buttonSettings;
		private System.Windows.Forms.Button buttonAbout;
	}
}

