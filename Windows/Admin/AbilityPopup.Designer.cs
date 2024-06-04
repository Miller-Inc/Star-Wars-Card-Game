namespace Star_Wars_Card_Game.Windows.Admin
{
    partial class AbilityPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbilityPopup));
            this.CancelBttn = new System.Windows.Forms.Button();
            this.AddAbility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelBttn
            // 
            this.CancelBttn.BackColor = System.Drawing.Color.Black;
            this.CancelBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBttn.FlatAppearance.BorderSize = 0;
            this.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBttn.ForeColor = System.Drawing.Color.White;
            this.CancelBttn.Location = new System.Drawing.Point(12, 404);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(87, 34);
            this.CancelBttn.TabIndex = 0;
            this.CancelBttn.Text = "Cancel";
            this.CancelBttn.UseVisualStyleBackColor = false;
            // 
            // AddAbility
            // 
            this.AddAbility.BackColor = System.Drawing.Color.Black;
            this.AddAbility.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddAbility.FlatAppearance.BorderSize = 0;
            this.AddAbility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAbility.ForeColor = System.Drawing.Color.White;
            this.AddAbility.Location = new System.Drawing.Point(701, 404);
            this.AddAbility.Name = "AddAbility";
            this.AddAbility.Size = new System.Drawing.Size(87, 34);
            this.AddAbility.TabIndex = 1;
            this.AddAbility.Text = "Add";
            this.AddAbility.UseVisualStyleBackColor = false;
            this.AddAbility.Click += new System.EventHandler(this.AddAbility_Click);
            // 
            // AbilityPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.CancelBttn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAbility);
            this.Controls.Add(this.CancelBttn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbilityPopup";
            this.Text = "AbilityPopup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBttn;
        private System.Windows.Forms.Button AddAbility;
    }
}