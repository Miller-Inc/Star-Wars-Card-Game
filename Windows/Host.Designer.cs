namespace Star_Wars_Card_Game.Windows
{
    partial class Host
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Host));
            this.PlayerOutput = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ConnectionKeyLbl = new System.Windows.Forms.Label();
            this.joinGameLocally = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerOutput
            // 
            this.PlayerOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerOutput.BackColor = System.Drawing.Color.Black;
            this.PlayerOutput.ForeColor = System.Drawing.Color.Yellow;
            this.PlayerOutput.FormattingEnabled = true;
            this.PlayerOutput.Items.AddRange(new object[] {
            "When players join, they will be displayed here: "});
            this.PlayerOutput.Location = new System.Drawing.Point(377, -3);
            this.PlayerOutput.Name = "PlayerOutput";
            this.PlayerOutput.Size = new System.Drawing.Size(423, 459);
            this.PlayerOutput.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(378, 450);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // ConnectionKeyLbl
            // 
            this.ConnectionKeyLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectionKeyLbl.AutoSize = true;
            this.ConnectionKeyLbl.ForeColor = System.Drawing.Color.Yellow;
            this.ConnectionKeyLbl.Location = new System.Drawing.Point(111, 105);
            this.ConnectionKeyLbl.Name = "ConnectionKeyLbl";
            this.ConnectionKeyLbl.Size = new System.Drawing.Size(160, 13);
            this.ConnectionKeyLbl.TabIndex = 4;
            this.ConnectionKeyLbl.Text = "Connection Key: 127.0.0.1:6136";
            // 
            // joinGameLocally
            // 
            this.joinGameLocally.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.joinGameLocally.Location = new System.Drawing.Point(133, 199);
            this.joinGameLocally.Name = "joinGameLocally";
            this.joinGameLocally.Size = new System.Drawing.Size(109, 34);
            this.joinGameLocally.TabIndex = 5;
            this.joinGameLocally.Text = "Join Game";
            this.joinGameLocally.UseVisualStyleBackColor = true;
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.joinGameLocally);
            this.Controls.Add(this.ConnectionKeyLbl);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PlayerOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Host";
            this.Text = "Server Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox PlayerOutput;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label ConnectionKeyLbl;
        private System.Windows.Forms.Button joinGameLocally;
    }
}