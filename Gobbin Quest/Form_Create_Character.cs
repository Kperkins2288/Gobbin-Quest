using Gobbin_Quest.CharacterClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gobbin_Quest
{
    public partial class Form_Create_Character : Form
    {
        public Form_Create_Character()
        {
            InitializeComponent();
        }

        private void button_Save_Char_Click(object sender, EventArgs e)
        {
            //Make sure fields are filled
            if (String.IsNullOrEmpty(text_Name.Text) || text_Name.Text[0] == ' ')
            {
                MessageBox.Show("You must name your Gobbin!");
            }

            if (this.radioButton_Gobbo.Checked == false && this.radioButton_Gobbina.Checked == false && this.radioButton_Gobblyn.Checked == false)
            {
                MessageBox.Show("You must select a gender for your Gobbin! \nIf it helps, Gobblyn is gender neutral.");
            }

            if (String.IsNullOrEmpty(comboBox_Class.Text))
            {
                MessageBox.Show("Your Gobbin must have a class!");
            }

            //create player
            string name = text_Name.Text;
            EntityGender eGender;
            if (this.radioButton_Gobbo.Checked == true)
                eGender = EntityGender.Gobbo;
            else if (this.radioButton_Gobbina.Checked == true)
                eGender = EntityGender.Gobbina;
            else 
                eGender = EntityGender.Gobblyn;
            Mage playerM = new Mage(name, eGender);

            MessageBox.Show("Player Mage has been created.\nGender: " + playerM.Gender.ToString());

            //create mage
            //Mage playerM = new Mage();
            //Warrior playerW = new Warrior();

            //MessageBox.Show("You have a mage with a strength of " + playerM.Strength.ToString() + ".", "New Mage");
            //MessageBox.Show("You have a mage with a strength of " + playerW.Strength.ToString() + ".", "New Warrior");


            String output = "Your Character- ";
            output += "\nName: " + text_Name.Text;
            output += "\nGender: " + (string)(this.radioButton_Gobbina.Checked ? "Gobbina" : this.radioButton_Gobblyn.Checked ? "Gobblyn" : this.radioButton_Gobbo.Checked ? "Gobbo" : "Error");
            output += "\nClass: " + comboBox_Class.Text;
            

            MessageBox.Show(output, "Character Made");
        }
    }
}
