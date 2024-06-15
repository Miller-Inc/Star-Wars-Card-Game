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
using System.Windows.Forms.VisualStyles;

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

            classInput.Items.Clear();
            classInput.Items.AddRange(Backend.Game.Classes.ClassNames.ToArray());
            this.classInput.Visible = false;
            this.CharacterClassLbl.Visible = false;
            this.healAlgnLbl.Visible = false;
            this.HealingAlignmentBox.Visible = false;
            this.CharacterIptTreeView.Nodes.Clear();
            this.CharacterIptTreeView.Visible = false;
            this.CharHealLbl.Visible = false;
            this.dmgClassLbl.Visible = false;
            this.dmgClassIpt.Visible = false;
            this.algnLblDmg.Visible = false;
            this.dmgAlgnIpt.Visible = false;
            this.dmgCharIpt.Visible = false;
            this.charIptLblDmg.Visible = false;
            this.dmgCharIpt.Nodes.Clear();
            this.stn_ClassLbl.Visible = false;
            this.stn_ClassListBox.Visible = false;
            this.stn_AlignDropDown.Visible = false;
            this.stn_AlignLbl.Visible = false;
            this.stn_CharTreeView.Visible = false;
            this.stn_CharLbl.Visible = false;
            this.stn_CharTreeView.Nodes.Clear();
            this.stn_ClassListBox.Items.Clear();
            this.stn_ClassListBox.Items.AddRange(Backend.Game.Classes.ClassNames.ToArray());
            if (type == PopupType.Add)
            {
                // Setup a clear UI
                this.affectOptionsTabControl.SelectedIndex = 0;
                this.effectCheckBox.SetItemChecked(0, true);
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
                        HealUpdate();
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

        private void ResetAlliedNodes()
        {
            this.unitsChooser.Nodes[0].Checked = false;
            this.unitsChooser.Nodes[0].ForeColor = Color.White;
            foreach (TreeNode node in this.unitsChooser.Nodes[0].Nodes)
            {
                node.Checked = false;
                node.ForeColor = Color.White;
            }
        }

        private void ResetEnemyNodes()
        {
            this.unitsChooser.Nodes[1].Checked = false;
            this.unitsChooser.Nodes[1].ForeColor = Color.White;
            foreach (TreeNode node in this.unitsChooser.Nodes[1].Nodes)
            {
                node.Checked = false;
                node.ForeColor = Color.White;
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
            HealUpdate();
        }
        private void HealUpdate()
        {
            ResetAlliedNodes();
            Color color = Color.White;
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[1])) color = Color.Yellow;
            else { return; }
            switch (this.affectedAlies.SelectedIndex)
            {
                case 0:
                    // Selected Ally
                    this.classInput.Visible = false;
                    this.CharacterClassLbl.Visible = false;
                    this.healAlgnLbl.Visible = false;
                    this.HealingAlignmentBox.Visible = false;
                    this.CharacterIptTreeView.Visible = false;
                    this.CharHealLbl.Visible = false;
                    ResetAlliedNodes();
                    this.unitsChooser.Nodes[0].Nodes[3].ForeColor = color;
                    break;
                case 1:
                    // All Allies
                    this.CharacterIptTreeView.Visible = false;
                    this.CharHealLbl.Visible = false;
                    this.classInput.Visible = false;
                    this.CharacterClassLbl.Visible = false;
                    this.healAlgnLbl.Visible = false;
                    this.HealingAlignmentBox.Visible = false;
                    this.unitsChooser.Nodes[0].Checked = true;
                    this.unitsChooser.Nodes[0].ForeColor = color;
                    foreach (TreeNode node in this.unitsChooser.Nodes[0].Nodes)
                    {
                        node.Checked = true;
                        node.ForeColor = color;
                    }
                    break;
                case 2:
                    // Self
                    this.CharacterIptTreeView.Visible = false;
                    this.CharHealLbl.Visible = false;
                    this.classInput.Visible = false;
                    this.CharacterClassLbl.Visible = false;
                    this.healAlgnLbl.Visible = false;
                    this.HealingAlignmentBox.Visible = false;
                    ResetAlliedNodes();
                    this.unitsChooser.Nodes[0].Nodes[1].ForeColor = color;
                    this.unitsChooser.Nodes[0].Nodes[1].Checked = true;
                    break;
                case 3:
                    // Allied Leader
                    this.CharacterIptTreeView.Visible = false;
                    this.CharHealLbl.Visible = false;
                    this.classInput.Visible = false;
                    this.CharacterClassLbl.Visible = false;
                    this.healAlgnLbl.Visible = false;
                    this.HealingAlignmentBox.Visible = false;
                    ResetAlliedNodes();
                    this.unitsChooser.Nodes[0].Nodes[0].ForeColor = color;
                    break;
                case 4:
                    // Specific Character(s)
                    this.CharacterIptTreeView.Visible = true;
                    this.CharHealLbl.Visible = true;
                    this.classInput.Visible = false;
                    this.CharacterClassLbl.Visible = false;
                    this.healAlgnLbl.Visible = false;
                    this.HealingAlignmentBox.Visible = false;
                    ResetAlliedNodes();
                    this.unitsChooser.Nodes[0].Nodes[2].ForeColor = color;
                    break;
                case 5:
                    // Specific Faction(s)
                    this.CharacterIptTreeView.Visible = false;
                    this.CharHealLbl.Visible = false;
                    this.classInput.Visible = true;
                    this.CharacterClassLbl.Visible = true;
                    this.healAlgnLbl.Visible = false;
                    this.HealingAlignmentBox.Visible = false;
                    ResetAlliedNodes();
                    this.unitsChooser.Nodes[0].Nodes[2].ForeColor = color;
                    break;
                case 6:
                    // Specific Allignment(s)
                    this.CharacterIptTreeView.Visible = false;
                    this.CharHealLbl.Visible = false;
                    this.classInput.Visible = false;
                    this.CharacterClassLbl.Visible = false;
                    this.healAlgnLbl.Visible = true;
                    this.HealingAlignmentBox.Visible = true;
                    ResetAlliedNodes();
                    this.unitsChooser.Nodes[0].Nodes[2].ForeColor = color;
                    break;

            }
        }
        private void DmgUpdate()
        {
            ResetEnemyNodes();
            Color color = Color.White;
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[0])) color = Color.Yellow;
            switch (this.damageTarget.SelectedIndex)
            {
                // Leader
                // Selected Enemy 
                // Specific Character(s)

                // Selected Enemy
                // All Enemies
                // Random Enemy (no)
                // Enemy Leader
                case 0:
                    // Selected Enemy
                    this.dmgClassLbl.Visible = false;
                    this.dmgClassIpt.Visible = false;
                    this.algnLblDmg.Visible = false;
                    this.dmgAlgnIpt.Visible = false;
                    this.dmgCharIpt.Visible = false;
                    this.charIptLblDmg.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[1].ForeColor = color;
                    break;
                case 1:
                    // All Enemies
                    this.dmgClassLbl.Visible = false;
                    this.dmgClassIpt.Visible = false;
                    this.algnLblDmg.Visible = false;
                    this.dmgAlgnIpt.Visible = false;
                    this.dmgCharIpt.Visible = false;
                    this.charIptLblDmg.Visible = false;
                    this.unitsChooser.Nodes[1].Checked = true;
                    this.unitsChooser.Nodes[1].ForeColor = color;
                    foreach (TreeNode node in this.unitsChooser.Nodes[1].Nodes)
                    {
                        node.Checked = true;
                        node.ForeColor = color;
                    }
                    break;
                case 9:
                    // Was set to Random Enemy, but no longer exists
                    this.dmgClassLbl.Visible = false;
                    this.dmgClassIpt.Visible = false;
                    this.algnLblDmg.Visible = false;
                    this.dmgAlgnIpt.Visible = false;
                    this.dmgCharIpt.Visible = false;
                    this.charIptLblDmg.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[1].ForeColor = color;
                    this.unitsChooser.Nodes[1].Nodes[1].Checked = true;
                    break;
                case 2:
                    // Enemy Leader
                    this.dmgClassLbl.Visible = false;
                    this.dmgClassIpt.Visible = false;
                    this.algnLblDmg.Visible = false;
                    this.dmgAlgnIpt.Visible = false;
                    this.dmgCharIpt.Visible = false;
                    this.charIptLblDmg.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[0].ForeColor = color;
                    break;
                case 3:
                    // Specific Character(s)
                    this.dmgClassLbl.Visible = false;
                    this.dmgClassIpt.Visible = false;
                    this.algnLblDmg.Visible = false;
                    this.dmgAlgnIpt.Visible = false;
                    this.dmgCharIpt.Visible = true;
                    this.charIptLblDmg.Visible = true;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;
                case 4:
                    // Specific Faction(s)
                    this.dmgClassLbl.Visible = true;
                    this.dmgClassIpt.Visible = true;
                    this.algnLblDmg.Visible = false;
                    this.dmgAlgnIpt.Visible = false;
                    this.dmgCharIpt.Visible = false;
                    this.charIptLblDmg.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;
                case 5:
                    // Specific Allignment(s)
                    this.dmgClassLbl.Visible = false;
                    this.dmgClassIpt.Visible = false;
                    this.algnLblDmg.Visible = true;
                    this.dmgAlgnIpt.Visible = true;
                    this.dmgCharIpt.Visible = false;
                    this.charIptLblDmg.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;

            }
        }

        private void StnUpdate()
        {
            ResetEnemyNodes();
            Color color = Color.White;
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[2])) color = Color.Yellow;
            switch (this.stn_AffEnemies.SelectedIndex)
            {
                // Leader
                // Selected Enemy 
                // Specific Character(s)

                // Selected Enemy
                // All Enemies
                // Random Enemy (no)
                // Enemy Leader
                case 0:
                    // Selected Enemy
                    this.stn_ClassLbl.Visible = false;
                    this.stn_ClassListBox.Visible = false;
                    this.stn_AlignDropDown.Visible = false;
                    this.stn_AlignLbl.Visible = false;
                    this.stn_CharTreeView.Visible = false;
                    this.stn_CharLbl.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[1].ForeColor = color;
                    break;
                case 1:
                    // All Enemies
                    this.stn_ClassLbl.Visible = false;
                    this.stn_ClassListBox.Visible = false;
                    this.stn_AlignDropDown.Visible = false;
                    this.stn_AlignLbl.Visible = false;
                    this.stn_CharTreeView.Visible = false;
                    this.stn_CharLbl.Visible = false;
                    this.unitsChooser.Nodes[1].Checked = true;
                    this.unitsChooser.Nodes[1].ForeColor = color;
                    foreach (TreeNode node in this.unitsChooser.Nodes[1].Nodes)
                    {
                        node.Checked = true;
                        node.ForeColor = color;
                    }
                    break;
                case 9:
                    // Was set to Random Enemy, but no longer exists
                    this.stn_ClassLbl.Visible = false;
                    this.stn_ClassListBox.Visible = false;
                    this.stn_AlignDropDown.Visible = false;
                    this.stn_AlignLbl.Visible = false;
                    this.stn_CharTreeView.Visible = false;
                    this.stn_CharLbl.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[1].ForeColor = color;
                    this.unitsChooser.Nodes[1].Nodes[1].Checked = true;
                    break;
                case 2:
                    // Enemy Leader
                    this.stn_ClassLbl.Visible = false;
                    this.stn_ClassListBox.Visible = false;
                    this.stn_AlignDropDown.Visible = false;
                    this.stn_AlignLbl.Visible = false;
                    this.stn_CharTreeView.Visible = false;
                    this.stn_CharLbl.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[0].ForeColor = color;
                    break;
                case 3:
                    // Specific Character(s)
                    this.stn_ClassLbl.Visible = false;
                    this.stn_ClassListBox.Visible = false;
                    this.stn_AlignDropDown.Visible = false;
                    this.stn_AlignLbl.Visible = false;
                    this.stn_CharTreeView.Visible = true;
                    this.stn_CharLbl.Visible = true;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;
                case 4:
                    // Specific Faction(s)
                    this.stn_ClassLbl.Visible = true;
                    this.stn_ClassListBox.Visible = true;
                    this.stn_AlignDropDown.Visible = false;
                    this.stn_AlignLbl.Visible = false;
                    this.stn_CharTreeView.Visible = false;
                    this.stn_CharLbl.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;
                case 5:
                    // Specific Allignment(s)
                    this.stn_ClassLbl.Visible = false;
                    this.stn_ClassListBox.Visible = false;
                    this.stn_AlignDropDown.Visible = true;
                    this.stn_AlignLbl.Visible = true;
                    this.stn_CharTreeView.Visible = false;
                    this.stn_CharLbl.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;

            }
        }

        private void addCharBttn_Click(object sender, EventArgs e)
        {
            this.CharacterIptTreeView.Nodes.Add(this.healCharIpt.Text);
            this.healCharIpt.Text = "";
        }

        private void rmvSelCharBttn_Click(object sender, EventArgs e)
        {
            this.CharacterIptTreeView.Nodes.Remove(this.CharacterIptTreeView.SelectedNode);
        }

        private void damageTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            DmgUpdate();
        }

        private void addCharDmg_Click(object sender, EventArgs e)
        {
            this.dmgCharIpt.Nodes.Add(this.dmgCharIpt.Text);
            this.dmgCharIpt.Text = "";
        }

        private void removeChar_Click(object sender, EventArgs e)
        {
            this.dmgCharIpt.Nodes.Remove(this.dmgCharIpt.SelectedNode);
        }

        private void effectCheckBox_MouseLeave(object sender, EventArgs e)
        {
            HealUpdate(); 
            DmgUpdate();
            StnUpdate(); 
        }

        private void stn_AddCharBttn_Click(object sender, EventArgs e)
        {
            this.stn_CharTreeView.Nodes.Add(this.stn_CharNmTextBox.Text);
            this.stn_CharNmTextBox.Text = "";
        }

        private void stn_RmCharBttn_Click(object sender, EventArgs e)
        {
            this.stn_CharTreeView.Nodes.Remove(this.stn_CharTreeView.SelectedNode);
        }

        private void stn_AffEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            StnUpdate();
        }
    }

    public enum PopupType
    {
        Add,
        Edit
    }


}
