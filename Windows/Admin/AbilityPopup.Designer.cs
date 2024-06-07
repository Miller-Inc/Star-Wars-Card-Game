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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Allied Leader");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Self");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Specific Character(s)");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Target Ally");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Allies", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Enemy Leader");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Target Enemy ");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Specific Character(s)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Enemies", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
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
            this.affectOptionsTabControl = new System.Windows.Forms.TabControl();
            this.damagePage = new System.Windows.Forms.TabPage();
            this.flatRateDmgBttn = new System.Windows.Forms.RadioButton();
            this.percentageDmgBttn = new System.Windows.Forms.RadioButton();
            this.targetLbl = new System.Windows.Forms.Label();
            this.damageTarget = new System.Windows.Forms.ComboBox();
            this.DmgAmtLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.healPage = new System.Windows.Forms.TabPage();
            this.CharHealLbl = new System.Windows.Forms.Label();
            this.CharacterIptTreeView = new System.Windows.Forms.TreeView();
            this.addCharacterHeal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCharMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.healCharIpt = new System.Windows.Forms.ToolStripTextBox();
            this.addCharBttn = new System.Windows.Forms.ToolStripMenuItem();
            this.rmvSelCharBttn = new System.Windows.Forms.ToolStripMenuItem();
            this.healAlgnLbl = new System.Windows.Forms.Label();
            this.HealingAlignmentBox = new System.Windows.Forms.ComboBox();
            this.classInput = new System.Windows.Forms.CheckedListBox();
            this.CharacterClassLbl = new System.Windows.Forms.Label();
            this.setAmtHealBttn = new System.Windows.Forms.RadioButton();
            this.percHealBttn = new System.Windows.Forms.RadioButton();
            this.affectedAlliesLbl = new System.Windows.Forms.Label();
            this.affectedAlies = new System.Windows.Forms.ComboBox();
            this.healAmtLbl = new System.Windows.Forms.Label();
            this.healAmt = new System.Windows.Forms.NumericUpDown();
            this.StunPage = new System.Windows.Forms.TabPage();
            this.ModifyStatsPage = new System.Windows.Forms.TabPage();
            this.charIptLblDmg = new System.Windows.Forms.Label();
            this.dmgCharIpt = new System.Windows.Forms.TreeView();
            this.algnLblDmg = new System.Windows.Forms.Label();
            this.dmgAlgnIpt = new System.Windows.Forms.ComboBox();
            this.dmgClassIpt = new System.Windows.Forms.CheckedListBox();
            this.dmgClassLbl = new System.Windows.Forms.Label();
            this.addCharacterDmg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dmgAddCharMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.dmgCharNameIpt = new System.Windows.Forms.ToolStripTextBox();
            this.addCharDmg = new System.Windows.Forms.ToolStripMenuItem();
            this.removeChar = new System.Windows.Forms.ToolStripMenuItem();
            this.affectOptionsTabControl.SuspendLayout();
            this.damagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.healPage.SuspendLayout();
            this.addCharacterHeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healAmt)).BeginInit();
            this.addCharacterDmg.SuspendLayout();
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
            this.AddAbility.Text = "Save";
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
            treeNode2.Name = "Self";
            treeNode2.Text = "Self";
            treeNode3.Name = "SpecAlliedChars";
            treeNode3.Text = "Specific Character(s)";
            treeNode4.Name = "SelectedChar";
            treeNode4.Text = "Target Ally";
            treeNode5.Name = "AlliedUnits";
            treeNode5.Text = "Allies";
            treeNode6.Name = "EnemyLeader";
            treeNode6.Text = "Enemy Leader";
            treeNode7.Name = "TargetEnemy";
            treeNode7.Text = "Target Enemy ";
            treeNode8.Name = "SpecEnemyChars";
            treeNode8.Text = "Specific Character(s)";
            treeNode9.Name = "EnemyUnits";
            treeNode9.Text = "Enemies";
            this.unitsChooser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9});
            this.unitsChooser.Size = new System.Drawing.Size(336, 250);
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
            "Stun",
            "Modify Stats (Buff/Debuff)"});
            this.effectCheckBox.Location = new System.Drawing.Point(358, 78);
            this.effectCheckBox.Name = "effectCheckBox";
            this.effectCheckBox.Size = new System.Drawing.Size(147, 60);
            this.effectCheckBox.TabIndex = 5;
            this.effectCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.effectCheckBox_ItemCheck);
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
            this.AffectOnUnitLbl.Location = new System.Drawing.Point(355, 62);
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
            // affectOptionsTabControl
            // 
            this.affectOptionsTabControl.Controls.Add(this.damagePage);
            this.affectOptionsTabControl.Controls.Add(this.healPage);
            this.affectOptionsTabControl.Controls.Add(this.StunPage);
            this.affectOptionsTabControl.Controls.Add(this.ModifyStatsPage);
            this.affectOptionsTabControl.Location = new System.Drawing.Point(354, 153);
            this.affectOptionsTabControl.Name = "affectOptionsTabControl";
            this.affectOptionsTabControl.SelectedIndex = 0;
            this.affectOptionsTabControl.Size = new System.Drawing.Size(434, 250);
            this.affectOptionsTabControl.TabIndex = 10;
            // 
            // damagePage
            // 
            this.damagePage.BackColor = System.Drawing.Color.Black;
            this.damagePage.Controls.Add(this.charIptLblDmg);
            this.damagePage.Controls.Add(this.dmgCharIpt);
            this.damagePage.Controls.Add(this.algnLblDmg);
            this.damagePage.Controls.Add(this.dmgAlgnIpt);
            this.damagePage.Controls.Add(this.dmgClassIpt);
            this.damagePage.Controls.Add(this.dmgClassLbl);
            this.damagePage.Controls.Add(this.flatRateDmgBttn);
            this.damagePage.Controls.Add(this.percentageDmgBttn);
            this.damagePage.Controls.Add(this.targetLbl);
            this.damagePage.Controls.Add(this.damageTarget);
            this.damagePage.Controls.Add(this.DmgAmtLbl);
            this.damagePage.Controls.Add(this.numericUpDown1);
            this.damagePage.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.damagePage.Location = new System.Drawing.Point(4, 22);
            this.damagePage.Name = "damagePage";
            this.damagePage.Padding = new System.Windows.Forms.Padding(3);
            this.damagePage.Size = new System.Drawing.Size(426, 224);
            this.damagePage.TabIndex = 0;
            this.damagePage.Text = "Damage";
            // 
            // flatRateDmgBttn
            // 
            this.flatRateDmgBttn.AutoSize = true;
            this.flatRateDmgBttn.Checked = true;
            this.flatRateDmgBttn.Location = new System.Drawing.Point(215, 60);
            this.flatRateDmgBttn.Name = "flatRateDmgBttn";
            this.flatRateDmgBttn.Size = new System.Drawing.Size(80, 17);
            this.flatRateDmgBttn.TabIndex = 5;
            this.flatRateDmgBttn.TabStop = true;
            this.flatRateDmgBttn.Text = "Set Amount";
            this.flatRateDmgBttn.UseVisualStyleBackColor = true;
            this.flatRateDmgBttn.CheckedChanged += new System.EventHandler(this.flatRateDmgBttn_CheckedChanged);
            // 
            // percentageDmgBttn
            // 
            this.percentageDmgBttn.AutoSize = true;
            this.percentageDmgBttn.Location = new System.Drawing.Point(215, 34);
            this.percentageDmgBttn.Name = "percentageDmgBttn";
            this.percentageDmgBttn.Size = new System.Drawing.Size(80, 17);
            this.percentageDmgBttn.TabIndex = 4;
            this.percentageDmgBttn.Text = "Percentage";
            this.percentageDmgBttn.UseVisualStyleBackColor = true;
            this.percentageDmgBttn.CheckedChanged += new System.EventHandler(this.percentageDmgBttn_CheckedChanged);
            // 
            // targetLbl
            // 
            this.targetLbl.AutoSize = true;
            this.targetLbl.Location = new System.Drawing.Point(6, 60);
            this.targetLbl.Name = "targetLbl";
            this.targetLbl.Size = new System.Drawing.Size(90, 13);
            this.targetLbl.TabIndex = 3;
            this.targetLbl.Text = "Affected Enemies";
            // 
            // damageTarget
            // 
            this.damageTarget.BackColor = System.Drawing.Color.DimGray;
            this.damageTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.damageTarget.ForeColor = System.Drawing.Color.White;
            this.damageTarget.FormattingEnabled = true;
            this.damageTarget.Items.AddRange(new object[] {
            "Selected Enemy",
            "All Enemies",
            "Enemy Leader",
            "Specific Character(s)",
            "Specific Faction(s)",
            "Specific Allignment(s)"});
            this.damageTarget.Location = new System.Drawing.Point(6, 76);
            this.damageTarget.Name = "damageTarget";
            this.damageTarget.Size = new System.Drawing.Size(121, 21);
            this.damageTarget.TabIndex = 2;
            this.damageTarget.SelectedIndexChanged += new System.EventHandler(this.damageTarget_SelectedIndexChanged);
            // 
            // DmgAmtLbl
            // 
            this.DmgAmtLbl.AutoSize = true;
            this.DmgAmtLbl.Location = new System.Drawing.Point(7, 15);
            this.DmgAmtLbl.Name = "DmgAmtLbl";
            this.DmgAmtLbl.Size = new System.Drawing.Size(86, 13);
            this.DmgAmtLbl.TabIndex = 1;
            this.DmgAmtLbl.Text = "Damage Amount";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.DimGray;
            this.numericUpDown1.DecimalPlaces = 4;
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(6, 34);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // healPage
            // 
            this.healPage.BackColor = System.Drawing.Color.Black;
            this.healPage.Controls.Add(this.CharHealLbl);
            this.healPage.Controls.Add(this.CharacterIptTreeView);
            this.healPage.Controls.Add(this.healAlgnLbl);
            this.healPage.Controls.Add(this.HealingAlignmentBox);
            this.healPage.Controls.Add(this.classInput);
            this.healPage.Controls.Add(this.CharacterClassLbl);
            this.healPage.Controls.Add(this.setAmtHealBttn);
            this.healPage.Controls.Add(this.percHealBttn);
            this.healPage.Controls.Add(this.affectedAlliesLbl);
            this.healPage.Controls.Add(this.affectedAlies);
            this.healPage.Controls.Add(this.healAmtLbl);
            this.healPage.Controls.Add(this.healAmt);
            this.healPage.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.healPage.Location = new System.Drawing.Point(4, 22);
            this.healPage.Name = "healPage";
            this.healPage.Padding = new System.Windows.Forms.Padding(3);
            this.healPage.Size = new System.Drawing.Size(426, 224);
            this.healPage.TabIndex = 1;
            this.healPage.Text = "Heal";
            // 
            // CharHealLbl
            // 
            this.CharHealLbl.AutoSize = true;
            this.CharHealLbl.BackColor = System.Drawing.Color.Black;
            this.CharHealLbl.ForeColor = System.Drawing.Color.White;
            this.CharHealLbl.Location = new System.Drawing.Point(6, 109);
            this.CharHealLbl.Name = "CharHealLbl";
            this.CharHealLbl.Size = new System.Drawing.Size(58, 13);
            this.CharHealLbl.TabIndex = 17;
            this.CharHealLbl.Text = "Characters";
            // 
            // CharacterIptTreeView
            // 
            this.CharacterIptTreeView.BackColor = System.Drawing.Color.DimGray;
            this.CharacterIptTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterIptTreeView.ContextMenuStrip = this.addCharacterHeal;
            this.CharacterIptTreeView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CharacterIptTreeView.LineColor = System.Drawing.Color.WhiteSmoke;
            this.CharacterIptTreeView.Location = new System.Drawing.Point(8, 125);
            this.CharacterIptTreeView.Name = "CharacterIptTreeView";
            this.CharacterIptTreeView.Size = new System.Drawing.Size(201, 90);
            this.CharacterIptTreeView.TabIndex = 16;
            // 
            // addCharacterHeal
            // 
            this.addCharacterHeal.BackColor = System.Drawing.Color.CadetBlue;
            this.addCharacterHeal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharMenuHeader,
            this.rmvSelCharBttn});
            this.addCharacterHeal.Name = "addCharacterHeal";
            this.addCharacterHeal.Size = new System.Drawing.Size(219, 48);
            // 
            // addCharMenuHeader
            // 
            this.addCharMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healCharIpt,
            this.addCharBttn});
            this.addCharMenuHeader.Name = "addCharMenuHeader";
            this.addCharMenuHeader.Size = new System.Drawing.Size(218, 22);
            this.addCharMenuHeader.Text = "Add Character...";
            // 
            // healCharIpt
            // 
            this.healCharIpt.BackColor = System.Drawing.Color.CadetBlue;
            this.healCharIpt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.healCharIpt.Name = "healCharIpt";
            this.healCharIpt.Size = new System.Drawing.Size(100, 23);
            // 
            // addCharBttn
            // 
            this.addCharBttn.BackColor = System.Drawing.Color.CadetBlue;
            this.addCharBttn.Name = "addCharBttn";
            this.addCharBttn.Size = new System.Drawing.Size(180, 22);
            this.addCharBttn.Text = "Add Character";
            this.addCharBttn.Click += new System.EventHandler(this.addCharBttn_Click);
            // 
            // rmvSelCharBttn
            // 
            this.rmvSelCharBttn.Name = "rmvSelCharBttn";
            this.rmvSelCharBttn.Size = new System.Drawing.Size(218, 22);
            this.rmvSelCharBttn.Text = "Remove Selected Character";
            this.rmvSelCharBttn.Click += new System.EventHandler(this.rmvSelCharBttn_Click);
            // 
            // healAlgnLbl
            // 
            this.healAlgnLbl.AutoSize = true;
            this.healAlgnLbl.BackColor = System.Drawing.Color.Black;
            this.healAlgnLbl.ForeColor = System.Drawing.Color.White;
            this.healAlgnLbl.Location = new System.Drawing.Point(6, 109);
            this.healAlgnLbl.Name = "healAlgnLbl";
            this.healAlgnLbl.Size = new System.Drawing.Size(58, 13);
            this.healAlgnLbl.TabIndex = 15;
            this.healAlgnLbl.Text = "Alignments";
            // 
            // HealingAlignmentBox
            // 
            this.HealingAlignmentBox.BackColor = System.Drawing.Color.DimGray;
            this.HealingAlignmentBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealingAlignmentBox.ForeColor = System.Drawing.Color.White;
            this.HealingAlignmentBox.FormattingEnabled = true;
            this.HealingAlignmentBox.Items.AddRange(new object[] {
            "Light Side",
            "Dark Side",
            "Neutral"});
            this.HealingAlignmentBox.Location = new System.Drawing.Point(9, 125);
            this.HealingAlignmentBox.Name = "HealingAlignmentBox";
            this.HealingAlignmentBox.Size = new System.Drawing.Size(154, 21);
            this.HealingAlignmentBox.TabIndex = 14;
            // 
            // classInput
            // 
            this.classInput.BackColor = System.Drawing.Color.DimGray;
            this.classInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classInput.ForeColor = System.Drawing.Color.White;
            this.classInput.FormattingEnabled = true;
            this.classInput.Location = new System.Drawing.Point(8, 125);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(201, 90);
            this.classInput.TabIndex = 13;
            // 
            // CharacterClassLbl
            // 
            this.CharacterClassLbl.AutoSize = true;
            this.CharacterClassLbl.BackColor = System.Drawing.Color.Black;
            this.CharacterClassLbl.ForeColor = System.Drawing.Color.White;
            this.CharacterClassLbl.Location = new System.Drawing.Point(5, 109);
            this.CharacterClassLbl.Name = "CharacterClassLbl";
            this.CharacterClassLbl.Size = new System.Drawing.Size(43, 13);
            this.CharacterClassLbl.TabIndex = 12;
            this.CharacterClassLbl.Text = "Classes";
            // 
            // setAmtHealBttn
            // 
            this.setAmtHealBttn.AutoSize = true;
            this.setAmtHealBttn.Checked = true;
            this.setAmtHealBttn.Location = new System.Drawing.Point(214, 60);
            this.setAmtHealBttn.Name = "setAmtHealBttn";
            this.setAmtHealBttn.Size = new System.Drawing.Size(80, 17);
            this.setAmtHealBttn.TabIndex = 11;
            this.setAmtHealBttn.TabStop = true;
            this.setAmtHealBttn.Text = "Set Amount";
            this.setAmtHealBttn.UseVisualStyleBackColor = true;
            this.setAmtHealBttn.CheckedChanged += new System.EventHandler(this.setAmtHealBttn_CheckedChanged);
            // 
            // percHealBttn
            // 
            this.percHealBttn.AutoSize = true;
            this.percHealBttn.Location = new System.Drawing.Point(214, 34);
            this.percHealBttn.Name = "percHealBttn";
            this.percHealBttn.Size = new System.Drawing.Size(80, 17);
            this.percHealBttn.TabIndex = 10;
            this.percHealBttn.Text = "Percentage";
            this.percHealBttn.UseVisualStyleBackColor = true;
            this.percHealBttn.CheckedChanged += new System.EventHandler(this.percHealBttn_CheckedChanged);
            // 
            // affectedAlliesLbl
            // 
            this.affectedAlliesLbl.AutoSize = true;
            this.affectedAlliesLbl.Location = new System.Drawing.Point(5, 60);
            this.affectedAlliesLbl.Name = "affectedAlliesLbl";
            this.affectedAlliesLbl.Size = new System.Drawing.Size(74, 13);
            this.affectedAlliesLbl.TabIndex = 9;
            this.affectedAlliesLbl.Text = "Affected Allies";
            // 
            // affectedAlies
            // 
            this.affectedAlies.BackColor = System.Drawing.Color.DimGray;
            this.affectedAlies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.affectedAlies.ForeColor = System.Drawing.Color.White;
            this.affectedAlies.FormattingEnabled = true;
            this.affectedAlies.Items.AddRange(new object[] {
            "Selected Ally",
            "All Allies",
            "Self",
            "Allied Leader",
            "Specific Character(s)",
            "Specific Faction(s)",
            "Specific Allignment(s)"});
            this.affectedAlies.Location = new System.Drawing.Point(5, 76);
            this.affectedAlies.Name = "affectedAlies";
            this.affectedAlies.Size = new System.Drawing.Size(121, 21);
            this.affectedAlies.TabIndex = 8;
            this.affectedAlies.SelectedIndexChanged += new System.EventHandler(this.affectedAlies_SelectedIndexChanged);
            // 
            // healAmtLbl
            // 
            this.healAmtLbl.AutoSize = true;
            this.healAmtLbl.Location = new System.Drawing.Point(6, 15);
            this.healAmtLbl.Name = "healAmtLbl";
            this.healAmtLbl.Size = new System.Drawing.Size(68, 13);
            this.healAmtLbl.TabIndex = 7;
            this.healAmtLbl.Text = "Heal Amount";
            // 
            // healAmt
            // 
            this.healAmt.BackColor = System.Drawing.Color.DimGray;
            this.healAmt.DecimalPlaces = 4;
            this.healAmt.ForeColor = System.Drawing.Color.White;
            this.healAmt.Location = new System.Drawing.Point(5, 34);
            this.healAmt.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.healAmt.Name = "healAmt";
            this.healAmt.Size = new System.Drawing.Size(96, 20);
            this.healAmt.TabIndex = 6;
            // 
            // StunPage
            // 
            this.StunPage.BackColor = System.Drawing.Color.Black;
            this.StunPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StunPage.Location = new System.Drawing.Point(4, 22);
            this.StunPage.Name = "StunPage";
            this.StunPage.Padding = new System.Windows.Forms.Padding(3);
            this.StunPage.Size = new System.Drawing.Size(426, 224);
            this.StunPage.TabIndex = 2;
            this.StunPage.Text = "Stun";
            // 
            // ModifyStatsPage
            // 
            this.ModifyStatsPage.BackColor = System.Drawing.Color.Black;
            this.ModifyStatsPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ModifyStatsPage.Location = new System.Drawing.Point(4, 22);
            this.ModifyStatsPage.Name = "ModifyStatsPage";
            this.ModifyStatsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ModifyStatsPage.Size = new System.Drawing.Size(426, 224);
            this.ModifyStatsPage.TabIndex = 3;
            this.ModifyStatsPage.Text = "Modify Stats";
            // 
            // charIptLblDmg
            // 
            this.charIptLblDmg.AutoSize = true;
            this.charIptLblDmg.BackColor = System.Drawing.Color.Black;
            this.charIptLblDmg.ForeColor = System.Drawing.Color.White;
            this.charIptLblDmg.Location = new System.Drawing.Point(212, 100);
            this.charIptLblDmg.Name = "charIptLblDmg";
            this.charIptLblDmg.Size = new System.Drawing.Size(58, 13);
            this.charIptLblDmg.TabIndex = 23;
            this.charIptLblDmg.Text = "Characters";
            // 
            // dmgCharIpt
            // 
            this.dmgCharIpt.BackColor = System.Drawing.Color.DimGray;
            this.dmgCharIpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dmgCharIpt.ContextMenuStrip = this.addCharacterHeal;
            this.dmgCharIpt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dmgCharIpt.LineColor = System.Drawing.Color.WhiteSmoke;
            this.dmgCharIpt.Location = new System.Drawing.Point(215, 116);
            this.dmgCharIpt.Name = "dmgCharIpt";
            this.dmgCharIpt.Size = new System.Drawing.Size(201, 90);
            this.dmgCharIpt.TabIndex = 22;
            // 
            // algnLblDmg
            // 
            this.algnLblDmg.AutoSize = true;
            this.algnLblDmg.BackColor = System.Drawing.Color.Black;
            this.algnLblDmg.ForeColor = System.Drawing.Color.White;
            this.algnLblDmg.Location = new System.Drawing.Point(113, 100);
            this.algnLblDmg.Name = "algnLblDmg";
            this.algnLblDmg.Size = new System.Drawing.Size(58, 13);
            this.algnLblDmg.TabIndex = 21;
            this.algnLblDmg.Text = "Alignments";
            // 
            // dmgAlgnIpt
            // 
            this.dmgAlgnIpt.BackColor = System.Drawing.Color.DimGray;
            this.dmgAlgnIpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dmgAlgnIpt.ForeColor = System.Drawing.Color.White;
            this.dmgAlgnIpt.FormattingEnabled = true;
            this.dmgAlgnIpt.Items.AddRange(new object[] {
            "Light Side",
            "Dark Side",
            "Neutral"});
            this.dmgAlgnIpt.Location = new System.Drawing.Point(116, 116);
            this.dmgAlgnIpt.Name = "dmgAlgnIpt";
            this.dmgAlgnIpt.Size = new System.Drawing.Size(154, 21);
            this.dmgAlgnIpt.TabIndex = 20;
            // 
            // dmgClassIpt
            // 
            this.dmgClassIpt.BackColor = System.Drawing.Color.DimGray;
            this.dmgClassIpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dmgClassIpt.ForeColor = System.Drawing.Color.White;
            this.dmgClassIpt.FormattingEnabled = true;
            this.dmgClassIpt.Location = new System.Drawing.Point(9, 116);
            this.dmgClassIpt.Name = "dmgClassIpt";
            this.dmgClassIpt.Size = new System.Drawing.Size(201, 90);
            this.dmgClassIpt.TabIndex = 19;
            // 
            // dmgClassLbl
            // 
            this.dmgClassLbl.AutoSize = true;
            this.dmgClassLbl.BackColor = System.Drawing.Color.Black;
            this.dmgClassLbl.ForeColor = System.Drawing.Color.White;
            this.dmgClassLbl.Location = new System.Drawing.Point(6, 100);
            this.dmgClassLbl.Name = "dmgClassLbl";
            this.dmgClassLbl.Size = new System.Drawing.Size(43, 13);
            this.dmgClassLbl.TabIndex = 18;
            this.dmgClassLbl.Text = "Classes";
            // 
            // addCharacterDmg
            // 
            this.addCharacterDmg.BackColor = System.Drawing.Color.CadetBlue;
            this.addCharacterDmg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dmgAddCharMenuHeader,
            this.removeChar});
            this.addCharacterDmg.Name = "addCharacterHeal";
            this.addCharacterDmg.Size = new System.Drawing.Size(219, 48);
            // 
            // dmgAddCharMenuHeader
            // 
            this.dmgAddCharMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dmgCharNameIpt,
            this.addCharDmg});
            this.dmgAddCharMenuHeader.Name = "dmgAddCharMenuHeader";
            this.dmgAddCharMenuHeader.Size = new System.Drawing.Size(218, 22);
            this.dmgAddCharMenuHeader.Text = "Add Character...";
            // 
            // dmgCharNameIpt
            // 
            this.dmgCharNameIpt.BackColor = System.Drawing.Color.CadetBlue;
            this.dmgCharNameIpt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dmgCharNameIpt.Name = "dmgCharNameIpt";
            this.dmgCharNameIpt.Size = new System.Drawing.Size(100, 23);
            // 
            // addCharDmg
            // 
            this.addCharDmg.BackColor = System.Drawing.Color.CadetBlue;
            this.addCharDmg.Name = "addCharDmg";
            this.addCharDmg.Size = new System.Drawing.Size(180, 22);
            this.addCharDmg.Text = "Add Character";
            this.addCharDmg.Click += new System.EventHandler(this.addCharDmg_Click);
            // 
            // removeChar
            // 
            this.removeChar.Name = "removeChar";
            this.removeChar.Size = new System.Drawing.Size(218, 22);
            this.removeChar.Text = "Remove Selected Character";
            this.removeChar.Click += new System.EventHandler(this.removeChar_Click);
            // 
            // AbilityPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.CancelBttn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.affectOptionsTabControl);
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
            this.Text = "Ability Popup";
            this.affectOptionsTabControl.ResumeLayout(false);
            this.damagePage.ResumeLayout(false);
            this.damagePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.healPage.ResumeLayout(false);
            this.healPage.PerformLayout();
            this.addCharacterHeal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.healAmt)).EndInit();
            this.addCharacterDmg.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl affectOptionsTabControl;
        private System.Windows.Forms.TabPage damagePage;
        private System.Windows.Forms.TabPage healPage;
        private System.Windows.Forms.TabPage StunPage;
        private System.Windows.Forms.TabPage ModifyStatsPage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label DmgAmtLbl;
        private System.Windows.Forms.RadioButton percentageDmgBttn;
        private System.Windows.Forms.Label targetLbl;
        private System.Windows.Forms.ComboBox damageTarget;
        private System.Windows.Forms.RadioButton flatRateDmgBttn;
        private System.Windows.Forms.RadioButton setAmtHealBttn;
        private System.Windows.Forms.RadioButton percHealBttn;
        private System.Windows.Forms.Label affectedAlliesLbl;
        private System.Windows.Forms.ComboBox affectedAlies;
        private System.Windows.Forms.Label healAmtLbl;
        private System.Windows.Forms.NumericUpDown healAmt;
        private System.Windows.Forms.CheckedListBox classInput;
        private System.Windows.Forms.Label CharacterClassLbl;
        private System.Windows.Forms.ContextMenuStrip addCharacterHeal;
        private System.Windows.Forms.Label healAlgnLbl;
        private System.Windows.Forms.ComboBox HealingAlignmentBox;
        private System.Windows.Forms.ToolStripMenuItem addCharMenuHeader;
        private System.Windows.Forms.ToolStripTextBox healCharIpt;
        private System.Windows.Forms.ToolStripMenuItem addCharBttn;
        private System.Windows.Forms.ToolStripMenuItem rmvSelCharBttn;
        private System.Windows.Forms.TreeView CharacterIptTreeView;
        private System.Windows.Forms.Label CharHealLbl;
        private System.Windows.Forms.Label charIptLblDmg;
        private System.Windows.Forms.TreeView dmgCharIpt;
        private System.Windows.Forms.Label algnLblDmg;
        private System.Windows.Forms.ComboBox dmgAlgnIpt;
        private System.Windows.Forms.CheckedListBox dmgClassIpt;
        private System.Windows.Forms.Label dmgClassLbl;
        private System.Windows.Forms.ContextMenuStrip addCharacterDmg;
        private System.Windows.Forms.ToolStripMenuItem dmgAddCharMenuHeader;
        private System.Windows.Forms.ToolStripTextBox dmgCharNameIpt;
        private System.Windows.Forms.ToolStripMenuItem addCharDmg;
        private System.Windows.Forms.ToolStripMenuItem removeChar;
    }
}