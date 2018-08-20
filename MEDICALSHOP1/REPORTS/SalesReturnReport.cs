using MEDICALSHOP1.CRYSTALREPORTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALSHOP1
{
    public partial class SalesReturnReport : Form
    {
        public SalesReturnReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SalesReturnReportFetch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FromDate", FromdateTimePicker.Text);
            cmd.Parameters.AddWithValue("@ToDate", TodateTimePicker.Text);
            da.SelectCommand = cmd;
            da.Fill(dt);
            SalesReturnCrystalReport report = new SalesReturnCrystalReport();
            report.SetDataSource(dt);
            crystalReportViewer_SalesReturnREport.ReportSource = report;
            crystalReportViewer_SalesReturnREport.Refresh();
        }

       
    }
}
