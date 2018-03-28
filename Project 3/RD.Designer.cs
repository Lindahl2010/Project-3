namespace Project_3
{
    partial class RD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RD));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.selectionTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.rdntSearchBtn = new System.Windows.Forms.Button();
            this.newRdntBtn = new System.Windows.Forms.Button();
            this.newResidentTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stdntCheckBox = new System.Windows.Forms.CheckBox();
            this.athleteCheckBox = new System.Windows.Forms.CheckBox();
            this.scholarCheckBox = new System.Windows.Forms.CheckBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.residentSearchTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rentLabel = new System.Windows.Forms.Label();
            this.floorLabel = new System.Windows.Forms.Label();
            this.dormNumLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.idSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.selectionTab.SuspendLayout();
            this.newResidentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.residentSearchTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.selectionTab);
            this.tabControl.Controls.Add(this.newResidentTab);
            this.tabControl.Controls.Add(this.residentSearchTab);
            this.tabControl.Location = new System.Drawing.Point(0, 22);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(588, 398);
            this.tabControl.TabIndex = 0;
            // 
            // selectionTab
            // 
            this.selectionTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectionTab.BackgroundImage")));
            this.selectionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectionTab.Controls.Add(this.label3);
            this.selectionTab.Controls.Add(this.rdntSearchBtn);
            this.selectionTab.Controls.Add(this.newRdntBtn);
            this.selectionTab.Location = new System.Drawing.Point(4, 25);
            this.selectionTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionTab.Name = "selectionTab";
            this.selectionTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionTab.Size = new System.Drawing.Size(580, 369);
            this.selectionTab.TabIndex = 0;
            this.selectionTab.Text = "Selection";
            this.selectionTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(128, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "To search for a Resident, simply press \"Search\" \r\nor press \"Create\" to enter a ne" +
    "w Resident.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdntSearchBtn
            // 
            this.rdntSearchBtn.Location = new System.Drawing.Point(297, 97);
            this.rdntSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdntSearchBtn.Name = "rdntSearchBtn";
            this.rdntSearchBtn.Size = new System.Drawing.Size(77, 31);
            this.rdntSearchBtn.TabIndex = 1;
            this.rdntSearchBtn.Text = "Search";
            this.rdntSearchBtn.UseVisualStyleBackColor = true;
            this.rdntSearchBtn.Click += new System.EventHandler(this.rdntSearchBtn_Click);
            // 
            // newRdntBtn
            // 
            this.newRdntBtn.Location = new System.Drawing.Point(189, 97);
            this.newRdntBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newRdntBtn.Name = "newRdntBtn";
            this.newRdntBtn.Size = new System.Drawing.Size(77, 31);
            this.newRdntBtn.TabIndex = 0;
            this.newRdntBtn.Text = "Create";
            this.newRdntBtn.UseVisualStyleBackColor = true;
            this.newRdntBtn.Click += new System.EventHandler(this.newRdntBtn_Click);
            // 
            // newResidentTab
            // 
            this.newResidentTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newResidentTab.Controls.Add(this.pictureBox1);
            this.newResidentTab.Controls.Add(this.label1);
            this.newResidentTab.Controls.Add(this.stdntCheckBox);
            this.newResidentTab.Controls.Add(this.athleteCheckBox);
            this.newResidentTab.Controls.Add(this.scholarCheckBox);
            this.newResidentTab.Controls.Add(this.backBtn);
            this.newResidentTab.Location = new System.Drawing.Point(4, 25);
            this.newResidentTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newResidentTab.Name = "newResidentTab";
            this.newResidentTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newResidentTab.Size = new System.Drawing.Size(580, 369);
            this.newResidentTab.TabIndex = 1;
            this.newResidentTab.Text = "New Resident";
            this.newResidentTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(220, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 127);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please select which type of \r\nnew resident to be entered.";
            // 
            // stdntCheckBox
            // 
            this.stdntCheckBox.AutoSize = true;
            this.stdntCheckBox.Location = new System.Drawing.Point(24, 225);
            this.stdntCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stdntCheckBox.Name = "stdntCheckBox";
            this.stdntCheckBox.Size = new System.Drawing.Size(129, 21);
            this.stdntCheckBox.TabIndex = 3;
            this.stdntCheckBox.Text = "Student Worker";
            this.stdntCheckBox.UseVisualStyleBackColor = true;
            this.stdntCheckBox.CheckedChanged += new System.EventHandler(this.stdntCheckBox_CheckedChanged);
            // 
            // athleteCheckBox
            // 
            this.athleteCheckBox.AutoSize = true;
            this.athleteCheckBox.Location = new System.Drawing.Point(24, 197);
            this.athleteCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.athleteCheckBox.Name = "athleteCheckBox";
            this.athleteCheckBox.Size = new System.Drawing.Size(74, 21);
            this.athleteCheckBox.TabIndex = 2;
            this.athleteCheckBox.Text = "Athlete";
            this.athleteCheckBox.UseVisualStyleBackColor = true;
            this.athleteCheckBox.CheckedChanged += new System.EventHandler(this.athleteCheckBox_CheckedChanged);
            // 
            // scholarCheckBox
            // 
            this.scholarCheckBox.AutoSize = true;
            this.scholarCheckBox.Location = new System.Drawing.Point(24, 169);
            this.scholarCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scholarCheckBox.Name = "scholarCheckBox";
            this.scholarCheckBox.Size = new System.Drawing.Size(167, 21);
            this.scholarCheckBox.TabIndex = 1;
            this.scholarCheckBox.Text = "Scholarship Recipient";
            this.scholarCheckBox.UseVisualStyleBackColor = true;
            this.scholarCheckBox.CheckedChanged += new System.EventHandler(this.scholarCheckBox_CheckedChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(475, 6);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 30);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // residentSearchTab
            // 
            this.residentSearchTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("residentSearchTab.BackgroundImage")));
            this.residentSearchTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.residentSearchTab.Controls.Add(this.label12);
            this.residentSearchTab.Controls.Add(this.label11);
            this.residentSearchTab.Controls.Add(this.label10);
            this.residentSearchTab.Controls.Add(this.label9);
            this.residentSearchTab.Controls.Add(this.label8);
            this.residentSearchTab.Controls.Add(this.label7);
            this.residentSearchTab.Controls.Add(this.label6);
            this.residentSearchTab.Controls.Add(this.label5);
            this.residentSearchTab.Controls.Add(this.rentLabel);
            this.residentSearchTab.Controls.Add(this.floorLabel);
            this.residentSearchTab.Controls.Add(this.dormNumLabel);
            this.residentSearchTab.Controls.Add(this.lnameLabel);
            this.residentSearchTab.Controls.Add(this.fnameLabel);
            this.residentSearchTab.Controls.Add(this.idLabel);
            this.residentSearchTab.Controls.Add(this.searchBtn);
            this.residentSearchTab.Controls.Add(this.label4);
            this.residentSearchTab.Controls.Add(this.idSearchBox);
            this.residentSearchTab.Controls.Add(this.label2);
            this.residentSearchTab.Controls.Add(this.backBtn2);
            this.residentSearchTab.Location = new System.Drawing.Point(4, 25);
            this.residentSearchTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.residentSearchTab.Name = "residentSearchTab";
            this.residentSearchTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.residentSearchTab.Size = new System.Drawing.Size(580, 369);
            this.residentSearchTab.TabIndex = 2;
            this.residentSearchTab.Text = "Resident Search";
            this.residentSearchTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Rent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Floor Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dorm Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID Number";
            // 
            // rentLabel
            // 
            this.rentLabel.AutoSize = true;
            this.rentLabel.Location = new System.Drawing.Point(351, 187);
            this.rentLabel.Name = "rentLabel";
            this.rentLabel.Size = new System.Drawing.Size(46, 17);
            this.rentLabel.TabIndex = 11;
            this.rentLabel.Text = "Rent: ";
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Location = new System.Drawing.Point(351, 158);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(102, 17);
            this.floorLabel.TabIndex = 10;
            this.floorLabel.Text = "Floor Number: ";
            // 
            // dormNumLabel
            // 
            this.dormNumLabel.AutoSize = true;
            this.dormNumLabel.Location = new System.Drawing.Point(351, 132);
            this.dormNumLabel.Name = "dormNumLabel";
            this.dormNumLabel.Size = new System.Drawing.Size(104, 17);
            this.dormNumLabel.TabIndex = 9;
            this.dormNumLabel.Text = "Dorm Number: ";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(351, 103);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(80, 17);
            this.lnameLabel.TabIndex = 8;
            this.lnameLabel.Text = "Last Name:";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(351, 75);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(84, 17);
            this.fnameLabel.TabIndex = 7;
            this.fnameLabel.Text = "First Name: ";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(351, 48);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(83, 17);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID Number: ";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(173, 194);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 28);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Number: ";
            // 
            // idSearchBox
            // 
            this.idSearchBox.Location = new System.Drawing.Point(159, 158);
            this.idSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idSearchBox.Name = "idSearchBox";
            this.idSearchBox.Size = new System.Drawing.Size(100, 22);
            this.idSearchBox.TabIndex = 3;
            this.idSearchBox.TextChanged += new System.EventHandler(this.idSearchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter the ID Number\r\nof the student to be searched.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn2
            // 
            this.backBtn2.Location = new System.Drawing.Point(475, 6);
            this.backBtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(80, 30);
            this.backBtn2.TabIndex = 1;
            this.backBtn2.Text = "Back";
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backBtn2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(477, 426);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(93, 46);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total # of Students: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "#";
            // 
            // RD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 514);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RD";
            this.Text = "Resident Management";
            this.tabControl.ResumeLayout(false);
            this.selectionTab.ResumeLayout(false);
            this.selectionTab.PerformLayout();
            this.newResidentTab.ResumeLayout(false);
            this.newResidentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.residentSearchTab.ResumeLayout(false);
            this.residentSearchTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage selectionTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rdntSearchBtn;
        private System.Windows.Forms.Button newRdntBtn;
        private System.Windows.Forms.TabPage newResidentTab;
        private System.Windows.Forms.TabPage residentSearchTab;
        private System.Windows.Forms.CheckBox stdntCheckBox;
        private System.Windows.Forms.CheckBox athleteCheckBox;
        private System.Windows.Forms.CheckBox scholarCheckBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.Label dormNumLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label rentLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}