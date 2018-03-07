namespace Project_3
{
    partial class DunwoodyRH
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.selectionTab = new System.Windows.Forms.TabPage();
            this.newResidentTab = new System.Windows.Forms.TabPage();
            this.residentSearchTab = new System.Windows.Forms.TabPage();
            this.entryTab = new System.Windows.Forms.TabPage();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.introLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.entryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.entryTab);
            this.tabControl1.Controls.Add(this.selectionTab);
            this.tabControl1.Controls.Add(this.newResidentTab);
            this.tabControl1.Controls.Add(this.residentSearchTab);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 633);
            this.tabControl1.TabIndex = 0;
            // 
            // selectionTab
            // 
            this.selectionTab.Location = new System.Drawing.Point(4, 25);
            this.selectionTab.Name = "selectionTab";
            this.selectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.selectionTab.Size = new System.Drawing.Size(853, 558);
            this.selectionTab.TabIndex = 1;
            this.selectionTab.Text = "Selection";
            this.selectionTab.UseVisualStyleBackColor = true;
            // 
            // newResidentTab
            // 
            this.newResidentTab.Location = new System.Drawing.Point(4, 25);
            this.newResidentTab.Name = "newResidentTab";
            this.newResidentTab.Size = new System.Drawing.Size(853, 558);
            this.newResidentTab.TabIndex = 2;
            this.newResidentTab.Text = "New Resident";
            this.newResidentTab.UseVisualStyleBackColor = true;
            // 
            // residentSearchTab
            // 
            this.residentSearchTab.Location = new System.Drawing.Point(4, 25);
            this.residentSearchTab.Name = "residentSearchTab";
            this.residentSearchTab.Size = new System.Drawing.Size(538, 351);
            this.residentSearchTab.TabIndex = 3;
            this.residentSearchTab.Text = "Resident Search";
            this.residentSearchTab.UseVisualStyleBackColor = true;
            // 
            // entryTab
            // 
            this.entryTab.BackgroundImage = global::Project_3.Properties.Resources.Dunwoody_Campus_Minneapolis;
            this.entryTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.entryTab.Controls.Add(this.introLabel);
            this.entryTab.Controls.Add(this.passwordLabel);
            this.entryTab.Controls.Add(this.userNameLabel);
            this.entryTab.Controls.Add(this.passwordBox);
            this.entryTab.Controls.Add(this.userNameBox);
            this.entryTab.Location = new System.Drawing.Point(4, 25);
            this.entryTab.Name = "entryTab";
            this.entryTab.Padding = new System.Windows.Forms.Padding(3);
            this.entryTab.Size = new System.Drawing.Size(999, 604);
            this.entryTab.TabIndex = 0;
            this.entryTab.Text = "Entry";
            this.entryTab.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(448, 219);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(444, 162);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(77, 17);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Username:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(527, 216);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 22);
            this.passwordBox.TabIndex = 1;
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(527, 162);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(100, 22);
            this.userNameBox.TabIndex = 0;
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Location = new System.Drawing.Point(375, 122);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(397, 17);
            this.introLabel.TabIndex = 4;
            this.introLabel.Text = "Please enter your Resident Director username and password.";
            // 
            // DunwoodyRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1003, 631);
            this.Controls.Add(this.tabControl1);
            this.Name = "DunwoodyRH";
            this.Text = "Dunwoody Residence Hall";
            this.tabControl1.ResumeLayout(false);
            this.entryTab.ResumeLayout(false);
            this.entryTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage entryTab;
        private System.Windows.Forms.TabPage selectionTab;
        private System.Windows.Forms.TabPage newResidentTab;
        private System.Windows.Forms.TabPage residentSearchTab;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label introLabel;
    }
}

