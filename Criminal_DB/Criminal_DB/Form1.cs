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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
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
            //OracleConnection cn = new OracleConnection(DatabaseHelper.GetConnection)
            //string oradb = "Data Source=TJPD;User Id=TJPD;Password=Criminal2511;";
            //OracleConnection conn = new OracleConnection(oradb);  // C#
            //System.Diagnostics.Debug.WriteLine("Checar");
            //System.Diagnostics.Debug.WriteLine(conn);
            //conn.Open();
            //OracleCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "begin open :1 for select* from officer where rank = 1; end; ";
            //OracleParameter p_rc = cmd.Parameters.Add("p_rc",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output);
            //OracleCommand cmd = new OracleCommand();
            MainForm main_form = new MainForm();
            main_form.Show();
            this.Hide();
            main_form.FormClosing += OnClose;
        }
        
        private void Create_new_user(string name, string rank)
        {
            string oradb = "Data Source=TJPD;User Id=TJPD;Password=Criminal2511;";
            OracleConnection conn = new OracleConnection(oradb);
            //System.Diagnostics.Debug.WriteLine(conn);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.ADD_USER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;

            cmd.Parameters.Add("OFFICER_RANK", OracleDbType.Varchar2, rank, ParameterDirection.Input);
            cmd.Parameters.Add("OFFICER_NAME", OracleDbType.Varchar2, name, ParameterDirection.Input);
            cmd.ExecuteNonQuery();

            conn.Close();

        }
        private void Delete_user(string name)
        {
            string oradb = "Data Source=TJPD;User Id=TJPD;Password=Criminal2511;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.DELETE_USER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("OFFICER_NAME", OracleDbType.Varchar2, name, ParameterDirection.Input);
            cmd.ExecuteNonQuery();

            conn.Close();

        }
        private void Edit_user(string cur_name, string name, string officer_rank)
        {
            string oradb = "Data Source=TJPD;User Id=TJPD;Password=Criminal2511;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.EDIT_USER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;
            cmd.Parameters.Add("CUR_NAME", OracleDbType.Varchar2, cur_name, ParameterDirection.Input);
            cmd.Parameters.Add("OFFICER_NAME", OracleDbType.Varchar2, name, ParameterDirection.Input);
            cmd.Parameters.Add("OFFICER_RANK", OracleDbType.Varchar2, officer_rank, ParameterDirection.Input);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        private void Add_station(string station_name, string station_address,string station_zone)
        {
            string oradb = "Data Source=TJPD;User Id=TJPD;Password=Criminal2511;";
            OracleConnection conn = new OracleConnection(oradb);
            //System.Diagnostics.Debug.WriteLine(conn);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.ADD_STATION";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;

            cmd.Parameters.Add("STATION_NAME", OracleDbType.Varchar2, station_name, ParameterDirection.Input);
            cmd.Parameters.Add("STATION_ADDRESS", OracleDbType.Varchar2, station_address, ParameterDirection.Input);
            cmd.Parameters.Add("STATION_ZONE", OracleDbType.Varchar2, station_zone, ParameterDirection.Input);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void OnClose(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
