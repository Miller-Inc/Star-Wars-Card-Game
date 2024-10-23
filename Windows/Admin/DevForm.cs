using Star_Wars_Card_Game.Backend.Game;
using Star_Wars_Card_Game.Windows.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Star_Wars_Card_Game.Backend.Game.Enums;

namespace Star_Wars_Card_Game.Windows
{

    

    public partial class DevForm : Form
    {
        public List<Ability> Abilities = [new Ability() { Actions = [new AbilityAction() { AffectedCharacters = CharactersAffected.TargetEnemy }] }];

        public Character Character = new();

        internal static readonly Bitmap InitialImage = new("Resources/ImageBlank.png");

        public DevForm()
        {
            InitializeComponent();
            LoadUI();
            ResetUI();
        }

        private void ResetUI()
        {
            this.className.Text = "";
            this.CharacterPicture.Image = InitialImage;
        }

        private void LoadUI()
        {
            if (Properties.Settings.Default.ColorPreference == "Dark")
            {
                SetDarkMode();
            }
            else
            {
                SetLightMode();
            }

            // Classes Region

            // Add the class options to the classOptionsMenu
            // Get the classes from the local database
            classOptionsMenu.Items.Clear();
            classInput.Items.Clear();
            classOptionsMenu.Items.AddRange(Backend.Game.Classes.ClassNames.ToArray());

            foreach (var item in Backend.Game.Classes.ClassNames)
            {
                classInput.Items.Add(item, false);
                #if DEBUG
                    Debug.AutoFlush = true;
                    Debug.WriteLine(item);
                #endif

            }

            if (classOptionsMenu.Items.Count > 0)
            {
                classOptionsMenu.SelectedIndex = 0;
            }

            // Alignment Region

            // Add the alignment options to the alignmentOptionsMenu
            alignIpt.Items.Clear();
            alignIpt.Items.AddRange(Enum.GetNames(typeof(Allignment)));
            if (alignIpt.Items.Count > 0)
            {
                alignIpt.SelectedIndex = 0;
            }
        }

        private void SetDarkMode()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.WhiteSmoke;
            
        }

        private void SetLightMode()
        {
            this.BackColor = Color.NavajoWhite; 
            this.ForeColor = Color.Black;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmation confirm = new(); 
            DialogResult result = confirm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                Classes.ClassNames.Remove(classOptionsMenu.Text);          
                Classes.SaveToFile();
                LoadUI();
            }
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add class to the database
            Classes.AddClass(className.Text);
            Classes.SaveToFile();
            this.className.Text = "";
            LoadUI();
        }

        private void CreateAbility(AbilityType type)
        {
            AbilityPopup popup = new(PopupType.Add, type);
            DialogResult result = popup.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Add the ability to the database
                this.Abilities.Add(popup.Ability);
                this.abilitesIptDisplay.Nodes.Add(popup.Ability.Name);
            }
        }


        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAbility(AbilityType.Basic);
        }

        private void editAbilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AbilityPopup popup = new(PopupType.Edit, this.Abilities[this.abilitesIptDisplay.SelectedNode.Index]);
                DialogResult result = popup.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Update the ability in the database
                    this.Abilities[this.abilitesIptDisplay.SelectedNode.Index] = popup.Ability;
                    this.abilitesIptDisplay.Nodes[this.abilitesIptDisplay.SelectedNode.Index].Text = popup.Ability.Name;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please select an ability to edit");
            }
        }

        private void CharacterPicture_Click(object sender, EventArgs e)
        {
            if (this.characterNameIn.Text == "")
            {
                MessageBox.Show("Please enter a name for the character");
                return;
            }
            DialogResult result = this.ChooseImgDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bitmap img = new(this.ChooseImgDlg.FileName);
                Size size = new(350, 350);
                this.CharacterPicture.Image = new Bitmap(img, size);
                string fileName = this.Character.Name + ".bmp";
                string directory = "\\Resources\\";
                string filePath = Program.filePath + directory + fileName;

                if (!System.IO.Directory.Exists(directory))
                {
                    System.IO.Directory.CreateDirectory(directory);
                }

                this.CharacterPicture.Image.Save(filePath);
                this.Character.ImagePath = filePath;
                this.CharacterPicture.Image.Save(Program.filePath + "/Resources/" + fileName);
                this.Character.ImagePath = "Resources/" + fileName;
            }
        }

        private void characterNameIn_TextChanged(object sender, EventArgs e)
        {
            this.Character.Name = characterNameIn.Text;
        }

        private void devButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Newtonsoft.Json.JsonConvert.SerializeObject(this.Abilities[0]));
        }
    }
}
