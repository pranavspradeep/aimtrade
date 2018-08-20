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
    public partial class PurchaseReturnReportview : Form
    {
        public PurchaseReturnReportview()
        {
            InitializeComponent();
        }

        

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("PurchaseReturnReportFetch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FromDate", FromdateTimePicker.Value);
            cmd.Parameters.AddWithValue("@ToDate", TodateTimePicker.Value);
            da.SelectCommand = cmd;
            da.Fill(dt);
            PurchaseReturnReport report = new PurchaseReturnReport();
            report.SetDataSource(dt);
            crystalReportViewer_purchasereturn.ReportSource = report;
            crystalReportViewer_purchasereturn.Refresh();
        }
    }
}
