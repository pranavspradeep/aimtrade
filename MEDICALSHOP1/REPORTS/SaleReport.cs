using MEDICALSHOP1.CRYSTALREPORTS;
using MEDICALSHOP1.DATASET;
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

namespace MEDICALSHOP1.REPORTS
{
    public partial class SaleReport : Form
    {
        public SaleReport()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;

            connectionString = ConfigurationManager.ConnectionStrings["coonstring"].ConnectionString;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT BillNo,Date,Grandtotal,BrannchName,Location,PhoneNo FROM Tbl_Sales inner join Tbl_BranchMaster on Tbl_BranchMaster.BranchId=1 where Tbl_Sales.Date between'" + From_dateTimePicker.Text + "'and '" + To_dateTimePicker.Text + "'";


            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            SalesReportDataSet ds = new SalesReportDataSet();
            dscmd.Fill(ds);
           // MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
            cnn.Close();

            SalesCrystalReport objRpt = new SalesCrystalReport();
            objRpt.SetDataSource(ds.Tables[1]);
            SalesReportViewer.ReportSource = objRpt;
            SalesReportViewer.Refresh();

        }
    }
}
