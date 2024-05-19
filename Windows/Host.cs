using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Star_Wars_Card_Game.Backend.Server;

namespace Star_Wars_Card_Game.Windows
{
    public partial class Host : Form
    {
        public Host()
        {
            InitializeComponent();
            UpdateDesign(); // Update the design of the form
            RunServer(); // Start the server
        }

        private void UpdateDesign()
        {
            joinGameLocally.ForeColor = Color.Black;
            if (Program.IsDarkMode)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.NavajoWhite;
                this.ConnectionKeyLbl.ForeColor = Color.Yellow;
                this.PlayerOutput.ForeColor = Color.Yellow;
                this.PlayerOutput.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.NavajoWhite;
                this.ForeColor = Color.Black;
                this.ConnectionKeyLbl.ForeColor = Color.Black;
                this.PlayerOutput.ForeColor = Color.Black;
                this.PlayerOutput.BackColor = Color.AntiqueWhite;
            }
        }

        private void RunServer()
        {
            ServerBase.StartServer(Properties.Settings.Default.Port, 6);
            Thread serverThread = new Thread(() => 
            {
                ServerBase.Running = true; 
                while (ServerBase.Running)
                {
                    ServerBase.FixedUpdate();
                    Thread.Sleep(1000 / 60);
                }
            });
            serverThread.Start();
        }

        private void joinGameLocally_Click(object sender, EventArgs e)
        {
            // Open a new form to join the game
        }

    }
}
