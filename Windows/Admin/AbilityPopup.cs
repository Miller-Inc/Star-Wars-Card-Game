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
            SetupUI(PopupType.Add);
        }

        public AbilityPopup(PopupType popupType, AbilityType type)
        {
            InitializeComponent();
            this.Ability.Type = type;
            SetupUI(popupType); 
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
            SetupUI(popupType); 
        }

        private void SetupUI(PopupType type)
        {
            if (type == PopupType.Add)
            {
                // Setup a clear UI
                this.affectOptionsTabControl.SelectedIndex = 0;
                this.effectCheckBox.SetItemChecked(0, true);
                this.classInput.Visible = false;
                this.CharacterClassLbl.Visible = false;
            }
            else if (type == PopupType.Edit)
            {
                // 
            }
        }

        private void AddAbility_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void effectCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Add the effect to the ability
                switch (e.Index)
                {
                    case 0:
                        // Damage 
                        affectOptionsTabControl.SelectedIndex = 0;
                        break;
                    case 1:
                        // Heal
                        affectOptionsTabControl.SelectedIndex = 1;
                        break;
                    case 2:
                        // Stun
                        affectOptionsTabControl.SelectedIndex = 2;
                        break;
                    case 3:
                        // Buff/Debuff
                        affectOptionsTabControl.SelectedIndex = 3;
                        break;
                    default:
                        break;

                }
            }
            else
            {
                // Remove the effect from the ability
            }
        }

        private void flatRateDmgBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (flatRateDmgBttn.Checked)
            {
                // Set the ability to deal a flat rate of damage
                this.percentageDmgBttn.Checked = false;
            }
            else
            {
                // Set the ability to deal a percentage of the target's health
                this.percentageDmgBttn.Checked = true;
            }
        }

        private void percentageDmgBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (percentageDmgBttn.Checked)
            {
                // Set the ability to deal a percentage of the target's health
                this.flatRateDmgBttn.Checked = false;
            }
            else
            {
                // Set the ability to deal a flat rate of damage
                this.flatRateDmgBttn.Checked = true;
            }
        }

        private void setAmtHealBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (setAmtHealBttn.Checked)
            {
                // Set the ability to heal a set amount
                this.percHealBttn.Checked = false;
            }
            else
            {
                // Set the ability to heal a percentage of the target's health
                this.percHealBttn.Checked = true;
            }
        }

        private void percHealBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (percHealBttn.Checked)
            {
                // Set the ability to heal a percentage of the target's health
                this.setAmtHealBttn.Checked = false;
            }
            else
            {
                // Set the ability to heal a set amount
                this.setAmtHealBttn.Checked = true;
            }
        }

        private void affectedAlies_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                Selected Ally
                All Allies
                Self
                Allied Leader
                Specific Character(s)
                Specific Faction(s)
                Specific Allignment(s)
            */
            switch (this.affectedAlies.SelectedIndex)
            {
                case 0:
                    // Selected Ally
                    break;
                case 1:
                    // All Allies
                    break;
                case 2:
                    // Self
                    break;
                case 3:
                    // Allied Leader
                    break;
                case 4:
                    // Specific Character(s)
                    break;
                case 5:
                    // Specific Faction(s)
                    break;
                case 6: 
                    // Specific Allignment(s)
                    break;

            }
        }
    }

    public enum PopupType
    {
        Add,
        Edit
    }


}
