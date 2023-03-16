using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_4_takehome
{
    public partial class mainwindowform : Form
    {
        public mainwindowform()
        {
            InitializeComponent();
            button_submit.Enabled = false;



        }
        private bool buttonclicked = false ;



        private void button_next_Click(object sender, EventArgs e)
        {
            buttonclicked = true;
            secondwindowform form = new secondwindowform();

            if (checkbox_true.Checked && buttonclicked)
            {
                button_submit.Enabled = true;
            }
            form.Show();
        }

        private void checkbox_true_Click(object sender, EventArgs e)
        {
            if (checkbox_true.Checked && buttonclicked)
            {
                button_submit.Enabled = true;
            }
            else { button_submit.Enabled = false; }
            

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            secondwindowform form2 = Application.OpenForms["secondwindowform"] as secondwindowform;

            if (textbox_name.Text == "" || textbox_artist.Text == "" )
            {
                MessageBox.Show("Enter the correct input");
            }
            else
            { 
                string outputnya = "Hi, my name is " + textbox_name.Text + " and my favorite artist is " + textbox_artist.Text;
                form2.LabelOutput = outputnya;
                form2.Refresh();
            }
            
            
        }
    }
}
