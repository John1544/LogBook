namespace LogBook.WinForms
{
    partial class MillerLogBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MillerLogBookForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageLogs = new System.Windows.Forms.TabPage();
            this.ListViewNewLogs = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasFever = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasCough = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasSoreThroat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasDiarrhea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasLossOfSmell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasLossOfTaste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecentTravels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactedCovidPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OtherSymptoms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControlSearchHistory = new System.Windows.Forms.TabPage();
            this.ListViewSearchHistory = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TabPageLogBook = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TabPageManageLog = new System.Windows.Forms.TabPage();
            this.DataGridViewManageLog = new System.Windows.Forms.DataGridView();
            this.TabControl.SuspendLayout();
            this.TabPageLogs.SuspendLayout();
            this.TabControlSearchHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.TabPageLogBook.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.TabPageManageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewManageLog)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageLogs);
            this.TabControl.Controls.Add(this.TabControlSearchHistory);
            this.TabControl.Controls.Add(this.TabPageLogBook);
            this.TabControl.Controls.Add(this.TabPageManageLog);
            this.TabControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(42, 157);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(923, 375);
            this.TabControl.TabIndex = 10;
            // 
            // TabPageLogs
            // 
            this.TabPageLogs.Controls.Add(this.ListViewNewLogs);
            this.TabPageLogs.Location = new System.Drawing.Point(4, 25);
            this.TabPageLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPageLogs.Name = "TabPageLogs";
            this.TabPageLogs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPageLogs.Size = new System.Drawing.Size(915, 346);
            this.TabPageLogs.TabIndex = 0;
            this.TabPageLogs.Text = "New Logs";
            this.TabPageLogs.UseVisualStyleBackColor = true;
            // 
            // ListViewNewLogs
            // 
            this.ListViewNewLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewNewLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.FirstName,
            this.LastName,
            this.TimeIn,
            this.Temperature,
            this.HasFever,
            this.HasCough,
            this.HasSoreThroat,
            this.HasDiarrhea,
            this.HasLossOfSmell,
            this.HasLossOfTaste,
            this.RecentTravels,
            this.ContactedCovidPatient,
            this.OtherSymptoms});
            this.ListViewNewLogs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewNewLogs.HideSelection = false;
            this.ListViewNewLogs.Location = new System.Drawing.Point(0, 0);
            this.ListViewNewLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListViewNewLogs.Name = "ListViewNewLogs";
            this.ListViewNewLogs.Size = new System.Drawing.Size(883, 312);
            this.ListViewNewLogs.TabIndex = 0;
            this.ListViewNewLogs.UseCompatibleStateImageBehavior = false;
            this.ListViewNewLogs.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            // 
            // TimeIn
            // 
            this.TimeIn.Text = "Time In";
            // 
            // Temperature
            // 
            this.Temperature.DisplayIndex = 13;
            this.Temperature.Text = "Temperature";
            // 
            // HasFever
            // 
            this.HasFever.DisplayIndex = 4;
            this.HasFever.Text = "Has Fever";
            // 
            // HasCough
            // 
            this.HasCough.DisplayIndex = 5;
            this.HasCough.Text = "Has Cough";
            // 
            // HasSoreThroat
            // 
            this.HasSoreThroat.DisplayIndex = 6;
            this.HasSoreThroat.Text = "Has Sore Throat";
            // 
            // HasDiarrhea
            // 
            this.HasDiarrhea.DisplayIndex = 7;
            this.HasDiarrhea.Text = "Has Diarrhea";
            // 
            // HasLossOfSmell
            // 
            this.HasLossOfSmell.DisplayIndex = 8;
            this.HasLossOfSmell.Text = "Has Loss Of Smell";
            // 
            // HasLossOfTaste
            // 
            this.HasLossOfTaste.DisplayIndex = 9;
            this.HasLossOfTaste.Text = "Has Loss Of Taste";
            // 
            // RecentTravels
            // 
            this.RecentTravels.DisplayIndex = 10;
            this.RecentTravels.Text = "Recent Travels";
            // 
            // ContactedCovidPatient
            // 
            this.ContactedCovidPatient.DisplayIndex = 11;
            this.ContactedCovidPatient.Text = "Contacted Covid Patient";
            // 
            // OtherSymptoms
            // 
            this.OtherSymptoms.DisplayIndex = 12;
            this.OtherSymptoms.Text = "Other Symptoms";
            // 
            // TabControlSearchHistory
            // 
            this.TabControlSearchHistory.Controls.Add(this.ListViewSearchHistory);
            this.TabControlSearchHistory.Controls.Add(this.textBox2);
            this.TabControlSearchHistory.Controls.Add(this.panel1);
            this.TabControlSearchHistory.Controls.Add(this.pictureBox3);
            this.TabControlSearchHistory.Location = new System.Drawing.Point(4, 25);
            this.TabControlSearchHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControlSearchHistory.Name = "TabControlSearchHistory";
            this.TabControlSearchHistory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControlSearchHistory.Size = new System.Drawing.Size(915, 346);
            this.TabControlSearchHistory.TabIndex = 1;
            this.TabControlSearchHistory.Text = "Search History";
            this.TabControlSearchHistory.UseVisualStyleBackColor = true;
            // 
            // ListViewSearchHistory
            // 
            this.ListViewSearchHistory.HideSelection = false;
            this.ListViewSearchHistory.Location = new System.Drawing.Point(24, 51);
            this.ListViewSearchHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListViewSearchHistory.Name = "ListViewSearchHistory";
            this.ListViewSearchHistory.Size = new System.Drawing.Size(865, 267);
            this.ListViewSearchHistory.TabIndex = 9;
            this.ListViewSearchHistory.UseCompatibleStateImageBehavior = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(63, 8);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 16);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Search for Person";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(63, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 4);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // TabPageLogBook
            // 
            this.TabPageLogBook.Controls.Add(this.textBox3);
            this.TabPageLogBook.Controls.Add(this.textBox1);
            this.TabPageLogBook.Controls.Add(this.dateTimePicker1);
            this.TabPageLogBook.Controls.Add(this.label8);
            this.TabPageLogBook.Controls.Add(this.label4);
            this.TabPageLogBook.Controls.Add(this.label7);
            this.TabPageLogBook.Controls.Add(this.label3);
            this.TabPageLogBook.Location = new System.Drawing.Point(4, 25);
            this.TabPageLogBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPageLogBook.Name = "TabPageLogBook";
            this.TabPageLogBook.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPageLogBook.Size = new System.Drawing.Size(915, 346);
            this.TabPageLogBook.TabIndex = 2;
            this.TabPageLogBook.Text = "Log Book";
            this.TabPageLogBook.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Time-In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 92);
            this.panel3.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(820, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Miller Log Book";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(94, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Development Inc.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(97, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Miller Sulotions";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 14);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            // 
            // TabPageManageLog
            // 
            this.TabPageManageLog.Controls.Add(this.DataGridViewManageLog);
            this.TabPageManageLog.Location = new System.Drawing.Point(4, 25);
            this.TabPageManageLog.Name = "TabPageManageLog";
            this.TabPageManageLog.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageManageLog.Size = new System.Drawing.Size(915, 346);
            this.TabPageManageLog.TabIndex = 3;
            this.TabPageManageLog.Text = "Manage Log";
            this.TabPageManageLog.UseVisualStyleBackColor = true;
            // 
            // DataGridViewManageLog
            // 
            this.DataGridViewManageLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewManageLog.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewManageLog.Name = "DataGridViewManageLog";
            this.DataGridViewManageLog.Size = new System.Drawing.Size(915, 274);
            this.DataGridViewManageLog.TabIndex = 0;
            // 
            // MillerLogBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 553);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MillerLogBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miller Log Book";
            this.Load += new System.EventHandler(this.MillerLogBookForm_Load);
            this.TabControl.ResumeLayout(false);
            this.TabPageLogs.ResumeLayout(false);
            this.TabControlSearchHistory.ResumeLayout(false);
            this.TabControlSearchHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.TabPageLogBook.ResumeLayout(false);
            this.TabPageLogBook.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.TabPageManageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewManageLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPageLogs;
        private System.Windows.Forms.ListView ListViewNewLogs;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader TimeIn;
        private System.Windows.Forms.ColumnHeader Temperature;
        private System.Windows.Forms.ColumnHeader HasFever;
        private System.Windows.Forms.ColumnHeader HasCough;
        private System.Windows.Forms.ColumnHeader HasSoreThroat;
        private System.Windows.Forms.ColumnHeader HasDiarrhea;
        private System.Windows.Forms.ColumnHeader HasLossOfSmell;
        private System.Windows.Forms.ColumnHeader HasLossOfTaste;
        private System.Windows.Forms.ColumnHeader RecentTravels;
        private System.Windows.Forms.ColumnHeader ContactedCovidPatient;
        private System.Windows.Forms.ColumnHeader OtherSymptoms;
        private System.Windows.Forms.TabPage TabControlSearchHistory;
        private System.Windows.Forms.ListView ListViewSearchHistory;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage TabPageLogBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage TabPageManageLog;
        private System.Windows.Forms.DataGridView DataGridViewManageLog;
    }
}

