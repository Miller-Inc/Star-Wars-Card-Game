using Star_Wars_Card_Game.Backend.Game;
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

namespace Star_Wars_Card_Game.Windows
{
    public partial class DevForm : Form
    {
        public DevForm()
        {
            InitializeComponent();
            LoadUI(); 
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
            // Add the class options to the classOptionsMenu
            // Get the classes from the local database
            classOptionsMenu.Items.Clear();
            classInput.Items.Clear();
            classOptionsMenu.Items.AddRange(Backend.Game.Classes.ClassNames.ToArray());
            this.classInput.Items.Clear();

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
    }
}
