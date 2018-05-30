using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Criminal_DB
{
    public partial class UserControl1 : UserControl
    {
        int user_id = 0;
        int level = 0;
        Form3 newu;
        OracleConnection conn;
        public UserControl1(OracleConnection connect, int lvl)
        //public UserControl1()
        {
            InitializeComponent();
            conn = connect;
            level = lvl;
            initScreen();
        }

        private void initScreen()
        {
            Check_Users(0, "", "", "", "");
            /*User_ID.ForeColor = Color.LightGray;
            this.User_ID.Leave += new System.EventHandler(this.User_ID_Leave);
            this.User_ID.Enter += new System.EventHandler(this.User_ID_Enter);
            User_name.ForeColor = Color.LightGray;
            this.User_name.Leave += new System.EventHandler(this.User_name_Leave);
            this.User_name.Enter += new System.EventHandler(this.User_name_Enter);
            User_Rank.ForeColor = Color.LightGray;
            this.User_Rank.Leave += new System.EventHandler(this.User_Rank_Leave);
            this.User_Rank.Enter += new System.EventHandler(this.User_Rank_Enter);
            User_Station.ForeColor = Color.LightGray;
            this.User_Station.Leave += new System.EventHandler(this.User_Station_Leave);
            this.User_Station.Enter += new System.EventHandler(this.User_Station_Enter);
            User_Zone.ForeColor = Color.LightGray;
            this.User_Zone.Leave += new System.EventHandler(this.User_Zone_Leave);
            this.User_Zone.Enter += new System.EventHandler(this.User_Zone_Enter);*/
        }

        private void Userlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Userlist.SelectedItems.Count > 0)
            {
                user_id = Convert.ToInt32(Userlist.SelectedItems[0].SubItems[0].Text);
                New_username.Text = Userlist.SelectedItems[0].SubItems[1].Text;
                comboBox2.SelectedItem = Userlist.SelectedItems[0].SubItems[2].Text;
                New_station.Text = Userlist.SelectedItems[0].SubItems[3].Text;
            }
        }

        public void Check_Users(int userid, string username, string user_rank, string station_name, string stationzone)
        {
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.SEARCH_USER";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter id = new OracleParameter();
            id.OracleDbType = OracleDbType.Decimal;
            id.Direction = ParameterDirection.Input;
            id.Value = userid;
            cmd.Parameters.Add(id);

            OracleParameter name = new OracleParameter();
            name.OracleDbType = OracleDbType.Varchar2;
            name.Direction = ParameterDirection.Input;
            name.Value = username+"%";
            cmd.Parameters.Add(name);

            OracleParameter rank = new OracleParameter();
            rank.OracleDbType = OracleDbType.Varchar2;
            rank.Direction = ParameterDirection.Input;
            rank.Value = user_rank+"%";
            cmd.Parameters.Add(rank);

            OracleParameter station = new OracleParameter();
            station.OracleDbType = OracleDbType.Varchar2;
            station.Direction = ParameterDirection.Input;
            station.Value = station_name+"%";
            cmd.Parameters.Add(station);

            OracleParameter zone = new OracleParameter();
            zone.OracleDbType = OracleDbType.Varchar2;
            zone.Direction = ParameterDirection.Input;
            zone.Value = stationzone+"%";
            cmd.Parameters.Add(zone);

            OracleParameter dnt_cur = new OracleParameter();
            dnt_cur.OracleDbType = OracleDbType.RefCursor;
            dnt_cur.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(dnt_cur);

            OracleDataReader dr = cmd.ExecuteReader();
            Userlist.Items.Clear();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetDecimal(0) + " " + dr.GetString(1) + " " + dr.GetString(2) + " " + dr.GetString(3) + " " + dr.GetString(4));
                ListViewItem lvi = new ListViewItem(Convert.ToString(dr.GetDecimal(0)));
                lvi.SubItems.Add(dr.GetString(1));
                lvi.SubItems.Add(dr.GetString(2));
                lvi.SubItems.Add(dr.GetString(3));
                lvi.SubItems.Add(dr.GetString(4));

                Userlist.Items.Add(lvi);
            }
        }

        private void Delete_user(int id)
        {
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.DELETE_USER";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("OFID", OracleDbType.Decimal, id, ParameterDirection.Input);

            cmd.ExecuteNonQuery();
        }

        private void Edit_user(int id, string name, string officer_rank, string station_name)
        {
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.EDIT_USER";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("OFID", OracleDbType.Decimal, id, ParameterDirection.Input);

            cmd.BindByName = true;
            cmd.Parameters.Add("ONAME", OracleDbType.Varchar2, name, ParameterDirection.Input);

            cmd.Parameters.Add("ORANK", OracleDbType.Varchar2, officer_rank, ParameterDirection.Input);

            cmd.Parameters.Add("SNAME", OracleDbType.Varchar2, station_name, ParameterDirection.Input);

            cmd.ExecuteNonQuery();
        }

        private void User_Edit_CheckedChanged(object sender, EventArgs e)
        {
            New_username.Enabled = !New_username.Enabled;
            comboBox2.Enabled = !comboBox2.Enabled;
            New_station.Enabled = !New_station.Enabled;
            UpdateUser.Enabled = !UpdateUser.Enabled;
            DeleteUser.Enabled = !DeleteUser.Enabled;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                Check_Users(Convert.ToInt32(User_ID.Text), User_name.Text, comboBox1.SelectedItem.ToString(), User_Station.Text, User_Zone.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Los campos estan mal ingresados.", "Base de datos criminalistica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FIRlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            Edit_user(user_id, New_username.Text, comboBox2.SelectedItem.ToString(), New_station.Text);
            Check_Users(0, "", "", "", "");
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            Delete_user(user_id);
            Check_Users(0, "", "", "", "");
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            newu = new Form3(conn);
            newu.Show();
            this.Enabled = false;
            newu.FormClosing += adduclose;
        }

        private void adduclose(object sender, EventArgs e)
        {
            this.Enabled = true;
            Check_Users(0, "", "", "", "");
        }
    }
}
