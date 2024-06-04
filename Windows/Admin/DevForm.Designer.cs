namespace Star_Wars_Card_Game.Windows
{
    partial class DevForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Basic");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevForm));
            this.EditAbility = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAbilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAbilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAbilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devTabs = new System.Windows.Forms.TabControl();
            this.AddPlayers = new System.Windows.Forms.TabPage();
            this.ImageLbl = new System.Windows.Forms.Label();
            this.abilitiesLbl = new System.Windows.Forms.Label();
            this.abilitesIptDisplay = new System.Windows.Forms.TreeView();
            this.baseAtkIpt = new System.Windows.Forms.NumericUpDown();
            this.AttckLbl = new System.Windows.Forms.Label();
            this.baseSpdIn = new System.Windows.Forms.NumericUpDown();
            this.SpdLbl = new System.Windows.Forms.Label();
            this.baseDefIpt = new System.Windows.Forms.NumericUpDown();
            this.DefenseLbl = new System.Windows.Forms.Label();
            this.baseHltIpt = new System.Windows.Forms.NumericUpDown();
            this.HealthLbl = new System.Windows.Forms.Label();
            this.CharacterPicture = new System.Windows.Forms.PictureBox();
            this.AlignLbl = new System.Windows.Forms.Label();
            this.alignIpt = new System.Windows.Forms.ComboBox();
            this.classInput = new System.Windows.Forms.CheckedListBox();
            this.ClassMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.className = new System.Windows.Forms.ToolStripTextBox();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classOptionsMenu = new System.Windows.Forms.ToolStripComboBox();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterNameIn = new System.Windows.Forms.TextBox();
            this.CharacterClassLbl = new System.Windows.Forms.Label();
            this.charNameLbl = new System.Windows.Forms.Label();
            this.RemoveCharacterTbPg = new System.Windows.Forms.TabPage();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.removeAbilityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAbility.SuspendLayout();
            this.devTabs.SuspendLayout();
            this.AddPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseAtkIpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSpdIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDefIpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseHltIpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPicture)).BeginInit();
            this.ClassMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditAbility
            // 
            this.EditAbility.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAbilityToolStripMenuItem,
            this.removeAbilityToolStripMenuItem,
            this.addAbilityToolStripMenuItem});
            this.EditAbility.Name = "EditAbility";
            this.EditAbility.Size = new System.Drawing.Size(181, 92);
            // 
            // editAbilityToolStripMenuItem
            // 
            this.editAbilityToolStripMenuItem.Name = "editAbilityToolStripMenuItem";
            this.editAbilityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editAbilityToolStripMenuItem.Text = "Edit Selected Ability";
            // 
            // removeAbilityToolStripMenuItem
            // 
            this.removeAbilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.removeAbilityToolStripMenuItem1});
            this.removeAbilityToolStripMenuItem.Name = "removeAbilityToolStripMenuItem";
            this.removeAbilityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeAbilityToolStripMenuItem.Text = "Remove Ability...";
            // 
            // addAbilityToolStripMenuItem
            // 
            this.addAbilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.specialToolStripMenuItem,
            this.ultimateToolStripMenuItem});
            this.addAbilityToolStripMenuItem.Name = "addAbilityToolStripMenuItem";
            this.addAbilityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAbilityToolStripMenuItem.Text = "Add Ability...";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.basicToolStripMenuItem.Text = "Basic";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click);
            // 
            // specialToolStripMenuItem
            // 
            this.specialToolStripMenuItem.Name = "specialToolStripMenuItem";
            this.specialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.specialToolStripMenuItem.Text = "Special";
            // 
            // ultimateToolStripMenuItem
            // 
            this.ultimateToolStripMenuItem.Name = "ultimateToolStripMenuItem";
            this.ultimateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ultimateToolStripMenuItem.Text = "Ultimate";
            // 
            // devTabs
            // 
            this.devTabs.Controls.Add(this.AddPlayers);
            this.devTabs.Controls.Add(this.RemoveCharacterTbPg);
            this.devTabs.Location = new System.Drawing.Point(12, 12);
            this.devTabs.Name = "devTabs";
            this.devTabs.SelectedIndex = 0;
            this.devTabs.Size = new System.Drawing.Size(973, 526);
            this.devTabs.TabIndex = 0;
            // 
            // AddPlayers
            // 
            this.AddPlayers.BackColor = System.Drawing.Color.Black;
            this.AddPlayers.Controls.Add(this.ImageLbl);
            this.AddPlayers.Controls.Add(this.abilitiesLbl);
            this.AddPlayers.Controls.Add(this.abilitesIptDisplay);
            this.AddPlayers.Controls.Add(this.baseAtkIpt);
            this.AddPlayers.Controls.Add(this.AttckLbl);
            this.AddPlayers.Controls.Add(this.baseSpdIn);
            this.AddPlayers.Controls.Add(this.SpdLbl);
            this.AddPlayers.Controls.Add(this.baseDefIpt);
            this.AddPlayers.Controls.Add(this.DefenseLbl);
            this.AddPlayers.Controls.Add(this.baseHltIpt);
            this.AddPlayers.Controls.Add(this.HealthLbl);
            this.AddPlayers.Controls.Add(this.CharacterPicture);
            this.AddPlayers.Controls.Add(this.AlignLbl);
            this.AddPlayers.Controls.Add(this.alignIpt);
            this.AddPlayers.Controls.Add(this.classInput);
            this.AddPlayers.Controls.Add(this.characterNameIn);
            this.AddPlayers.Controls.Add(this.CharacterClassLbl);
            this.AddPlayers.Controls.Add(this.charNameLbl);
            this.AddPlayers.Location = new System.Drawing.Point(4, 22);
            this.AddPlayers.Name = "AddPlayers";
            this.AddPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.AddPlayers.Size = new System.Drawing.Size(965, 500);
            this.AddPlayers.TabIndex = 0;
            this.AddPlayers.Text = "Add Characters";
            // 
            // ImageLbl
            // 
            this.ImageLbl.AutoSize = true;
            this.ImageLbl.ForeColor = System.Drawing.Color.White;
            this.ImageLbl.Location = new System.Drawing.Point(595, 46);
            this.ImageLbl.Name = "ImageLbl";
            this.ImageLbl.Size = new System.Drawing.Size(85, 13);
            this.ImageLbl.TabIndex = 18;
            this.ImageLbl.Text = "Character Image";
            // 
            // abilitiesLbl
            // 
            this.abilitiesLbl.AutoSize = true;
            this.abilitiesLbl.ForeColor = System.Drawing.Color.White;
            this.abilitiesLbl.Location = new System.Drawing.Point(12, 348);
            this.abilitiesLbl.Name = "abilitiesLbl";
            this.abilitiesLbl.Size = new System.Drawing.Size(42, 13);
            this.abilitiesLbl.TabIndex = 17;
            this.abilitiesLbl.Text = "Abilities";
            // 
            // abilitesIptDisplay
            // 
            this.abilitesIptDisplay.BackColor = System.Drawing.Color.DimGray;
            this.abilitesIptDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.abilitesIptDisplay.ContextMenuStrip = this.EditAbility;
            this.abilitesIptDisplay.ForeColor = System.Drawing.Color.White;
            this.abilitesIptDisplay.Location = new System.Drawing.Point(9, 363);
            this.abilitesIptDisplay.Name = "abilitesIptDisplay";
            treeNode1.Checked = true;
            treeNode1.ContextMenuStrip = this.EditAbility;
            treeNode1.Name = "Basic";
            treeNode1.Text = "Basic";
            this.abilitesIptDisplay.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.abilitesIptDisplay.Size = new System.Drawing.Size(278, 131);
            this.abilitesIptDisplay.TabIndex = 16;
            // 
            // baseAtkIpt
            // 
            this.baseAtkIpt.Location = new System.Drawing.Point(171, 325);
            this.baseAtkIpt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.baseAtkIpt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baseAtkIpt.Name = "baseAtkIpt";
            this.baseAtkIpt.Size = new System.Drawing.Size(116, 20);
            this.baseAtkIpt.TabIndex = 15;
            this.baseAtkIpt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AttckLbl
            // 
            this.AttckLbl.AutoSize = true;
            this.AttckLbl.ForeColor = System.Drawing.Color.White;
            this.AttckLbl.Location = new System.Drawing.Point(171, 309);
            this.AttckLbl.Name = "AttckLbl";
            this.AttckLbl.Size = new System.Drawing.Size(65, 13);
            this.AttckLbl.TabIndex = 14;
            this.AttckLbl.Text = "Base Attack";
            // 
            // baseSpdIn
            // 
            this.baseSpdIn.Location = new System.Drawing.Point(12, 325);
            this.baseSpdIn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.baseSpdIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baseSpdIn.Name = "baseSpdIn";
            this.baseSpdIn.Size = new System.Drawing.Size(133, 20);
            this.baseSpdIn.TabIndex = 13;
            this.baseSpdIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SpdLbl
            // 
            this.SpdLbl.AutoSize = true;
            this.SpdLbl.ForeColor = System.Drawing.Color.White;
            this.SpdLbl.Location = new System.Drawing.Point(12, 309);
            this.SpdLbl.Name = "SpdLbl";
            this.SpdLbl.Size = new System.Drawing.Size(38, 13);
            this.SpdLbl.TabIndex = 12;
            this.SpdLbl.Text = "Speed";
            // 
            // baseDefIpt
            // 
            this.baseDefIpt.Location = new System.Drawing.Point(171, 277);
            this.baseDefIpt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.baseDefIpt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baseDefIpt.Name = "baseDefIpt";
            this.baseDefIpt.Size = new System.Drawing.Size(116, 20);
            this.baseDefIpt.TabIndex = 11;
            this.baseDefIpt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DefenseLbl
            // 
            this.DefenseLbl.AutoSize = true;
            this.DefenseLbl.ForeColor = System.Drawing.Color.White;
            this.DefenseLbl.Location = new System.Drawing.Point(171, 261);
            this.DefenseLbl.Name = "DefenseLbl";
            this.DefenseLbl.Size = new System.Drawing.Size(47, 13);
            this.DefenseLbl.TabIndex = 10;
            this.DefenseLbl.Text = "Defense";
            // 
            // baseHltIpt
            // 
            this.baseHltIpt.Location = new System.Drawing.Point(9, 277);
            this.baseHltIpt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.baseHltIpt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baseHltIpt.Name = "baseHltIpt";
            this.baseHltIpt.Size = new System.Drawing.Size(136, 20);
            this.baseHltIpt.TabIndex = 9;
            this.baseHltIpt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HealthLbl
            // 
            this.HealthLbl.AutoSize = true;
            this.HealthLbl.ForeColor = System.Drawing.Color.White;
            this.HealthLbl.Location = new System.Drawing.Point(9, 261);
            this.HealthLbl.Name = "HealthLbl";
            this.HealthLbl.Size = new System.Drawing.Size(38, 13);
            this.HealthLbl.TabIndex = 8;
            this.HealthLbl.Text = "Health";
            // 
            // CharacterPicture
            // 
            this.CharacterPicture.Image = ((System.Drawing.Image)(resources.GetObject("CharacterPicture.Image")));
            this.CharacterPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("CharacterPicture.InitialImage")));
            this.CharacterPicture.Location = new System.Drawing.Point(469, 62);
            this.CharacterPicture.Name = "CharacterPicture";
            this.CharacterPicture.Size = new System.Drawing.Size(350, 350);
            this.CharacterPicture.TabIndex = 7;
            this.CharacterPicture.TabStop = false;
            // 
            // AlignLbl
            // 
            this.AlignLbl.AutoSize = true;
            this.AlignLbl.ForeColor = System.Drawing.Color.White;
            this.AlignLbl.Location = new System.Drawing.Point(9, 215);
            this.AlignLbl.Name = "AlignLbl";
            this.AlignLbl.Size = new System.Drawing.Size(53, 13);
            this.AlignLbl.TabIndex = 6;
            this.AlignLbl.Text = "Alignment";
            // 
            // alignIpt
            // 
            this.alignIpt.FormattingEnabled = true;
            this.alignIpt.Location = new System.Drawing.Point(12, 231);
            this.alignIpt.Name = "alignIpt";
            this.alignIpt.Size = new System.Drawing.Size(275, 21);
            this.alignIpt.TabIndex = 5;
            // 
            // classInput
            // 
            this.classInput.BackColor = System.Drawing.Color.DimGray;
            this.classInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classInput.ContextMenuStrip = this.ClassMenu;
            this.classInput.ForeColor = System.Drawing.Color.White;
            this.classInput.FormattingEnabled = true;
            this.classInput.Location = new System.Drawing.Point(12, 62);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(275, 150);
            this.classInput.TabIndex = 4;
            // 
            // ClassMenu
            // 
            this.ClassMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.removeClassToolStripMenuItem});
            this.ClassMenu.Name = "ClassMenu";
            this.ClassMenu.Size = new System.Drawing.Size(157, 48);
            this.ClassMenu.Text = "Class Options";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.className,
            this.addClassToolStripMenuItem});
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewToolStripMenuItem.Text = "Add New Class";
            // 
            // className
            // 
            this.className.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(100, 23);
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addClassToolStripMenuItem.Text = "Add Class";
            this.addClassToolStripMenuItem.Click += new System.EventHandler(this.addClassToolStripMenuItem_Click);
            // 
            // removeClassToolStripMenuItem
            // 
            this.removeClassToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classOptionsMenu,
            this.removeToolStripMenuItem});
            this.removeClassToolStripMenuItem.Name = "removeClassToolStripMenuItem";
            this.removeClassToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.removeClassToolStripMenuItem.Text = "Remove Class...";
            // 
            // classOptionsMenu
            // 
            this.classOptionsMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.classOptionsMenu.Items.AddRange(new object[] {
            "(No Items Loaded)"});
            this.classOptionsMenu.Name = "classOptionsMenu";
            this.classOptionsMenu.Size = new System.Drawing.Size(121, 23);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // characterNameIn
            // 
            this.characterNameIn.BackColor = System.Drawing.Color.Gray;
            this.characterNameIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.characterNameIn.ForeColor = System.Drawing.Color.White;
            this.characterNameIn.Location = new System.Drawing.Point(12, 19);
            this.characterNameIn.Name = "characterNameIn";
            this.characterNameIn.Size = new System.Drawing.Size(275, 13);
            this.characterNameIn.TabIndex = 3;
            // 
            // CharacterClassLbl
            // 
            this.CharacterClassLbl.AutoSize = true;
            this.CharacterClassLbl.BackColor = System.Drawing.Color.Black;
            this.CharacterClassLbl.ForeColor = System.Drawing.Color.White;
            this.CharacterClassLbl.Location = new System.Drawing.Point(9, 46);
            this.CharacterClassLbl.Name = "CharacterClassLbl";
            this.CharacterClassLbl.Size = new System.Drawing.Size(114, 13);
            this.CharacterClassLbl.TabIndex = 1;
            this.CharacterClassLbl.Text = "Classes (One Per Line)";
            // 
            // charNameLbl
            // 
            this.charNameLbl.AutoSize = true;
            this.charNameLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.charNameLbl.Location = new System.Drawing.Point(6, 3);
            this.charNameLbl.Name = "charNameLbl";
            this.charNameLbl.Size = new System.Drawing.Size(84, 13);
            this.charNameLbl.TabIndex = 0;
            this.charNameLbl.Text = "Character Name";
            // 
            // RemoveCharacterTbPg
            // 
            this.RemoveCharacterTbPg.BackColor = System.Drawing.Color.Black;
            this.RemoveCharacterTbPg.Location = new System.Drawing.Point(4, 22);
            this.RemoveCharacterTbPg.Name = "RemoveCharacterTbPg";
            this.RemoveCharacterTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.RemoveCharacterTbPg.Size = new System.Drawing.Size(965, 500);
            this.RemoveCharacterTbPg.TabIndex = 1;
            this.RemoveCharacterTbPg.Text = "Remove Character";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // removeAbilityToolStripMenuItem1
            // 
            this.removeAbilityToolStripMenuItem1.Name = "removeAbilityToolStripMenuItem1";
            this.removeAbilityToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.removeAbilityToolStripMenuItem1.Text = "Remove Ability";
            // 
            // DevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(997, 550);
            this.Controls.Add(this.devTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DevForm";
            this.Text = "Development Form";
            this.EditAbility.ResumeLayout(false);
            this.devTabs.ResumeLayout(false);
            this.AddPlayers.ResumeLayout(false);
            this.AddPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseAtkIpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSpdIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDefIpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseHltIpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPicture)).EndInit();
            this.ClassMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl devTabs;
        private System.Windows.Forms.TabPage AddPlayers;
        private System.Windows.Forms.Label charNameLbl;
        private System.Windows.Forms.TabPage RemoveCharacterTbPg;
        private System.Windows.Forms.Label CharacterClassLbl;
        private System.Windows.Forms.TextBox characterNameIn;
        private System.Windows.Forms.ContextMenuStrip ClassMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox classOptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox className;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox classInput;
        private System.Windows.Forms.ComboBox alignIpt;
        private System.Windows.Forms.PictureBox CharacterPicture;
        private System.Windows.Forms.Label AlignLbl;
        private System.Windows.Forms.NumericUpDown baseHltIpt;
        private System.Windows.Forms.Label HealthLbl;
        private System.Windows.Forms.NumericUpDown baseSpdIn;
        private System.Windows.Forms.Label SpdLbl;
        private System.Windows.Forms.NumericUpDown baseAtkIpt;
        private System.Windows.Forms.Label AttckLbl;
        private System.Windows.Forms.NumericUpDown baseDefIpt;
        private System.Windows.Forms.Label DefenseLbl;
        private System.Windows.Forms.TreeView abilitesIptDisplay;
        private System.Windows.Forms.Label abilitiesLbl;
        private System.Windows.Forms.ContextMenuStrip EditAbility;
        private System.Windows.Forms.ToolStripMenuItem editAbilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAbilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAbilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimateToolStripMenuItem;
        private System.Windows.Forms.Label ImageLbl;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem removeAbilityToolStripMenuItem1;
    }
}