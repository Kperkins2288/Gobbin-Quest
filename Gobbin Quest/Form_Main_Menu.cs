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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void button_Creat_Char_Click(object sender, EventArgs e)
        {
            Form_Create_Character charcreate = new Form_Create_Character();
            charcreate.Show();
        }
    }
}
