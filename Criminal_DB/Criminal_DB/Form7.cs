using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criminal_DB
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
                Console.Write("Entra");
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox3.PasswordChar = '*';
                Console.Write("Entra");
            }
            else
            {
                textBox3.PasswordChar = '\0';
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Console.Write(textBox1.Text+" "+textBox2.Text+" "+textBox3.Text);
            this.Close();
        }
    }
}
