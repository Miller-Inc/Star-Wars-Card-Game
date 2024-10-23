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
using Star_Wars_Card_Game.Backend.Game.Enums;
using System.Windows.Forms.VisualStyles;
using AbilityAction = Star_Wars_Card_Game.Backend.Game.AbilityAction;
using System.Runtime.CompilerServices;

namespace Star_Wars_Card_Game.Windows.Admin
{
    public partial class AbilityPopup : Form
    {

        public Ability Ability { get; set; } = new();

        public CharactersAffected Dmg_AffectedChars { get; set; } = CharactersAffected.None;

        public CharactersAffected Heal_AffectedChars { get; set; } = CharactersAffected.None;

        private static readonly string aboutText =
            "Currently there is no program able to modify the types of buffs that you can create." +
            " This is a feature that will be added in the future. For now, you can only create " +
            "buffs that are pre-built into the game. If you would like to see a list of the buffs " +
            " click the submenu above the about button. ";  
        
        private static readonly string[] buffTypes = [
        
            "Heal Over Time 10%",
            "Damage Over Time 10%",
            "Increase Speed 10%",
            "Increase Attack 10%",
            "Increase Defense 10%",
            "Increase Health 10%",
            "Ability Block 1 turn",
            "Decrease Speed -10%", 
            "Decrease Attack -10%",
            "Decrease Defense -10%",
            "Decrease Health -10%"
        ];
        
        public CharactersAffected Stn_AffectedChars { get; set; } = CharactersAffected.None;

        public AbilityAction BuffAction { get; set; } = new()
            {
                AffectedCharacters = CharactersAffected.None,
                AffectedClasses = [],
                AffectedAllignments = [],
                StatusEffect = new()
                {
                    AffectedStat = AffectedStat.Health,
                    Duration = 0,
                    Amount = 0,
                    ApplicationType = StatusApplicationType.Multiplicative,
                    
                },
                AffectedStatValue = 0,
                AffectedUnits = [], 
                Description = "", 
                Type = ActionType.Heal,
                NumberOfTargets = 0, 
            };

        #region Initialization

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
            this.buff_ClassesLbl.Visible = false;
            this.buff_ClassesSelectorCheckLsBx.Visible = false;
            this.buff_AlignLbl.Visible = false;
            this.buff_AlignDropDown.Visible = false;
            this.buff_UnitsSelector.Visible = true;
            this.buff_UnitsLbl.Visible = true;
            this.stn_CharTreeView.Nodes.Clear();
            this.stn_ClassListBox.Items.Clear();
            this.stn_ClassListBox.Items.AddRange(Backend.Game.Classes.ClassNames.ToArray());
            this.dmgClassIpt.Items.Clear();
            this.dmgClassIpt.Items.AddRange(Backend.Game.Classes.ClassNames.ToArray());
            this.unitsChooser.ExpandAll();
            this.buff_DefaultDropdown.Items.Clear();
            this.buff_DefaultDropdown.Items.AddRange(buffTypes);
            // Set the default types of buffs and debuffs
            this.buff_DefaultDropdown.Items.Clear();
            Type defaultType = typeof(DefaultStatusEffects);
            foreach (var item in defaultType.GetMethods())
            {
                if (item.ReturnType == typeof(StatusEffect))
                {
                    this.buff_DefaultDropdown.Items.Add(item.Name);
                }

            }

            if (this.buff_DefaultDropdown.Items.Count > 0)
            {
                this.buff_DefaultDropdown.SelectedIndex = 0;
            }

