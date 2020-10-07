namespace StudentInformationSystem
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpAdminBase = new System.Windows.Forms.GroupBox();
            this.dtpPickDate = new System.Windows.Forms.DateTimePicker();
            this.lblDobDate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstNam = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chartMarks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.grpChartMark = new System.Windows.Forms.GroupBox();
            this.lblFive = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.txtMark5 = new System.Windows.Forms.TextBox();
            this.txtMark4 = new System.Windows.Forms.TextBox();
            this.txtMark3 = new System.Windows.Forms.TextBox();
            this.txtMark2 = new System.Windows.Forms.TextBox();
            this.txtMark1 = new System.Windows.Forms.TextBox();
            this.lblSutdent = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAdminBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).BeginInit();
            this.grpChartMark.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdminBase
            // 
            this.grpAdminBase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpAdminBase.Controls.Add(this.label1);
            this.grpAdminBase.Controls.Add(this.lblUserName);
            this.grpAdminBase.Controls.Add(this.txtPassword);
            this.grpAdminBase.Controls.Add(this.txtUserName);
            this.grpAdminBase.Controls.Add(this.dtpPickDate);
            this.grpAdminBase.Controls.Add(this.lblDobDate);
            this.grpAdminBase.Controls.Add(this.txtLastName);
            this.grpAdminBase.Controls.Add(this.txtFirstName);
            this.grpAdminBase.Controls.Add(this.txtStuID);
            this.grpAdminBase.Controls.Add(this.lblDOB);
            this.grpAdminBase.Controls.Add(this.lblLastName);
            this.grpAdminBase.Controls.Add(this.lblFirstNam);
            this.grpAdminBase.Controls.Add(this.lblStudentID);
            this.grpAdminBase.Location = new System.Drawing.Point(12, 47);
            this.grpAdminBase.Name = "grpAdminBase";
            this.grpAdminBase.Size = new System.Drawing.Size(191, 215);
            this.grpAdminBase.TabIndex = 0;
            this.grpAdminBase.TabStop = false;
            // 
            // dtpPickDate
            // 
            this.dtpPickDate.CustomFormat = "dd/MMM/yy";
            this.dtpPickDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPickDate.Location = new System.Drawing.Point(75, 176);
            this.dtpPickDate.Name = "dtpPickDate";
            this.dtpPickDate.Size = new System.Drawing.Size(100, 20);
            this.dtpPickDate.TabIndex = 29;
            // 
            // lblDobDate
            // 
            this.lblDobDate.AutoSize = true;
            this.lblDobDate.Location = new System.Drawing.Point(84, 199);
            this.lblDobDate.Name = "lblDobDate";
            this.lblDobDate.Size = new System.Drawing.Size(80, 13);
            this.lblDobDate.TabIndex = 16;
            this.lblDobDate.Text = "(DD/MMM/YY)";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(75, 144);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 106);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(75, 11);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 20);
            this.txtStuID.TabIndex = 12;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(10, 179);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(39, 13);
            this.lblDOB.TabIndex = 11;
            this.lblDOB.Text = "D.O.B:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 147);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstNam
            // 
            this.lblFirstNam.AutoSize = true;
            this.lblFirstNam.Location = new System.Drawing.Point(8, 113);
            this.lblFirstNam.Name = "lblFirstNam";
            this.lblFirstNam.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNam.TabIndex = 9;
            this.lblFirstNam.Text = "First Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(7, 14);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 8;
            this.lblStudentID.Text = "Student ID:";
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(222, 47);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(120, 21);
            this.cmbNames.TabIndex = 17;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(358, 103);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(53, 23);
            this.btnSaveNew.TabIndex = 22;
            this.btnSaveNew.Text = "Save";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(358, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(71, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(358, 74);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(53, 23);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chartMarks
            // 
            chartArea1.Name = "chartMarks";
            this.chartMarks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMarks.Legends.Add(legend1);
            this.chartMarks.Location = new System.Drawing.Point(74, 19);
            this.chartMarks.Name = "chartMarks";
            series1.ChartArea = "chartMarks";
            series1.Legend = "Legend1";
            series1.Name = "Marks";
            this.chartMarks.Series.Add(series1);
            this.chartMarks.Size = new System.Drawing.Size(313, 216);
            this.chartMarks.TabIndex = 24;
            this.chartMarks.Text = "Marks";
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(14, 179);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(48, 23);
            this.btnChart.TabIndex = 26;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(14, 212);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(48, 23);
            this.btnClearChart.TabIndex = 25;
            this.btnClearChart.Text = "Clear Chart";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // grpChartMark
            // 
            this.grpChartMark.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpChartMark.Controls.Add(this.lblFive);
            this.grpChartMark.Controls.Add(this.lblFour);
            this.grpChartMark.Controls.Add(this.lblThree);
            this.grpChartMark.Controls.Add(this.lblTwo);
            this.grpChartMark.Controls.Add(this.lblOne);
            this.grpChartMark.Controls.Add(this.txtMark5);
            this.grpChartMark.Controls.Add(this.txtMark4);
            this.grpChartMark.Controls.Add(this.txtMark3);
            this.grpChartMark.Controls.Add(this.txtMark2);
            this.grpChartMark.Controls.Add(this.txtMark1);
            this.grpChartMark.Controls.Add(this.chartMarks);
            this.grpChartMark.Controls.Add(this.btnClearChart);
            this.grpChartMark.Controls.Add(this.btnChart);
            this.grpChartMark.Location = new System.Drawing.Point(12, 339);
            this.grpChartMark.Name = "grpChartMark";
            this.grpChartMark.Size = new System.Drawing.Size(401, 244);
            this.grpChartMark.TabIndex = 16;
            this.grpChartMark.TabStop = false;
            // 
            // lblFive
            // 
            this.lblFive.AutoSize = true;
            this.lblFive.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFive.Location = new System.Drawing.Point(-1, 126);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(19, 14);
            this.lblFive.TabIndex = 34;
            this.lblFive.Text = "5: ";
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFour.Location = new System.Drawing.Point(-1, 100);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(19, 14);
            this.lblFour.TabIndex = 33;
            this.lblFour.Text = "4: ";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThree.Location = new System.Drawing.Point(-1, 74);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(16, 14);
            this.lblThree.TabIndex = 32;
            this.lblThree.Text = "3:";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwo.Location = new System.Drawing.Point(-1, 48);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(19, 14);
            this.lblTwo.TabIndex = 31;
            this.lblTwo.Text = "2: ";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(-1, 21);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(19, 14);
            this.lblOne.TabIndex = 29;
            this.lblOne.Text = "1: ";
            // 
            // txtMark5
            // 
            this.txtMark5.Location = new System.Drawing.Point(18, 123);
            this.txtMark5.Name = "txtMark5";
            this.txtMark5.Size = new System.Drawing.Size(50, 20);
            this.txtMark5.TabIndex = 30;
            // 
            // txtMark4
            // 
            this.txtMark4.Location = new System.Drawing.Point(18, 97);
            this.txtMark4.Name = "txtMark4";
            this.txtMark4.Size = new System.Drawing.Size(50, 20);
            this.txtMark4.TabIndex = 29;
            // 
            // txtMark3
            // 
            this.txtMark3.Location = new System.Drawing.Point(18, 71);
            this.txtMark3.Name = "txtMark3";
            this.txtMark3.Size = new System.Drawing.Size(50, 20);
            this.txtMark3.TabIndex = 28;
            // 
            // txtMark2
            // 
            this.txtMark2.Location = new System.Drawing.Point(18, 45);
            this.txtMark2.Name = "txtMark2";
            this.txtMark2.Size = new System.Drawing.Size(50, 20);
            this.txtMark2.TabIndex = 27;
            // 
            // txtMark1
            // 
            this.txtMark1.Location = new System.Drawing.Point(18, 19);
            this.txtMark1.Name = "txtMark1";
            this.txtMark1.Size = new System.Drawing.Size(50, 20);
            this.txtMark1.TabIndex = 17;
            // 
            // lblSutdent
            // 
            this.lblSutdent.AutoSize = true;
            this.lblSutdent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSutdent.Location = new System.Drawing.Point(8, 22);
            this.lblSutdent.Name = "lblSutdent";
            this.lblSutdent.Size = new System.Drawing.Size(129, 22);
            this.lblSutdent.TabIndex = 23;
            this.lblSutdent.Text = "Student Info:";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(10, 314);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(75, 22);
            this.lblMarks.TabIndex = 24;
            this.lblMarks.Text = "Marks:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(82, 316);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(79, 18);
            this.lblLevel.TabIndex = 26;
            this.lblLevel.Text = "Level: N/A";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(363, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(50, 21);
            this.btnLogOut.TabIndex = 28;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(75, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 30;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 31;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(7, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 32;
            this.lblUserName.Text = "UserName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Password:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(423, 595);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblSutdent);
            this.Controls.Add(this.grpChartMark);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.grpAdminBase);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.grpAdminBase.ResumeLayout(false);
            this.grpAdminBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).EndInit();
            this.grpChartMark.ResumeLayout(false);
            this.grpChartMark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdminBase;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstNam;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarks;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.GroupBox grpChartMark;
        private System.Windows.Forms.Label lblSutdent;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblDobDate;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtMark5;
        private System.Windows.Forms.TextBox txtMark4;
        private System.Windows.Forms.TextBox txtMark3;
        private System.Windows.Forms.TextBox txtMark2;
        private System.Windows.Forms.TextBox txtMark1;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.DateTimePicker dtpPickDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
    }
}