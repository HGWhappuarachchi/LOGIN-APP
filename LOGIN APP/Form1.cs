using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
                else
                this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult s;
            s = MessageBox.Show(" not saved yet do you want to Clear?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (s == DialogResult.OK) 
            {
                txt_username.Text ="";
                text_password.Text = "";
            }
            else
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult a;
            a = MessagBox.Show("Are you sure? ", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            int ID = int.Parse

        }
    }
}
