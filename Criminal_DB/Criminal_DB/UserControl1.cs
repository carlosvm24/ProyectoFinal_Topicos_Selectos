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
        //public OracleConnection conn;
        //public UserControl1(OracleConnection connect)
        public UserControl1()
        {
            InitializeComponent();
            //conn = connect;
            initScreen();
        }

        private void initScreen()
        {
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
                New_username.Text = Userlist.SelectedItems[0].SubItems[1].Text;
                New_rank.Text = Userlist.SelectedItems[0].SubItems[2].Text;
                New_station.Text = Userlist.SelectedItems[0].SubItems[3].Text;
            }
        }

        /*public List<Object> Check_Users(int userid, string username, string user_rank, string station_name, string stationzone)
        {
            List < Object > list = new List<Object>();
            List<Object> data = new List<Object>();

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
            while (dr.Read())
            {
                Console.WriteLine(dr.GetDecimal(0) + " " + dr.GetString(1) + " " + dr.GetString(2) + " " + dr.GetString(3) + " " + dr.GetString(4));
                data.Add(dr.GetDecimal(0));
                data.Add(dr.GetString(1));
                data.Add(dr.GetString(2));
                data.Add(dr.GetString(3));
                data.Add(dr.GetString(4));
                list.Add(data);
                data.Clear();
            }
            return list;
        }

        private void Create_new_user(string name, string rank)

        {
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.ADD_USER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;

            cmd.Parameters.Add("OFFICER_RANK", OracleDbType.Varchar2, rank, ParameterDirection.Input);

            cmd.Parameters.Add("OFFICER_NAME", OracleDbType.Varchar2, name, ParameterDirection.Input);

            cmd.ExecuteNonQuery();
        }

        private void Delete_user(int id, string name)
        {
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.DELETE_USER";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("OFFICER_ID", OracleDbType.Decimal, id, ParameterDirection.Input);

            cmd.Parameters.Add("OFFICER_NAME", OracleDbType.Varchar2, name, ParameterDirection.Input);

            cmd.ExecuteNonQuery();
        }

        private void Edit_user(string cur_name, string name, string officer_rank)
        {
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "TJPD.LVL1.EDIT_USER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;

            cmd.Parameters.Add("CUR_NAME", OracleDbType.Varchar2, cur_name, ParameterDirection.Input);

            cmd.Parameters.Add("OFFICER_NAME", OracleDbType.Varchar2, name, ParameterDirection.Input);

            cmd.Parameters.Add("OFFICER_RANK", OracleDbType.Varchar2, officer_rank, ParameterDirection.Input);

            cmd.ExecuteNonQuery();
        }*/

        private void User_Edit_CheckedChanged(object sender, EventArgs e)
        {
            New_username.Enabled = !New_username.Enabled;
            New_rank.Enabled = !New_rank.Enabled;
            New_station.Enabled = !New_station.Enabled;
            UpdateUser.Enabled = !UpdateUser.Enabled;
            DeleteUser.Enabled = !DeleteUser.Enabled;
        }
    }
}
