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

namespace MEDICALSHOP1
{
    public partial class billprint : Form
    {
        public billprint()
        {
            InitializeComponent();
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;

            connectionString = ConfigurationManager.ConnectionStrings["coonstring"].ConnectionString;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT SlNo,a.BILLNO,BATCH,[EXP DATE],ITEMNAME,QUANTITY,RATE,TOTAL,BrannchName,Location,PhoneNo,Patient,DoctorName FROM Tbl_SalesItem_DUMMY b  inner join Tbl_BranchMaster on Tbl_BranchMaster.BranchId='1' inner join Tbl_Sales a on (b.BillNo=a.BILLNO)";

            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            billprintdataset ds  = new billprintdataset();
            dscmd.Fill(ds);
            //MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
            cnn.Close();

            Bill objRpt = new Bill();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
