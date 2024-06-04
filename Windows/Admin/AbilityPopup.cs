using Star_Wars_Card_Game.Backend.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Wars_Card_Game.Windows.Admin
{
    public partial class AbilityPopup : Form
    {
        public Ability Ability { get; set; }
        
        public AbilityPopup()
        {
            InitializeComponent();
        }

        public AbilityPopup(PopupType popupType, AbilityType type)
        {
            InitializeComponent();


        }

        public AbilityPopup(PopupType popupType, Ability ability)
        {
            InitializeComponent();
        }

        private void AddAbility_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    public enum PopupType
    {
        Add,
        Edit
    }


}
