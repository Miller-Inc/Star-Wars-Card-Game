namespace Star_Wars_Card_Game.Windows
{
    partial class Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.textBoxBody = new System.Windows.Forms.RichTextBox();
            this.No = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBody
            // 
            this.textBoxBody.BackColor = System.Drawing.Color.Black;
            this.textBoxBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBody.ForeColor = System.Drawing.Color.White;
            this.textBoxBody.Location = new System.Drawing.Point(12, 12);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(371, 145);
            this.textBoxBody.TabIndex = 0;
            this.textBoxBody.Text = "Are you sure?";
            // 
            // No
            // 
            this.No.ForeColor = System.Drawing.Color.Black;
            this.No.Location = new System.Drawing.Point(12, 178);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 28);
            this.No.TabIndex = 1;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Yes
            // 
            this.Yes.ForeColor = System.Drawing.Color.Black;
            this.Yes.Location = new System.Drawing.Point(308, 178);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(75, 28);
            this.Yes.TabIndex = 2;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(395, 218);
            this.ControlBox = false;
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.No);
            this.Controls.Add(this.textBoxBody);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxBody;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button Yes;
    }
}