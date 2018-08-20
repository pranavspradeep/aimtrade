using DGVPrinterHelper;
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
    public partial class ItemwiseReport : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public ItemwiseReport()
        {
            InitializeComponent();
            fillcompany();
            filldoctor();
            fillproductname();
        }

        private void Todatetimepicker_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string test = "SELECT DISTINCT T1.ItemName, T1.Company, T1.ItemNo, T3.PQty AS Stock, T1.Batch, sum(t1.Qty) over(partition by T1.ItemName) AS Saled_quantity FROM Tbl_SalesItem T1, Tbl_Sales T2, tbl_Stock T3 WHERE(T2.Date between'" + FromDatepicker.Value.ToString("dd-MMM-yyy") + "' and '" + Todatetimepicker.Value.ToString("dd-MMM-yyy") + "') and(t1.ItemName = t3.ItemName) and(t1.BillNo = t2.BillNo) AND(T1.Batch = T3.Batch) group by T1.Batch, t1.ItemName, t1.Company,  t1.ItemNo, t3.PQty, t2.BillNo, t1.Qty";
            SqlCommand sql = new SqlCommand(test, con);
            DataTable dataTable = new DataTable();
            
            SqlDataAdapter sqlada = new SqlDataAdapter(sql);
            sqlada.Fill(dataTable);
            infogrid_dgv.DataSource = dataTable;
            con.Close();
            fillproductname();
            Productname_txt.Focus();


        }

        private void Productname_txt_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand sql = new SqlCommand("select DISTINCT t1.ItemName,t1.Company,t1.Batch,t3.PQty as Stock,sum(t1.Qty) over (partition by t1.ItemName)as saled_quantity from Tbl_SalesItem t1,Tbl_Sales t2,tbl_Stock t3 where (t1.BillNo=t2.BillNo and t1.ItemName='" + Productname_txt.Text+ "') AND (T2.Date BETWEEN '" + FromDatepicker.Value.ToString("dd-MMM-yyy") + "' and '" + Todatetimepicker.Value.ToString("dd-MMM-yyy") + "') and t1.Batch=t3.Batch  group by T1.Batch,t1.ItemName,t1.Company,t1.ItemNo,t3.PQty,t2.BillNo,t1.Qty");
            sql.Connection = con;
            DataTable dataTablePROBASE = new DataTable();
            SqlDataAdapter sqladaPRODBASE = new SqlDataAdapter(sql);
            sqladaPRODBASE.Fill(dataTablePROBASE);
            infogrid_dgv.DataSource = dataTablePROBASE;
            con.Close();
            fillcompany();
            Companyname_txtbox.Focus();
        }

        public void fillproductname()
        {
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("select ProductName from Tbl_ProductMaster", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                Productname_txt.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }


        }

        public void filldoctor()
        {
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("select DoctorName  from Tbl_Sales ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                Doctorname_txt.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }


        }

        public void fillcompany()
        {
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("select ManufactureName from Tbl_ProductMaster", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                Companyname_txtbox.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }


        }

        private void Companyname_txtbox_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand sql = new SqlCommand("select DISTINCT   t1.ItemName,t1.Company,t1.Batch ,t3.PQty as stock,sum(t1.Qty) over(partition by t1.ItemName)as saled_quantity from Tbl_SalesItem t1, Tbl_Sales t2,tbl_Stock t3 where(t1.BillNo= t2.BillNo and t1.ItemName= '" + Productname_txt.Text + "') AND(T2.Date BETWEEN '" + FromDatepicker.Value.ToString("dd-MMM-yyy") + "' and '" + Todatetimepicker.Value.ToString("dd-MMM-yyy") + "') and(t1.Batch= t3.Batch) and t1.Company='" + Companyname_txtbox.Text + "'  group by T1.Batch, t1.ItemName, t1.Company, t1.ItemNo, t3.PQty, t2.BillNo, t1.Qty", con);
            //sql.Connection = con;
            DataTable dataTablePROBASE = new DataTable();
            SqlDataAdapter sqladaPRODBASE = new SqlDataAdapter(sql);
            sqladaPRODBASE.Fill(dataTablePROBASE);
            infogrid_dgv.DataSource = dataTablePROBASE;
            con.Close();
            filldoctor();
            Doctorname_txt.Focus();

        }

        private void Doctorname_txt_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand sql = new SqlCommand("select DISTINCT t2.DoctorName,  t1.ItemName,t1.Company,t1.Batch ,t3.PQty as stock,sum(t1.Qty) over(partition by t1.ItemName)as saled_quantity from Tbl_SalesItem t1, Tbl_Sales t2,tbl_Stock t3 where(t1.BillNo= t2.BillNo and t1.ItemName= '" + Productname_txt.Text + "') AND(T2.Date BETWEEN '" + FromDatepicker.Value.ToString("dd-MMM-yyy") + "' and '" + Todatetimepicker.Value.ToString("dd-MMM-yyy") + "') and(t1.Batch= t3.Batch) and (t1.Company='" + Companyname_txtbox.Text + "') AND(t2.DoctorName='" + Doctorname_txt.Text + "') group by T1.Batch, t1.ItemName, t1.Company, t1.ItemNo, t3.PQty, t2.BillNo, t1.Qty,t2.DoctorName", con);
            //sql.Connection = con;
            DataTable dataTablePROBASE = new DataTable();
            SqlDataAdapter sqladaPRODBASE = new SqlDataAdapter(sql);
            sqladaPRODBASE.Fill(dataTablePROBASE);
            infogrid_dgv.DataSource = dataTablePROBASE;
            con.Close();
            FromDatepicker.Focus();
        }

        private void FromDatepicker_Leave(object sender, EventArgs e)
        {
            Todatetimepicker.Focus();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
           ;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Itemwise Report";//Header
           // printer.SubTitle =string.Format("Report Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitle = "Report Date ::'"+DateTime.Now.Date.ToString("MM/dd/yyyy") +"'Report From:::'"+FromDatepicker.Text+"'TO:::'"+Todatetimepicker.Text+"'";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Aimsoftsoloutions";//Footer
            printer.FooterSpacing = 15;
            //Print landscape mode
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(infogrid_dgv);
        }

        private void Todatetimepicker_Leave_1(object sender, EventArgs e)
        {
            fillproductname();
        }

        private void Productname_txt_Leave_1(object sender, EventArgs e)
        {
            fillcompany();
        }

        private void Companyname_txtbox_Leave_1(object sender, EventArgs e)
        {
            filldoctor();
        }
    }
}


