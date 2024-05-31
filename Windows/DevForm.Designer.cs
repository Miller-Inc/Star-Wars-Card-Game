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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevForm));
            this.devTabs = new System.Windows.Forms.TabControl();
            this.AddPlayers = new System.Windows.Forms.TabPage();
            this.characterNameIn = new System.Windows.Forms.TextBox();
            this.classInput = new System.Windows.Forms.RichTextBox();
            this.ClassMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classOptionsMenu = new System.Windows.Forms.ToolStripComboBox();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassToCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClasses = new System.Windows.Forms.ToolStripComboBox();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterClassLbl = new System.Windows.Forms.Label();
            this.charNameLbl = new System.Windows.Forms.Label();
            this.RemoveCharacterTbPg = new System.Windows.Forms.TabPage();
            this.devTabs.SuspendLayout();
            this.AddPlayers.SuspendLayout();
            this.ClassMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // devTabs
            // 
            this.devTabs.Controls.Add(this.AddPlayers);
            this.devTabs.Controls.Add(this.RemoveCharacterTbPg);
            this.devTabs.Location = new System.Drawing.Point(12, 12);
            this.devTabs.Name = "devTabs";
            this.devTabs.SelectedIndex = 0;
            this.devTabs.Size = new System.Drawing.Size(776, 426);
            this.devTabs.TabIndex = 0;
            // 
            // AddPlayers
            // 
            this.AddPlayers.BackColor = System.Drawing.Color.Black;
            this.AddPlayers.Controls.Add(this.characterNameIn);
            this.AddPlayers.Controls.Add(this.classInput);
            this.AddPlayers.Controls.Add(this.CharacterClassLbl);
            this.AddPlayers.Controls.Add(this.charNameLbl);
            this.AddPlayers.Location = new System.Drawing.Point(4, 22);
            this.AddPlayers.Name = "AddPlayers";
            this.AddPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.AddPlayers.Size = new System.Drawing.Size(768, 400);
            this.AddPlayers.TabIndex = 0;
            this.AddPlayers.Text = "Add Characters";
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
            // classInput
            // 
            this.classInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.classInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classInput.CausesValidation = false;
            this.classInput.ContextMenuStrip = this.ClassMenu;
            this.classInput.DetectUrls = false;
            this.classInput.ForeColor = System.Drawing.Color.White;
            this.classInput.Location = new System.Drawing.Point(12, 82);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(275, 151);
            this.classInput.TabIndex = 2;
            this.classInput.Text = "";
            // 
            // ClassMenu
            // 
            this.ClassMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.removeClassToolStripMenuItem,
            this.addClassToCharacterToolStripMenuItem});
            this.ClassMenu.Name = "ClassMenu";
            this.ClassMenu.Size = new System.Drawing.Size(205, 70);
            this.ClassMenu.Text = "Class Options";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addNewToolStripMenuItem.Text = "Add New Class";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // removeClassToolStripMenuItem
            // 
            this.removeClassToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classOptionsMenu,
            this.removeToolStripMenuItem});
            this.removeClassToolStripMenuItem.Name = "removeClassToolStripMenuItem";
            this.removeClassToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
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
            // addClassToCharacterToolStripMenuItem
            // 
            this.addClassToCharacterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClasses,
            this.addToolStripMenuItem});
            this.addClassToCharacterToolStripMenuItem.Name = "addClassToCharacterToolStripMenuItem";
            this.addClassToCharacterToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addClassToCharacterToolStripMenuItem.Text = "Add Class To Character...";
            // 
            // addClasses
            // 
            this.addClasses.Name = "addClasses";
            this.addClasses.Size = new System.Drawing.Size(121, 23);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // CharacterClassLbl
            // 
            this.CharacterClassLbl.AutoSize = true;
            this.CharacterClassLbl.BackColor = System.Drawing.Color.Black;
            this.CharacterClassLbl.ForeColor = System.Drawing.Color.White;
            this.CharacterClassLbl.Location = new System.Drawing.Point(9, 65);
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
            this.RemoveCharacterTbPg.Size = new System.Drawing.Size(768, 400);
            this.RemoveCharacterTbPg.TabIndex = 1;
            this.RemoveCharacterTbPg.Text = "Remove Character";
            // 
            // DevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.devTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevForm";
            this.Text = "DevForm";
            this.devTabs.ResumeLayout(false);
            this.AddPlayers.ResumeLayout(false);
            this.AddPlayers.PerformLayout();
            this.ClassMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl devTabs;
        private System.Windows.Forms.TabPage AddPlayers;
        private System.Windows.Forms.Label charNameLbl;
        private System.Windows.Forms.TabPage RemoveCharacterTbPg;
        private System.Windows.Forms.RichTextBox classInput;
        private System.Windows.Forms.Label CharacterClassLbl;
        private System.Windows.Forms.TextBox characterNameIn;
        private System.Windows.Forms.ContextMenuStrip ClassMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox classOptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem addClassToCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox addClasses;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}