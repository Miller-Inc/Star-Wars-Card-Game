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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            InitializeDefaults(); 
        }

        private void SetDarkMode()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.WhiteSmoke;
            tabContainer.BackColor = Color.Black;
            tabContainer.ForeColor = Color.WhiteSmoke;
            foreach (TabPage tab in tabContainer.TabPages)
            {
                tab.BackColor = Color.Black;
                tab.ForeColor = Color.WhiteSmoke;
            }

        }

        private void SetLightMode()
        {
            this.tabContainer.BackColor = Color.NavajoWhite; 
            this.tabContainer.ForeColor = Color.Black;
            this.BackColor = Color.NavajoWhite;
            this.ForeColor = Color.Black;
            foreach (TabPage tab in tabContainer.TabPages)
            {
                tab.BackColor = Color.NavajoWhite;
                tab.ForeColor = Color.Black;
            }
        }

        private void SaveDefaults_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColorPreference = this.ColorMode.Text;
            Properties.Settings.Default.DefaultTab = this.defaultPage.SelectedIndex;

            Properties.Settings.Default.IP = this.DefaultIPInput.Text;
            Properties.Settings.Default.Port = ushort.Parse(this.defaultPort.Text);
            Properties.Settings.Default.Username = this.defaultUsername.Text;

            Properties.Settings.Default.Save();
            InitializeDefaults(); 
        }

        private void InitializeDefaults()
        {
            this.tabContainer.SelectTab(Properties.Settings.Default.DefaultTab);
            if (Properties.Settings.Default.ColorPreference == "Dark") SetDarkMode();
            else SetLightMode();

            this.defaultPort.Text = Properties.Settings.Default.Port.ToString();
            this.DefaultIPInput.Text = Properties.Settings.Default.IP;
            this.defaultUsername.Text = Properties.Settings.Default.Username;

            this.defaultPage.Items.Clear();
            foreach (TabPage tab in tabContainer.TabPages)
            {
                this.defaultPage.Items.Add(tab.Text);
            }
            this.defaultPage.SelectedIndex = Properties.Settings.Default.DefaultTab;
            this.ColorMode.SelectedIndex = Properties.Settings.Default.ColorPreference == "Dark" ? 0 : 1;
        }

        private void HostGame_Click(object sender, EventArgs e)
        {
            Program.CurrentForm = OpenForms.Host;
            this.Close();
        }

        private void devButton_Click(object sender, EventArgs e)
        {
            Form form = new DevForm();
            form.Show();
        }
    }
}
