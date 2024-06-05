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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Allied Leader");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ally 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ally 3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ally 4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Ally 5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Allied Summon");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Allies", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Enemy Leader");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Enemy 2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Enemy 3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Enemy 4");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Enemy 5");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Enemy Summon");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Enemies", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbilityPopup));
            this.CancelBttn = new System.Windows.Forms.Button();
            this.AddAbility = new System.Windows.Forms.Button();
            this.abilityName = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.Label();
            this.unitsChooser = new System.Windows.Forms.TreeView();
            this.effectCheckBox = new System.Windows.Forms.CheckedListBox();
            this.AffectedUnitsLbl = new System.Windows.Forms.Label();
            this.AffectOnUnitLbl = new System.Windows.Forms.Label();
            this.AbilityDescription = new System.Windows.Forms.RichTextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
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
            // abilityName
            // 
            this.abilityName.BackColor = System.Drawing.Color.DimGray;
            this.abilityName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.abilityName.CausesValidation = false;
            this.abilityName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.abilityName.Location = new System.Drawing.Point(12, 27);
            this.abilityName.Name = "abilityName";
            this.abilityName.Size = new System.Drawing.Size(212, 13);
            this.abilityName.TabIndex = 2;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.ForeColor = System.Drawing.Color.White;
            this.s.Location = new System.Drawing.Point(13, 8);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(65, 13);
            this.s.TabIndex = 3;
            this.s.Text = "Ability Name";
            // 
            // unitsChooser
            // 
            this.unitsChooser.BackColor = System.Drawing.Color.DimGray;
            this.unitsChooser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitsChooser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.unitsChooser.LineColor = System.Drawing.Color.WhiteSmoke;
            this.unitsChooser.Location = new System.Drawing.Point(12, 153);
            this.unitsChooser.Name = "unitsChooser";
            treeNode1.Name = "AlliedLeader";
            treeNode1.Text = "Allied Leader";
            treeNode2.Name = "Ally2";
            treeNode2.Text = "Ally 2";
            treeNode3.Name = "Ally3";
            treeNode3.Text = "Ally 3";
            treeNode4.Name = "Ally4";
            treeNode4.Text = "Ally 4";
            treeNode5.Name = "Ally5";
            treeNode5.Text = "Ally 5";
            treeNode6.Name = "AlliedSummon";
            treeNode6.Text = "Allied Summon";
            treeNode7.Name = "AlliedUnits";
            treeNode7.Text = "Allies";
            treeNode8.Name = "EnemyLeader";
            treeNode8.Text = "Enemy Leader";
            treeNode9.Name = "Enemy2";
            treeNode9.Text = "Enemy 2";
            treeNode10.Name = "Enemy3";
            treeNode10.Text = "Enemy 3";
            treeNode11.Name = "Enemy4";
            treeNode11.Text = "Enemy 4";
            treeNode12.Name = "Enemy5";
            treeNode12.Text = "Enemy 5";
            treeNode13.Name = "EnemySummon";
            treeNode13.Text = "Enemy Summon";
            treeNode14.Name = "EnemyUnits";
            treeNode14.Text = "Enemies";
            this.unitsChooser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode14});
            this.unitsChooser.Size = new System.Drawing.Size(336, 239);
            this.unitsChooser.TabIndex = 4;
            // 
            // effectCheckBox
            // 
            this.effectCheckBox.BackColor = System.Drawing.Color.DimGray;
            this.effectCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.effectCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.effectCheckBox.FormattingEnabled = true;
            this.effectCheckBox.Items.AddRange(new object[] {
            "Damage",
            "Heal",
            "Debuff",
            "Buff"});
            this.effectCheckBox.Location = new System.Drawing.Point(354, 153);
            this.effectCheckBox.Name = "effectCheckBox";
            this.effectCheckBox.Size = new System.Drawing.Size(98, 75);
            this.effectCheckBox.TabIndex = 5;
            // 
            // AffectedUnitsLbl
            // 
            this.AffectedUnitsLbl.AutoSize = true;
            this.AffectedUnitsLbl.BackColor = System.Drawing.Color.Black;
            this.AffectedUnitsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AffectedUnitsLbl.Location = new System.Drawing.Point(13, 137);
            this.AffectedUnitsLbl.Name = "AffectedUnitsLbl";
            this.AffectedUnitsLbl.Size = new System.Drawing.Size(74, 13);
            this.AffectedUnitsLbl.TabIndex = 6;
            this.AffectedUnitsLbl.Text = "Affected Units";
            // 
            // AffectOnUnitLbl
            // 
            this.AffectOnUnitLbl.AutoSize = true;
            this.AffectOnUnitLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AffectOnUnitLbl.Location = new System.Drawing.Point(355, 137);
            this.AffectOnUnitLbl.Name = "AffectOnUnitLbl";
            this.AffectOnUnitLbl.Size = new System.Drawing.Size(35, 13);
            this.AffectOnUnitLbl.TabIndex = 7;
            this.AffectOnUnitLbl.Text = "Affect";
            // 
            // AbilityDescription
            // 
            this.AbilityDescription.BackColor = System.Drawing.Color.DimGray;
            this.AbilityDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AbilityDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AbilityDescription.Location = new System.Drawing.Point(12, 62);
            this.AbilityDescription.Name = "AbilityDescription";
            this.AbilityDescription.Size = new System.Drawing.Size(336, 72);
            this.AbilityDescription.TabIndex = 8;
            this.AbilityDescription.Text = "";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionLbl.Location = new System.Drawing.Point(12, 47);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 9;
            this.DescriptionLbl.Text = "Description";
            // 
            // AbilityPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.CancelBttn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.AbilityDescription);
            this.Controls.Add(this.AffectOnUnitLbl);
            this.Controls.Add(this.AffectedUnitsLbl);
            this.Controls.Add(this.effectCheckBox);
            this.Controls.Add(this.unitsChooser);
            this.Controls.Add(this.s);
            this.Controls.Add(this.abilityName);
            this.Controls.Add(this.AddAbility);
            this.Controls.Add(this.CancelBttn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AbilityPopup";
            this.Text = "AbilityPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBttn;
        private System.Windows.Forms.Button AddAbility;
        private System.Windows.Forms.TextBox abilityName;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TreeView unitsChooser;
        private System.Windows.Forms.CheckedListBox effectCheckBox;
        private System.Windows.Forms.Label AffectedUnitsLbl;
        private System.Windows.Forms.Label AffectOnUnitLbl;
        private System.Windows.Forms.RichTextBox AbilityDescription;
        private System.Windows.Forms.Label DescriptionLbl;
    }
}