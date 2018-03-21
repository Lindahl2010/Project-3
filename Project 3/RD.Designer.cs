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
            this.label1 = new System.Windows.Forms.Label();
            this.stdntCheckBox = new System.Windows.Forms.CheckBox();
            this.athleteCheckBox = new System.Windows.Forms.CheckBox();
            this.scholarCheckBox = new System.Windows.Forms.CheckBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.residentSearchTab = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.selectionTab.SuspendLayout();
            this.newResidentTab.SuspendLayout();
            this.residentSearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.selectionTab);
            this.tabControl.Controls.Add(this.newResidentTab);
            this.tabControl.Controls.Add(this.residentSearchTab);
            this.tabControl.Location = new System.Drawing.Point(0, 22);
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
            this.selectionTab.Name = "selectionTab";
            this.selectionTab.Padding = new System.Windows.Forms.Padding(3);
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
            this.rdntSearchBtn.Name = "rdntSearchBtn";
            this.rdntSearchBtn.Size = new System.Drawing.Size(77, 31);
            this.rdntSearchBtn.TabIndex = 1;
            this.rdntSearchBtn.Text = "Search";
            this.rdntSearchBtn.UseVisualStyleBackColor = true;
            this.rdntSearchBtn.Click += new System.EventHandler(this.rdntSearchBtn_Click);
            // 
            // newRdntBtn
            // 
            this.newRdntBtn.Location = new System.Drawing.Point(190, 97);
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
            this.newResidentTab.Name = "newResidentTab";
            this.newResidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.newResidentTab.Size = new System.Drawing.Size(580, 369);
            this.newResidentTab.TabIndex = 1;
            this.newResidentTab.Text = "New Resident";
            this.newResidentTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please select which type of \r\nnew resident to be entered.";
            // 
            // stdntCheckBox
            // 
            this.stdntCheckBox.AutoSize = true;
            this.stdntCheckBox.Location = new System.Drawing.Point(115, 216);
            this.stdntCheckBox.Name = "stdntCheckBox";
            this.stdntCheckBox.Size = new System.Drawing.Size(129, 21);
            this.stdntCheckBox.TabIndex = 3;
            this.stdntCheckBox.Text = "Student Worker";
            this.stdntCheckBox.UseVisualStyleBackColor = true;
            // 
            // athleteCheckBox
            // 
            this.athleteCheckBox.AutoSize = true;
            this.athleteCheckBox.Location = new System.Drawing.Point(115, 188);
            this.athleteCheckBox.Name = "athleteCheckBox";
            this.athleteCheckBox.Size = new System.Drawing.Size(74, 21);
            this.athleteCheckBox.TabIndex = 2;
            this.athleteCheckBox.Text = "Athlete";
            this.athleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // scholarCheckBox
            // 
            this.scholarCheckBox.AutoSize = true;
            this.scholarCheckBox.Location = new System.Drawing.Point(115, 160);
            this.scholarCheckBox.Name = "scholarCheckBox";
            this.scholarCheckBox.Size = new System.Drawing.Size(167, 21);
            this.scholarCheckBox.TabIndex = 1;
            this.scholarCheckBox.Text = "Scholarship Recipient";
            this.scholarCheckBox.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(474, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 29);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // residentSearchTab
            // 
            this.residentSearchTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("residentSearchTab.BackgroundImage")));
            this.residentSearchTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.residentSearchTab.Controls.Add(this.searchBtn);
            this.residentSearchTab.Controls.Add(this.label4);
            this.residentSearchTab.Controls.Add(this.textBox1);
            this.residentSearchTab.Controls.Add(this.label2);
            this.residentSearchTab.Controls.Add(this.backBtn2);
            this.residentSearchTab.Location = new System.Drawing.Point(4, 25);
            this.residentSearchTab.Name = "residentSearchTab";
            this.residentSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.residentSearchTab.Size = new System.Drawing.Size(580, 369);
            this.residentSearchTab.TabIndex = 2;
            this.residentSearchTab.Text = "Resident Search";
            this.residentSearchTab.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(174, 194);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 28);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Number: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter the ID Number\r\nof the student to be searched.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn2
            // 
            this.backBtn2.Location = new System.Drawing.Point(474, 6);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(80, 29);
            this.backBtn2.TabIndex = 1;
            this.backBtn2.Text = "Back";
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backBtn2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(478, 426);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(93, 46);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(311, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 127);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // RD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 515);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RD";
            this.Text = "Resident Management";
            this.tabControl.ResumeLayout(false);
            this.selectionTab.ResumeLayout(false);
            this.selectionTab.PerformLayout();
            this.newResidentTab.ResumeLayout(false);
            this.newResidentTab.PerformLayout();
            this.residentSearchTab.ResumeLayout(false);
            this.residentSearchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}