            if (type == PopupType.Add)
            {
                // Setup a clear UI
                this.affectOptionsTabControl.SelectedIndex = 0;
                this.effectCheckBox.SetItemChecked(0, true);
            }
            else if (type == PopupType.Edit)
            {
                // set all of the fields to active

                // Set the ability type
                if (this.Ability.Type == AbilityType.Basic)
                {
                    this.main_Cooldown.Visible = false;
                    this.main_CooldownLbl.Visible = false;
                }
                else
                {
                    this.main_Cooldown.Visible = true;
                    this.main_CooldownLbl.Visible = true;
                }

                // Set the ability name and description
                this.abilityName.Enabled = true;
                this.AbilityDescription.Enabled = true;
                this.abilityName.Text = this.Ability.Name;
                this.AbilityDescription.Text = this.Ability.Description;

                // Set the ability type
                switch (this.Ability.Type)
                {
                    case AbilityType.Basic:
                        this.main_AbilityTypeComboBox.SelectedIndex = 0;
                        break;
                    case AbilityType.Special:
                        this.main_AbilityTypeComboBox.SelectedIndex = 1;
                        break;
                    case AbilityType.Ultimate:
                        this.main_AbilityTypeComboBox.SelectedIndex = 2;
                        break;
                }

                // Set the cooldown
                this.main_Cooldown.Value = this.Ability.Cooldown;

                // Set the effects of the ability
                foreach (var item in this.Ability.Actions)
                {
                    switch (item.Type)
                    {
                        // Damage
                        case ActionType.Damage:
                            this.effectCheckBox.SetItemChecked(0, true);
                            this.damageIptAmount.Value = (decimal)this.Ability.BaseAmount;
                            /*
                                0 Selected Enemy
                                1 All Enemies
                                2 Enemy Leader
                                3 Specific Character(s)
                                4 Specific Faction(s) 
                                5 Specific Allignment(s)
                             */

                            switch (item.AffectedCharacters)
                            {
                                case(CharactersAffected.EnemyLeader):
                                    this.damageTarget.SelectedIndex = 2; 
                                    break; 
                                case(CharactersAffected.EnemySpecificClass):
                                    this.damageTarget.SelectedIndex = 4;

                                    // Affected Classes
                                    foreach (var char_class in item.AffectedClasses) 
                                    {
                                        try
                                        {
                                            this.dmgClassIpt.SetItemChecked(this.dmgClassIpt.FindStringExact(char_class.Value), true);
                                        } catch 
                                        {
                                            MessageBox.Show("Internal Error", "Class, " + char_class.Value + " was not found. This error has been handled, but was not included in the list. " +
                                                "To see the class as an available option, go to the previous window and add it then open this window again. ");
                                        }
                                    }

                                    break;
                                case(CharactersAffected.EnemySpecificAllignment):
                                    this.damageTarget.SelectedIndex = 5;

                                    /*
                                     * Light
                                     * Dark
                                     * Neutral 
                                     */

                                    switch (item.AffectedAllignments[0])
                                    {
                                        case(Allignment.LightSide):
                                            this.dmgAlgnIpt.SelectedIndex = 0;
                                            break;
                                        case (Allignment.DarkSide):
                                            this.damageTarget.SelectedIndex = 1;
                                            break;
                                        case (Allignment.Neutral):
                                            this.damageTarget.SelectedIndex = 2;
                                            break;
                                        default: 
                                            this.damageTarget.SelectedIndex = 2;
                                            break;
                                    }

                                    break;
                                case(CharactersAffected.EnemySpecificUnit):
                                    this.damageTarget.SelectedIndex = 3;

                                    foreach (var unit in item.AffectedUnits)
                                    {
                                        this.dmgCharIpt.Nodes.Add(unit.Value);
                                    }

                                    break;
                                case(CharactersAffected.AllEnemies):
                                    this.damageTarget.SelectedIndex = 1; 
                                    this.UpdateChars();
                                    break;
                                case (CharactersAffected.TargetEnemy):
                                    this.damageTarget.SelectedIndex = 0;
                                    break;
                                default: 
                                    this.damageTarget.SelectedIndex = 0;
                                    break;
                            }

                            if (item.ApplicationType == ApplicationType.Additive)
                            {
                                this.flatRateDmgBttn.Checked = true;
                                this.percentageDmgBttn.Checked = false; 
                            }
                            else
                            {
                                this.flatRateDmgBttn.Checked = false;
                                this.percentageDmgBttn.Checked = true; 
                            }

                            

                            break;

                        // Heal
                        case ActionType.Heal:
                            this.effectCheckBox.SetItemChecked(1, true);
                            break;

                        // Stun & Buff/Debuff
                        case ActionType.ModifyStat:
                            switch (item.StatusEffect.ApplicationType)
                            {
                                case StatusApplicationType.LoseTurn:
                                    // Stun 
                                    this.effectCheckBox.SetItemChecked(2, true);
                                    stn_NumberOfTurns.Value = item.StatusEffect.Duration;
                                    /*
                                        0 Selected Enemy 
                                        1 All Enemies
                                        2 Enemy Leader
                                        3 Specific Character(s)
                                        4 Specific Faction(s)
                                        5 Specific Allignment(s)
                                     */

                                    // Work on finishing to this type

                                    switch (item.AffectedCharacters)
                                    {
                                        case (CharactersAffected.EnemyLeader):
                                            this.damageTarget.SelectedIndex = 2;
                                            break;
                                        case (CharactersAffected.EnemySpecificClass):
                                            this.damageTarget.SelectedIndex = 4;
                                            
                                            // Affected Classes
                                            foreach (var char_class in item.AffectedClasses)
                                            {
                                                try
                                                {
                                                    this.dmgClassIpt.SetItemChecked(this.dmgClassIpt.FindString(char_class.Value), true);
                                                }
                                                catch
                                                {
                                                    MessageBox.Show("Internal Error", "Class, " + char_class.Value + 
                                                        " was not found. This error has been handled, but was not included in the list. " +
                                                        "To see the class as an available option, go to the previous window and add it then open this window again. ");
                                                }
                                            }

                                            break;
                                        case (CharactersAffected.EnemySpecificAllignment):
                                            this.damageTarget.SelectedIndex = 5;

                                            /*
                                             * Light
                                             * Dark
                                             * Neutral 
                                            */
                                            
                                            switch (item.AffectedAllignments[0])
                                            {
                                                case (Allignment.LightSide):
                                                    this.dmgAlgnIpt.SelectedIndex = 0;
                                                    break;
                                                case (Allignment.DarkSide):
                                                    this.damageTarget.SelectedIndex = 1;
                                                    break;
                                                case (Allignment.Neutral):
                                                    this.damageTarget.SelectedIndex = 2;
                                                    break;
                                                default:
                                                    this.damageTarget.SelectedIndex = 2;
                                                    break;
                                            }
                                            
                                            break;
                                        case (CharactersAffected.EnemySpecificUnit):
                                            this.damageTarget.SelectedIndex = 3;

                                            foreach (var unit in item.AffectedUnits)
                                            {
                                                this.dmgCharIpt.Nodes.Add(unit.Value);
                                            }

                                            break;
                                        case (CharactersAffected.AllEnemies):
                                            this.damageTarget.SelectedIndex = 1;
                                            break;
                                        case (CharactersAffected.TargetEnemy):
                                            this.damageTarget.SelectedIndex = 0;
                                            break;
                                        case CharactersAffected.None:
                                            MessageBox.Show("Internal Error", "No characters were affected by the stun. This error has been handled, but the stun was not applied. ");
                                            break;
                                        default:
                                            this.damageTarget.SelectedIndex = 0;
                                            break;
                                    }
                                    break;
                                default:
                                    // Buff/Debuff
                                    this.effectCheckBox.SetItemChecked(3, true);
                                    this.BuffAction = item;
                                    /*
                                        0 Self
                                        1 Selected Ally
                                        2 Allied Leader
                                        3 Specific Character(s) (Allies)
                                        4 Specific Faction(s) (Allies)
                                        5 Specific Allignment(s) (Allies)
                                        6 Selected Enemy
                                        7 All Enemies
                                        8 Enemy Leader
                                        9 Specific Character(s) (Enemy)
                                        10 Specific Faction(s) (Enemy)
                                        11 Specific Allignment(s) (Enemy)
                                     */
                                    switch (item.AffectedCharacters)
                                    {
                                        case (CharactersAffected.EnemyLeader):
                                            this.damageTarget.SelectedIndex = 8;
                                            break;
                                        case (CharactersAffected.EnemySpecificClass):
                                            this.damageTarget.SelectedIndex = 10;

                                            // Affected Classes
                                            foreach (var char_class in item.AffectedClasses)
                                            {
                                                try
                                                {
                                                    this.dmgClassIpt.SetItemChecked(this.dmgClassIpt.FindString(char_class.Value), true);
                                                }
                                                catch
                                                {
                                                    MessageBox.Show("Internal Error", "Class, " + char_class.Value +
                                                        ", was not found. This error has been handled, but was not included in the list. " +
                                                        "To see the class as an available option, go to the previous window and add it then " +
                                                        "open this window again. ");
                                                }
                                            }

                                            break;
                                        case (CharactersAffected.EnemySpecificAllignment):
                                            this.damageTarget.SelectedIndex = 11;

                                            /*
                                             * Light
                                             * Dark
                                             * Neutral 
                                             */

                                            // Affected Allignments
                                            foreach (var allignment in item.AffectedAllignments)
                                            {
                                                switch (allignment.Value)
                                                {
                                                    case (Allignment.LightSide):
                                                        this.dmgAlgnIpt.SelectedIndex = 0;
                                                        break;
                                                    case (Allignment.DarkSide):
                                                        this.damageTarget.SelectedIndex = 1;
                                                        break;
                                                    case (Allignment.Neutral):
                                                        this.damageTarget.SelectedIndex = 2;
                                                        break;
                                                    default:
                                                        this.damageTarget.SelectedIndex = 2;
                                                        break;
                                                }
                                            }

                                            break;
                                        case (CharactersAffected.EnemySpecificUnit):
                                            this.damageTarget.SelectedIndex = 9;

                                            foreach (var unit in item.AffectedUnits)
                                            {
                                                this.dmgCharIpt.Nodes.Add(unit.Value);
                                            }

                                            break;
                                        case (CharactersAffected.AllEnemies):
                                            this.damageTarget.SelectedIndex = 7;
                                            break;
                                        case (CharactersAffected.TargetEnemy):
                                            this.damageTarget.SelectedIndex = 6;
                                            break;
                                        case CharactersAffected.None:
                                            MessageBox.Show("Internal Error", "No characters were affected by the stun. This error has been handled, but the stun was not applied. ");
                                            break;
                                        case CharactersAffected.Self:
                                            this.buff_UnitsSelector.SelectedIndex = 0;
                                            break;
                                        case CharactersAffected.TargetAlly:
                                            this.buff_UnitsSelector.SelectedIndex = 1;
                                            break;
                                        case CharactersAffected.AllyLeader:
                                                this.buff_UnitsSelector.SelectedIndex = 2;
                                            break;
                                        case CharactersAffected.AllySpecificUnit:
                                            this.buff_UnitsSelector.SelectedIndex = 3;

                                            foreach (var unit in item.AffectedUnits)
                                            {
                                                this.stn_CharTreeView.Nodes.Add(unit.Value);
                                            }

                                            break;
                                        case CharactersAffected.AllySpecificClass:
                                            this.buff_UnitsSelector.SelectedIndex = 4;

                                            foreach (var char_class in item.AffectedClasses)
                                            {
                                                try
                                                {
                                                    this.buff_ClassesSelectorCheckLsBx.SetItemChecked(this.buff_ClassesSelectorCheckLsBx.FindString(char_class.Value), true);
                                                }
                                                catch
                                                {
                                                    MessageBox.Show("Internal Error", "Class, " + char_class.Value +
                                                        ", was not found. This error has been handled, but was not included in the list. " +
                                                        "To see the class as an available option, go to the previous window and add it then " +
                                                                                                                                                                                                                             "open this window again. ");
                                                }
                                            }

                                            break;
                                        case CharactersAffected.AllySpecificAllignment:
                                            this.buff_UnitsSelector.SelectedIndex = 5;

                                            foreach (var alignment in item.AffectedAllignments)
                                            {
                                                switch (alignment.Value)
                                                {
                                                    case Allignment.LightSide:
                                                        this.buff_AlignDropDown.SelectedIndex = 0;
                                                        break;
                                                    case Allignment.DarkSide:
                                                        this.buff_AlignDropDown.SelectedIndex = 1;
                                                        break;
                                                    case Allignment.Neutral:
                                                        this.buff_AlignDropDown.SelectedIndex = 2;
                                                        break;
                                                    case Allignment.Any:
                                                        this.buff_AlignDropDown.SelectedIndex = 3;
                                                        break;
                                                    default:
                                                        this.buff_AlignDropDown.SelectedIndex = 2;
                                                        break;
                                                }
                                            }

                                            break;
                                        default:
                                            this.damageTarget.SelectedIndex = 0;
                                            break;
                                    }

                                    break;
                            }
                            this.effectCheckBox.SetItemChecked(2, true);
                            break;
                        default:
                            break;
                    }
                    this.UpdateChars();
                }
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// In progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAbility_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // Save ability
            this.Ability.Name = this.abilityName.Text;
            this.Ability.Description = this.AbilityDescription.Text;
            this.Ability.Type = (AbilityType)Enum.Parse(typeof(AbilityType), this.main_AbilityTypeComboBox.Text);
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[0]))
            {
                // Damage
                AbilityAction action = new()
                {
                    AffectedCharacters = this.Dmg_AffectedChars,
                    AffectedClasses = [],
                    AffectedAllignments = [],
                    StatusEffect = new()
                    {
                        AffectedStat = AffectedStat.Health,
                        Duration = 0,
                        Amount = 0,
                        ApplicationType = StatusApplicationType.Multiplicative,
                    },
                    AffectedStatValue = 0,
                    AffectedUnits = [],
                    Description = "",
                    Type = ActionType.Damage,
                    NumberOfTargets = 0,
                };

                if (this.dmgClassIpt.Visible)
                {
                    foreach (int item in this.dmgClassIpt.CheckedIndices)
                    {
                        action.AffectedClasses.Add(item, this.dmgClassIpt.Items[item].ToString());
                    }
                }
                this.Ability.BaseAmount = (float)this.damageIptAmount.Value;
            }
            if (this.main_AbilityTypeComboBox.Text == "Basic")
            {
                this.Ability.Cooldown = 0;
            }
            else
            {
                this.Ability.Cooldown = (int)this.main_Cooldown.Value;
            }
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[3]))
            {
                // buff/debuff
                this.Ability.Actions.Add(this.BuffAction);
            }

            
            

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
                        //HealUpdate();
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
            UpdateChars();
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
            UpdateChars(); 
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
            UpdateChars();
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
            //HealUpdate();
            UpdateChars();
        }

        private void buff_Perc_CheckedChanged(object sender, EventArgs e)
        {
            this.buff_SetAmt.Checked = !this.buff_Perc.Checked;
        }

        private void buff_SetAmt_CheckedChanged(object sender, EventArgs e)
        {
            this.buff_Perc.Checked = !this.buff_SetAmt.Checked;
        }

        #endregion

        #region Update UI

        private void UpdateChars()
        {
            // Update UIs based on the selected effect
            HealUpdate();
            DmgUpdate();
            StnUpdate();
            buff_Hide();

            // Reset the colors of the nodes since the effect has changed
            ResetEnemyNodes();
            ResetAlliedNodes();

            // Check Damage Page 
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[0]))
            {
                switch (this.damageTarget.SelectedIndex)
                {
                    case 0:
                        // Selected Enemy
                        HighlightChars(CharactersAffected.TargetEnemy);
                        Dmg_AffectedChars = CharactersAffected.TargetEnemy;
                        break;
                    case 1:
                        // All Enemies
                        HighlightChars(CharactersAffected.AllEnemies);
                        Dmg_AffectedChars = CharactersAffected.AllEnemies;
                        break;
                    case 2:
                        // Enemy Leader
                        HighlightChars(CharactersAffected.EnemyLeader);
                        Dmg_AffectedChars = CharactersAffected.EnemyLeader;
                        break;
                    case 3:
                        // Specific Character(s)
                        HighlightChars(CharactersAffected.EnemySpecificUnit);
                        Dmg_AffectedChars = CharactersAffected.EnemySpecificUnit;
                        break;
                    case 4:
                        // Specific Faction(s)
                        HighlightChars(CharactersAffected.EnemySpecificClass);
                        Dmg_AffectedChars = CharactersAffected.EnemySpecificClass;
                        break;
                    case 5:
                        // Specific Allignment(s)
                        HighlightChars(CharactersAffected.EnemySpecificAllignment);
                        Dmg_AffectedChars = CharactersAffected.EnemySpecificAllignment;
                        break;
                }
            }

            // Check Stun Page
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[2]))
            {
                switch (this.stn_AffEnemies.SelectedIndex)
                {
                    case 0:
                        // Selected Enemy
                        HighlightChars(CharactersAffected.TargetEnemy);
                        Stn_AffectedChars = CharactersAffected.TargetEnemy;
                        break;
                    case 1:
                        // All Enemies
                        HighlightChars(CharactersAffected.AllEnemies);
                        Stn_AffectedChars = CharactersAffected.AllEnemies;
                        break;
                    case 2:
                        // Enemy Leader
                        HighlightChars(CharactersAffected.EnemyLeader);
                        Stn_AffectedChars = CharactersAffected.EnemyLeader;
                        break;
                    case 3:
                        // Specific Character(s)
                        HighlightChars(CharactersAffected.EnemySpecificUnit);
                        Stn_AffectedChars = CharactersAffected.EnemySpecificUnit;
                        break;
                    case 4:
                        // Specific Faction(s)
                        HighlightChars(CharactersAffected.EnemySpecificClass);
                        Stn_AffectedChars = CharactersAffected.EnemySpecificClass;
                        break;
                    case 5:
                        // Specific Allignment(s)
                        HighlightChars(CharactersAffected.EnemySpecificAllignment);
                        Stn_AffectedChars = CharactersAffected.EnemySpecificAllignment;
                        break;
                }
            }   

            // Check Heal Page
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[1]))
            {
                switch (this.affectedAlies.SelectedIndex)
                {
                    case 0:
                        // Selected Ally
                        HighlightChars(CharactersAffected.TargetAlly);
                        Heal_AffectedChars = CharactersAffected.TargetAlly;
                        break;
                    case 1:
                        // All Allies
                        HighlightChars(CharactersAffected.AllAllies);
                        Heal_AffectedChars = CharactersAffected.AllAllies;
                        break;
                    case 2:
                        // Self
                        HighlightChars(CharactersAffected.Self);
                        Heal_AffectedChars = CharactersAffected.Self;
                        break;
                    case 3:
                        // Allied Leader
                        HighlightChars(CharactersAffected.AllyLeader);
                        Heal_AffectedChars = CharactersAffected.AllyLeader;
                        break;
                    case 4:
                        // Specific Character(s)
                        HighlightChars(CharactersAffected.AllySpecificUnit);
                        Heal_AffectedChars = CharactersAffected.AllySpecificUnit;
                        break;
                    case 5:
                        // Specific Faction(s)
                        HighlightChars(CharactersAffected.AllySpecificClass);
                        Heal_AffectedChars = CharactersAffected.AllySpecificClass;
                        break;
                    case 6:
                        // Specific Allignment(s)
                        HighlightChars(CharactersAffected.AllySpecificAllignment);
                        Heal_AffectedChars = CharactersAffected.AllySpecificAllignment;
                        break;
                }
            }

            // Check Buff/Debuff Page
            // In Progress
            if (this.effectCheckBox.CheckedIndices.Contains(3))
            {
                // In Progress
                /*
                    Self
                    Selected Ally
                    Allied Leader
                    Specific Character(s) (Allies)
                    Specific Faction(s) (Allies)
                    Specific Allignment(s) (Allies)
                    Selected Enemy
                    All Enemies
                    Enemy Leader
                    Specific Character(s) (Enemy)
                    Specific Faction(s) (Enemy)
                    Specific Allignment(s) (Enemy)
                */
                switch (this.buff_UnitsSelector.SelectedIndex)
                {
                    case 0:
                        // Self
                        HighlightChars(CharactersAffected.Self);
                        
                        break;
                    case 1:
                        // Selected Ally
                        HighlightChars(CharactersAffected.TargetAlly);
                        break;
                    case 2:
                        // Allied Leader
                        HighlightChars(CharactersAffected.AllyLeader);
                        break;
                    case 3:
                        // Specific Character(s) (Allies)
                        HighlightChars(CharactersAffected.AllySpecificUnit);

                        break;
                    case 4:
                        // Specific Faction(s) (Allies)
                        HighlightChars(CharactersAffected.AllySpecificClass);
                        break;
                    case 5:
                        // Specific Allignment(s) (Allies)
                        HighlightChars(CharactersAffected.AllySpecificAllignment);
                        break;
                    case 6:
                        // Selected Enemy
                        HighlightChars(CharactersAffected.TargetEnemy);
                        break;
                    case 7:
                        // All Enemies
                        HighlightChars(CharactersAffected.AllEnemies);
                        break;
                    case 8:
                        // Enemy Leader
                        HighlightChars(CharactersAffected.EnemyLeader);
                        break;
                    case 9:
                        // Specific Character(s) (Enemy)
                        HighlightChars(CharactersAffected.EnemySpecificUnit);
                        break;
                    case 10:
                        // Specific Faction(s) (Enemy)
                        HighlightChars(CharactersAffected.EnemySpecificClass);
                        break;
                    case 11:
                        // Specific Allignment(s) (Enemy)
                        HighlightChars(CharactersAffected.EnemySpecificAllignment);
                        break;
                }
            }

        }

        /// <summary>
        /// Highlights the characters that are affected by the ability
        /// </summary>
        /// <param name="a_char">the specific character that is affected by an ability</param>
        private void HighlightChars(CharactersAffected a_char)
        {
            switch (a_char)
            {
                case CharactersAffected.Self:
                    this.unitsChooser.Nodes[0].Nodes[1].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.TargetAlly:
                    this.unitsChooser.Nodes[0].Nodes[3].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.TargetEnemy:
                    this.unitsChooser.Nodes[1].Nodes[1].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.AllAllies:
                    this.unitsChooser.Nodes[0].ForeColor = Color.Yellow;
                    foreach (TreeNode node in this.unitsChooser.Nodes[0].Nodes)
                    {
                        node.ForeColor = Color.Yellow;
                    }
                    break;
                case CharactersAffected.AllEnemies:
                    this.unitsChooser.Nodes[1].ForeColor = Color.Yellow;
                    foreach (TreeNode node in this.unitsChooser.Nodes[1].Nodes)
                    {
                        node.ForeColor = Color.Yellow;
                    }
                    break;
                case CharactersAffected.All:
                    this.unitsChooser.Nodes[0].ForeColor = Color.Yellow;
                    foreach (TreeNode node in this.unitsChooser.Nodes[0].Nodes)
                    {
                        node.ForeColor = Color.Yellow;
                    }
                    this.unitsChooser.Nodes[1].ForeColor = Color.Yellow;
                    foreach (TreeNode node in this.unitsChooser.Nodes[1].Nodes)
                    {
                        node.ForeColor = Color.Yellow;
                    }
                    break;
                case CharactersAffected.EnemyLeader:
                    this.unitsChooser.Nodes[1].Nodes[0].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.AllyLeader:
                    this.unitsChooser.Nodes[0].Nodes[0].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.AllySpecificClass:
                    this.unitsChooser.Nodes[0].Nodes[2].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.AllySpecificUnit:
                    this.unitsChooser.Nodes[0].Nodes[2].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.AllySpecificAllignment:
                    this.unitsChooser.Nodes[0].Nodes[2].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.EnemySpecificClass:
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.EnemySpecificUnit:
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = Color.Yellow;
                    break;
                case CharactersAffected.EnemySpecificAllignment:
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = Color.Yellow;
                    break;

            }
        }

        /// <summary>
        /// Turns all of the allied nodes white
        /// </summary>
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

        /// <summary>
        /// Turns all of the enemy nodes white
        /// </summary>
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

        /// <summary>
        /// Outdated method, use UpdateChars() instead; Used to update the UI based on the selected effect
        /// </summary>
        internal void HealUpdate()
        {
            //ResetAlliedNodes();
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

        /// <summary>
        /// Outdated method, use UpdateChars() instead; Used to update the UI based on the selected effect
        /// </summary>
        internal void DmgUpdate()
        {
            //ResetEnemyNodes();
            Color color = Color.White;
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[0])) color = Color.Yellow;
            else { return; }
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

        /// <summary>
        /// Outdated method, use UpdateChars() instead; Used to update the UI based on the selected effect
        /// </summary>
        internal void StnUpdate()
        {
            //ResetEnemyNodes();
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
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;

            }
        }

        /// <summary>
        ///  Hides all of the buff UI elements
        /// </summary>
        private void buff_Hide()
        {
            buff_ClassesLbl.Visible = false;
            buff_ClassesSelectorCheckLsBx.Visible = false;
            buff_AlignLbl.Visible = false;
            buff_AlignDropDown.Visible = false;
            buff_CharsTreeView.Visible = false;
            buff_CharsLbl.Visible = false;
        }

        /// <summary>
        /// Changes the UI based on the selected effect of the ability
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buff_UnitsSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                Self
                Selected Ally
                Allied Leader
                Specific Character(s) (Allies)
                Specific Faction(s) (Allies)
                Specific Allignment(s) (Allies)
                Selected Enemy
                All Enemies
                Enemy Leader
                Specific Character(s) (Enemy)
                Specific Faction(s) (Enemy)
                Specific Allignment(s) (Enemy)
             */
            buff_Hide();
            //ResetEnemyNodes();
            Color color = Color.White;
            if (this.effectCheckBox.CheckedItems.Contains(this.effectCheckBox.Items[0])) color = Color.Yellow;
            else { return; }
            switch (this.buff_UnitsSelector.SelectedIndex)
            {
                case 0:
                    // Self
                    break;
                case 1:
                    // Selected Ally
                    break;
                case 2:
                    // Allied Leader
                    break;
                case 3:
                    // Specific Character(s) (Allies)
                    break;
                case 4:
                    // Specific Faction(s) (Allies)
                    break;
                case 5:
                    // Specific Allignment(s) (Allies)
                    break;
                case 6:
                    // Selected Enemy
                    this.buff_ClassesLbl.Visible = false;
                    this.buff_ClassesSelectorCheckLsBx.Visible = false;
                    this.buff_AlignLbl.Visible = false;
                    this.buff_AlignDropDown.Visible = false;
                    this.buff_CharsLbl.Visible = false;
                    this.buff_CharsTreeView.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[1].ForeColor = color;
                    break;
                case 7:
                    // All Enemies
                    this.buff_ClassesLbl.Visible = false;
                    this.buff_ClassesSelectorCheckLsBx.Visible = false;
                    this.buff_AlignLbl.Visible = false;
                    this.buff_AlignDropDown.Visible = false;
                    this.buff_CharsLbl.Visible = false;
                    this.buff_CharsTreeView.Visible = false;
                    this.unitsChooser.Nodes[1].Checked = true;
                    this.unitsChooser.Nodes[1].ForeColor = color;
                    foreach (TreeNode node in this.unitsChooser.Nodes[1].Nodes)
                    {
                        node.Checked = true;
                        node.ForeColor = color;
                    }
                    break;
                case 8:
                    // Enemy Leader
                    this.buff_ClassesLbl.Visible = false;
                    this.buff_ClassesSelectorCheckLsBx.Visible = false;
                    this.buff_AlignLbl.Visible = false;
                    this.buff_AlignDropDown.Visible = false;
                    this.buff_CharsLbl.Visible = false;
                    this.buff_CharsTreeView.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[0].ForeColor = color;
                    break;
                case 9:
                    // Specific Character(s) (Enemy)
                    this.buff_ClassesLbl.Visible = false;
                    this.buff_ClassesSelectorCheckLsBx.Visible = false;
                    this.buff_AlignLbl.Visible = false;
                    this.buff_AlignDropDown.Visible = false;
                    this.buff_CharsLbl.Visible = true;
                    this.buff_CharsTreeView.Visible = true;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;
                case 10:
                    // Specific Faction(s) (Enemy)
                    this.buff_ClassesLbl.Visible = true;
                    this.buff_ClassesSelectorCheckLsBx.Visible = true;
                    this.buff_AlignLbl.Visible = false;
                    this.buff_AlignDropDown.Visible = false;
                    this.buff_CharsLbl.Visible = false;
                    this.buff_CharsTreeView.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;
                case 11:
                    // Specific Allignment(s) (Enemy)
                    this.buff_ClassesLbl.Visible = false;
                    this.buff_ClassesSelectorCheckLsBx.Visible = false;
                    this.buff_AlignLbl.Visible = true;
                    this.buff_AlignDropDown.Visible = true;
                    this.buff_CharsLbl.Visible = false;
                    this.buff_CharsTreeView.Visible = false;
                    ResetEnemyNodes();
                    this.unitsChooser.Nodes[1].Nodes[2].ForeColor = color;
                    break;
            }
            UpdateChars();
        }
        #endregion

        private void main_AbilityTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.main_AbilityTypeComboBox.SelectedIndex)
            {
                case 0:
                    // Basic
                    this.main_Cooldown.Value = 0;
                    this.main_Cooldown.ReadOnly = true;
                    break;
                case 1:
                    // Special
                    this.main_Cooldown.Value = 1;
                    this.main_Cooldown.ReadOnly = false;
                    break;
                case 2:
                    // Ultimate
                    this.main_Cooldown.Value = 3;
                    this.main_Cooldown.ReadOnly = false;
                    break;
                case 3:
                    // Passive
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aboutText, "About");
        }

        private void buff_DropdownPreBuilt_Click(object sender, EventArgs e)
        {
            // TODO: Figure out what to do with this buff dropdown
        }

        private void buff_confirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (this.buff_DefaultDropdown.SelectedIndex)
            {
                case 0: 
                    // Heal Over Time 10%
                    this.Ability.Actions.Add(new AbilityAction
                    {
                        AffectedCharacters = CharactersAffected.AllAllies,
                        AffectedClasses = [],
                        AffectedAllignments = [],
                        StatusEffect = new StatusEffect
                        {
                            AffectedStat = AffectedStat.Health,
                            Duration = 3,
                            Amount = 1.1f,
                            ApplicationType = StatusApplicationType.Multiplicative,
                        },
                        AffectedStatValue = 0,
                        AffectedUnits = [],
                        Description = "Heals this unit",
                        Type = ActionType.Heal,
                        NumberOfTargets = 1,
                    });
                    break;
                case 1:
                    // Damage Over Time 10%
                    
                    break; 
                case 2: 
                    // Increase Speed 10%
                
                    break;
                case 3:
                    // Increase Attack 10%
                
                    break;
                case 4:
                    // Increase Defense 10%

                    break; 
                case 5:
                    // Increase Health 10%
                
                    break;
                case 6:
                    // Ability Block 1 turn
                
                    break;
                case 7:
                    // Decrease Speed -10%
                
                    break;
                case 8:
                    // Decrease Attack -10%
                    
                    break; 
                case 9: 
                    // Decrease Defense -10%

                    break;
                case 10:
                    // Decrease Health -10%
                
                    break;
                default:
                    MessageBox.Show("Please select a buff from the dropdown", "Error");
                    break; 
                    
            }
        }
    }




}
