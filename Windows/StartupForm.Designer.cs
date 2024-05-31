namespace Star_Wars_Card_Game.Windows
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.ConnectionPage = new System.Windows.Forms.TabPage();
            this.HostGame = new System.Windows.Forms.Button();
            this.preferences = new System.Windows.Forms.TabPage();
            this.defaultPort = new System.Windows.Forms.MaskedTextBox();
            this.DefaultIPInput = new System.Windows.Forms.MaskedTextBox();
            this.defaultPortLbl = new System.Windows.Forms.Label();
            this.DefaultIPLbl = new System.Windows.Forms.Label();
            this.DefaultUNLbl = new System.Windows.Forms.Label();
            this.defaultUsername = new System.Windows.Forms.TextBox();
            this.defaultPage = new System.Windows.Forms.ComboBox();
            this.SaveDefaults = new System.Windows.Forms.Button();
            this.ColorMode = new System.Windows.Forms.ComboBox();
            this.devButton = new System.Windows.Forms.Button();
            this.tabContainer.SuspendLayout();
            this.ConnectionPage.SuspendLayout();
            this.preferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.ConnectionPage);
            this.tabContainer.Controls.Add(this.preferences);
            this.tabContainer.Location = new System.Drawing.Point(12, 12);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(776, 426);
            this.tabContainer.TabIndex = 0;
            // 
            // ConnectionPage
            // 
            this.ConnectionPage.BackColor = System.Drawing.Color.Black;
            this.ConnectionPage.Controls.Add(this.HostGame);
            this.ConnectionPage.Location = new System.Drawing.Point(4, 22);
            this.ConnectionPage.Name = "ConnectionPage";
            this.ConnectionPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionPage.Size = new System.Drawing.Size(768, 400);
            this.ConnectionPage.TabIndex = 0;
            this.ConnectionPage.Text = "Connection Setup";
            // 
            // HostGame
            // 
            this.HostGame.ForeColor = System.Drawing.Color.Black;
            this.HostGame.Location = new System.Drawing.Point(667, 6);
            this.HostGame.Name = "HostGame";
            this.HostGame.Size = new System.Drawing.Size(95, 34);
            this.HostGame.TabIndex = 0;
            this.HostGame.Text = "Host Game";
            this.HostGame.UseVisualStyleBackColor = true;
            this.HostGame.Click += new System.EventHandler(this.HostGame_Click);
            // 
            // preferences
            // 
            this.preferences.BackColor = System.Drawing.Color.Black;
            this.preferences.Controls.Add(this.devButton);
            this.preferences.Controls.Add(this.defaultPort);
            this.preferences.Controls.Add(this.DefaultIPInput);
            this.preferences.Controls.Add(this.defaultPortLbl);
            this.preferences.Controls.Add(this.DefaultIPLbl);
            this.preferences.Controls.Add(this.DefaultUNLbl);
            this.preferences.Controls.Add(this.defaultUsername);
            this.preferences.Controls.Add(this.defaultPage);
            this.preferences.Controls.Add(this.SaveDefaults);
            this.preferences.Controls.Add(this.ColorMode);
            this.preferences.Location = new System.Drawing.Point(4, 22);
            this.preferences.Name = "preferences";
            this.preferences.Padding = new System.Windows.Forms.Padding(3);
            this.preferences.Size = new System.Drawing.Size(768, 400);
            this.preferences.TabIndex = 1;
            this.preferences.Text = "Defaults";
            // 
            // defaultPort
            // 
            this.defaultPort.BackColor = System.Drawing.Color.Gainsboro;
            this.defaultPort.Location = new System.Drawing.Point(219, 282);
            this.defaultPort.Mask = "00000";
            this.defaultPort.Name = "defaultPort";
            this.defaultPort.Size = new System.Drawing.Size(303, 20);
            this.defaultPort.TabIndex = 10;
            this.defaultPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DefaultIPInput
            // 
            this.DefaultIPInput.BackColor = System.Drawing.Color.Gainsboro;
            this.DefaultIPInput.Location = new System.Drawing.Point(219, 238);
            this.DefaultIPInput.Name = "DefaultIPInput";
            this.DefaultIPInput.Size = new System.Drawing.Size(303, 20);
            this.DefaultIPInput.TabIndex = 9;
            // 
            // defaultPortLbl
            // 
            this.defaultPortLbl.AutoSize = true;
            this.defaultPortLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.defaultPortLbl.Location = new System.Drawing.Point(342, 266);
            this.defaultPortLbl.Name = "defaultPortLbl";
            this.defaultPortLbl.Size = new System.Drawing.Size(63, 13);
            this.defaultPortLbl.TabIndex = 8;
            this.defaultPortLbl.Text = "Default Port";
            // 
            // DefaultIPLbl
            // 
            this.DefaultIPLbl.AutoSize = true;
            this.DefaultIPLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.DefaultIPLbl.Location = new System.Drawing.Point(327, 222);
            this.DefaultIPLbl.Name = "DefaultIPLbl";
            this.DefaultIPLbl.Size = new System.Drawing.Size(95, 13);
            this.DefaultIPLbl.TabIndex = 7;
            this.DefaultIPLbl.Text = "Default IP Address";
            // 
            // DefaultUNLbl
            // 
            this.DefaultUNLbl.AutoSize = true;
            this.DefaultUNLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.DefaultUNLbl.Location = new System.Drawing.Point(330, 175);
            this.DefaultUNLbl.Name = "DefaultUNLbl";
            this.DefaultUNLbl.Size = new System.Drawing.Size(92, 13);
            this.DefaultUNLbl.TabIndex = 5;
            this.DefaultUNLbl.Text = "Default Username";
            // 
            // defaultUsername
            // 
            this.defaultUsername.BackColor = System.Drawing.Color.LightGray;
            this.defaultUsername.Location = new System.Drawing.Point(219, 191);
            this.defaultUsername.Name = "defaultUsername";
            this.defaultUsername.Size = new System.Drawing.Size(303, 20);
            this.defaultUsername.TabIndex = 3;
            // 
            // defaultPage
            // 
            this.defaultPage.BackColor = System.Drawing.Color.DimGray;
            this.defaultPage.FormattingEnabled = true;
            this.defaultPage.Location = new System.Drawing.Point(219, 143);
            this.defaultPage.Name = "defaultPage";
            this.defaultPage.Size = new System.Drawing.Size(303, 21);
            this.defaultPage.TabIndex = 2;
            // 
            // SaveDefaults
            // 
            this.SaveDefaults.ForeColor = System.Drawing.Color.Black;
            this.SaveDefaults.Location = new System.Drawing.Point(330, 308);
            this.SaveDefaults.Name = "SaveDefaults";
            this.SaveDefaults.Size = new System.Drawing.Size(93, 31);
            this.SaveDefaults.TabIndex = 1;
            this.SaveDefaults.Text = "Save";
            this.SaveDefaults.UseVisualStyleBackColor = true;
            this.SaveDefaults.Click += new System.EventHandler(this.SaveDefaults_Click);
            // 
            // ColorMode
            // 
            this.ColorMode.BackColor = System.Drawing.Color.DimGray;
            this.ColorMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColorMode.FormattingEnabled = true;
            this.ColorMode.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.ColorMode.Location = new System.Drawing.Point(219, 89);
            this.ColorMode.Name = "ColorMode";
            this.ColorMode.Size = new System.Drawing.Size(303, 21);
            this.ColorMode.TabIndex = 0;
            // 
            // devButton
            // 
            this.devButton.FlatAppearance.BorderSize = 0;
            this.devButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devButton.ForeColor = System.Drawing.Color.Black;
            this.devButton.Location = new System.Drawing.Point(6, 6);
            this.devButton.Name = "devButton";
            this.devButton.Size = new System.Drawing.Size(87, 30);
            this.devButton.TabIndex = 11;
            this.devButton.UseVisualStyleBackColor = true;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartupForm";
            this.Text = "STAR WARS: Card Game";
            this.tabContainer.ResumeLayout(false);
            this.ConnectionPage.ResumeLayout(false);
            this.preferences.ResumeLayout(false);
            this.preferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage ConnectionPage;
        private System.Windows.Forms.TabPage preferences;
        private System.Windows.Forms.ComboBox ColorMode;
        private System.Windows.Forms.Button SaveDefaults;
        private System.Windows.Forms.ComboBox defaultPage;
        private System.Windows.Forms.Label DefaultUNLbl;
        private System.Windows.Forms.TextBox defaultUsername;
        private System.Windows.Forms.MaskedTextBox DefaultIPInput;
        private System.Windows.Forms.Label defaultPortLbl;
        private System.Windows.Forms.Label DefaultIPLbl;
        private System.Windows.Forms.MaskedTextBox defaultPort;
        private System.Windows.Forms.Button HostGame;
        private System.Windows.Forms.Button devButton;
    }
}