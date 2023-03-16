using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_4_takehome
{
    public partial class secondwindowform : Form
    {
        public secondwindowform()
        {
            InitializeComponent();
            button_magic.Enabled = false;
        }

        public string LabelOutput
        {
            get { return label_output.Text; }
            set { label_output.Text = value; }
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            radio_lightbrown.Checked = false;
            radio_gray.Checked = false;
            radio_lightblue.Checked = false;
            radio_green.Checked = false;
            radio_violet.Checked = false;
        }

        private void radio_lightbrown_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_true2_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkbox_true2.Checked && checkbox_agree.Checked)
            {
                button_magic.Enabled = true;
            }
            else { button_magic.Enabled = false; }
        }

        private void checkbox_agree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_true2.Checked && checkbox_agree.Checked)
            {
                button_magic.Enabled = true;
            }
            else { button_magic.Enabled = false; }

        }

        private void button_magic_Click(object sender, EventArgs e)
        {
            mainwindowform form = Application.OpenForms["mainwindowform"] as mainwindowform;

            if (radio_violet.Checked == false && radio_lightbrown.Checked == false && radio_gray.Checked == false && radio_green.Checked == false && radio_lightblue.Checked == false && radio_black.Checked == false && radio_white.Checked == false && radio_pink.Checked == false)
            {
                MessageBox.Show("Choose atleast 1!");
            }
            else
            {
                if (radio_lightbrown.Checked)
                {
                    form.BackColor = Color.BurlyWood;
                }
                if (radio_gray.Checked)
                {
                    form.BackColor = Color.Gray;
                }
                if (radio_lightblue.Checked)
                {
                    form.BackColor = Color.CornflowerBlue;
                }
                if (radio_violet.Checked)
                {
                    form.BackColor = Color.Violet;
                }
                if (radio_green.Checked)
                {
                    form.BackColor = Color.MediumSeaGreen;
                }
                if (radio_black.Checked)
                {
                    form.ForeColor = Color.Black;
                }
                if (radio_white.Checked)
                {
                    form.ForeColor = Color.White;
                }
                if (radio_pink.Checked)
                {
                    form.ForeColor = Color.Pink;
                }
                if (form != null)
                {
                    form.Refresh();
                }
                
            }
           
        }
    }
}
