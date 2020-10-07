namespace StudentInformationSystem
{
    partial class frmView
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
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblDobDate = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstNam = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblSutdent = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.grpChartMark = new System.Windows.Forms.GroupBox();
            this.chartMarks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart = new System.Windows.Forms.Button();
            this.txtMarks = new System.Windows.Forms.RichTextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.grpAdminBase.SuspendLayout();
            this.grpChartMark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAdminBase
            // 
            this.grpAdminBase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpAdminBase.Controls.Add(this.txtLevel);
            this.grpAdminBase.Controls.Add(this.lblLevel);
            this.grpAdminBase.Controls.Add(this.txtAvg);
            this.grpAdminBase.Controls.Add(this.lblAvg);
            this.grpAdminBase.Controls.Add(this.lblDobDate);
            this.grpAdminBase.Controls.Add(this.txtDob);
            this.grpAdminBase.Controls.Add(this.txtLastName);
            this.grpAdminBase.Controls.Add(this.txtFirstName);
            this.grpAdminBase.Controls.Add(this.txtStuID);
            this.grpAdminBase.Controls.Add(this.lblDOB);
            this.grpAdminBase.Controls.Add(this.lblLastName);
            this.grpAdminBase.Controls.Add(this.lblFirstNam);
            this.grpAdminBase.Controls.Add(this.lblStudentID);
            this.grpAdminBase.Location = new System.Drawing.Point(12, 51);
            this.grpAdminBase.Name = "grpAdminBase";
            this.grpAdminBase.Size = new System.Drawing.Size(191, 244);
            this.grpAdminBase.TabIndex = 1;
            this.grpAdminBase.TabStop = false;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(73, 200);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 20;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(9, 203);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 19;
            this.lblLevel.Text = "Level:";
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(73, 161);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(100, 20);
            this.txtAvg.TabIndex = 18;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(8, 164);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(50, 13);
            this.lblAvg.TabIndex = 17;
            this.lblAvg.Text = "Average:";
            // 
            // lblDobDate
            // 
            this.lblDobDate.AutoSize = true;
            this.lblDobDate.Location = new System.Drawing.Point(77, 134);
            this.lblDobDate.Name = "lblDobDate";
            this.lblDobDate.Size = new System.Drawing.Size(80, 13);
            this.lblDobDate.TabIndex = 16;
            this.lblDobDate.Text = "(DD/MMM/YY)";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(73, 111);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(100, 20);
            this.txtDob.TabIndex = 15;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(73, 79);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(74, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(73, 11);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 20);
            this.txtStuID.TabIndex = 12;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(9, 114);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(39, 13);
            this.lblDOB.TabIndex = 11;
            this.lblDOB.Text = "D.O.B:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 82);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstNam
            // 
            this.lblFirstNam.AutoSize = true;
            this.lblFirstNam.Location = new System.Drawing.Point(7, 48);
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
            // lblSutdent
            // 
            this.lblSutdent.AutoSize = true;
            this.lblSutdent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSutdent.Location = new System.Drawing.Point(12, 26);
            this.lblSutdent.Name = "lblSutdent";
            this.lblSutdent.Size = new System.Drawing.Size(129, 22);
            this.lblSutdent.TabIndex = 24;
            this.lblSutdent.Text = "Student Info:";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(225, 26);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(75, 22);
            this.lblMarks.TabIndex = 28;
            this.lblMarks.Text = "Marks:";
            // 
            // grpChartMark
            // 
            this.grpChartMark.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpChartMark.Controls.Add(this.chartMarks);
            this.grpChartMark.Controls.Add(this.btnChart);
            this.grpChartMark.Controls.Add(this.txtMarks);
            this.grpChartMark.Location = new System.Drawing.Point(225, 51);
            this.grpChartMark.Name = "grpChartMark";
            this.grpChartMark.Size = new System.Drawing.Size(401, 244);
            this.grpChartMark.TabIndex = 27;
            this.grpChartMark.TabStop = false;
            // 
            // chartMarks
            // 
            chartArea1.Name = "chartMarks";
            this.chartMarks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMarks.Legends.Add(legend1);
            this.chartMarks.Location = new System.Drawing.Point(74, 18);
            this.chartMarks.Name = "chartMarks";
            series1.ChartArea = "chartMarks";
            series1.Legend = "Legend1";
            series1.Name = "Marks";
            this.chartMarks.Series.Add(series1);
            this.chartMarks.Size = new System.Drawing.Size(313, 202);
            this.chartMarks.TabIndex = 24;
            this.chartMarks.Text = "Marks";
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(12, 107);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(48, 23);
            this.btnChart.TabIndex = 26;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(11, 19);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtMarks.Size = new System.Drawing.Size(49, 70);
            this.txtMarks.TabIndex = 23;
            this.txtMarks.Text = "";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(584, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(50, 21);
            this.btnLogOut.TabIndex = 27;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(646, 319);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.grpChartMark);
            this.Controls.Add(this.lblSutdent);
            this.Controls.Add(this.grpAdminBase);
            this.Name = "frmView";
            this.Text = "frmView";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.grpAdminBase.ResumeLayout(false);
            this.grpAdminBase.PerformLayout();
            this.grpChartMark.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdminBase;
        private System.Windows.Forms.Label lblDobDate;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstNam;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblSutdent;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.GroupBox grpChartMark;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarks;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.RichTextBox txtMarks;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Button btnLogOut;
    }
}