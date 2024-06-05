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
        public Ability Ability { get; set; } = new(); 
        
        public AbilityPopup()
        {
            InitializeComponent();
            SetupUI();
        }

        public AbilityPopup(PopupType popupType, AbilityType type)
        {
            InitializeComponent();
            this.Ability.Type = type;
            SetupUI(); 
        }

        public AbilityPopup(PopupType popupType, Ability ability)
        {
            InitializeComponent();
            if (popupType == PopupType.Edit)
            {
                this.Ability = ability;
                // Display all of the attributes of the ability
                this.abilityName.Text = ability.Name;
                this.AbilityDescription.Text = ability.Description;

            }
            SetupUI(); 
        }

        private void SetupUI()
        {
            
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
