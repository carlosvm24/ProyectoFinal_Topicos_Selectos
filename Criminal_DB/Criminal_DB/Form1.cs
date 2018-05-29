using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Criminal_DB
{
    public partial class Login : Form
    {
        //string oradb = "Data Source=TJPD;User Id=TJPD;Password=Criminal2511;";
        //OracleConnection conn;
        public Login()
        {
            InitializeComponent();
            //conn = new OracleConnection(oradb);
            //conn.Open();
            this.FormClosing += CloseApp;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
                Console.Write("Entra");
            }
            else
            {
                textBox2.PasswordChar =  '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text +" "+ textBox2.Text);
            //int lvl = Check_Login(textBox1.Text, textBox2.Text);
            //Console.WriteLine(lvl);
            //MainForm main_form = new MainForm(conn);
            MainForm main_form = new MainForm();
            main_form.Show();
            this.Hide();
            main_form.FormClosing += OnClose;
        }

        /*private int Check_Login(string username, string password)
        {
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.CHECK_LOGIN";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter name = new OracleParameter();
            name.OracleDbType = OracleDbType.Varchar2;
            name.Direction = ParameterDirection.Input;
            name.Value = username;
            cmd.Parameters.Add(name);

            OracleParameter pwd = new OracleParameter();
            pwd.OracleDbType = OracleDbType.Varchar2;
            pwd.Direction = ParameterDirection.Input;
            pwd.Value = password;
            cmd.Parameters.Add(pwd);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Console.WriteLine(dr.GetDecimal(0));
            int lvl =  Convert.ToInt32(dr.GetDecimal(0));
            return lvl;
        }*/

        private void OnClose(object sender, EventArgs e)
        {
            this.Show();
        }

        private void CloseApp(object sender, EventArgs e)
        {
            //conn.Close();
        }
    }
}
