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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Form2 objForm = new Form2();
            //MainForm.Controls.Add(objForm);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Form2 objForm = new Form2();
            objForm.TopLevel = false;
            objForm.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(objForm);
            objForm.Visible = true;

            //MainForm.Controls.Add(objForm);
            
        }
    }
}
