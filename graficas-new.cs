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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string oradb = "Data Source=TJPD;User Id=TJPD;Password=Criminal2511;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            Console.WriteLine(conn);
            conn.Open();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            chartCriminal.Series["Estaciones"].Points.AddXY("Homicidio", 1000);
            chartCriminal.Series["Estaciones"].Points.AddXY("Robo", 2000);
            chartCriminal.Series["Estaciones"].Points.AddXY("Secuestro", 3000);
            chartCriminal.Series["Estaciones"].Points.AddXY("Extorsion", 4000);
            chartMes.Series["Mes"].Points.AddXY("Febrero", 1000);
            chartMes.Series["Mes"].Points.AddXY("Julio", 2000);
            chartMes.Series["Mes"].Points.AddXY("Diciembre", 3000);
            chartMes.Series["Mes"].Points.AddXY("Noviembre", 4000);
     

        }
    }
}
