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
    public partial class OUTofSTOCKreport : Form
    {
        public OUTofSTOCKreport()
        {
            InitializeComponent();
            Report();
        }
        public void Report()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("OutofStockReporting", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            da.SelectCommand = cmd;
            da.Fill(dt);
            OutofStockreporting report = new OutofStockreporting();
            report.SetDataSource(dt);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
