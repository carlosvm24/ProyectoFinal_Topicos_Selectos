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
        Form2 objForm;
        public MainForm()
        {
            InitializeComponent();
            //Form2 objForm = new Form2();
            //MainForm.Controls.Add(objForm);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            UserControl1 init = new UserControl1();
            splitContainer1.Panel2.Controls.Add(init);
            init.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            objForm = new Form2();
            objForm.MdiParent = this.MdiParent;
            objForm.Show();
            //this.Enabled = false;
        }
    }
}
