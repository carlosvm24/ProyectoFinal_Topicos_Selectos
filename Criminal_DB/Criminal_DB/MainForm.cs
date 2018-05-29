using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace Criminal_DB
{
    public partial class MainForm : Form
    {
        //OracleConnection conn;
        Form7 newpwd;
        //public MainForm(OracleConnection connect)
        public MainForm()
        {
            InitializeComponent();
            //conn = connect;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //UserControl1 init = new UserControl1(conn);
            UserControl1 init = new UserControl1();
            splitContainer1.Panel2.Controls.Add(init);
            init.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            newpwd = new Form7();
            newpwd.MdiParent = this.MdiParent;
            newpwd.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
