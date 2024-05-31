using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            classOptionsMenu.Items.AddRange(Backend.Game.Classes.ClassNames.ToArray());
            addClasses.Items.AddRange(Backend.Game.Classes.ClassNames.ToArray());
            if (classOptionsMenu.Items.Count > 0)
            {
                classOptionsMenu.SelectedIndex = 0;
            }
            if (addClasses.Items.Count > 0)
            {
                addClasses.SelectedIndex = 0;
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

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add new class

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.classInput.Text += addClasses.Text + "\n";
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmation confirm = new(); 
            DialogResult result = confirm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.classInput.Text = this.classInput.Text.Replace(classOptionsMenu.Text + "\n", "");
            }
        }
    }
}
