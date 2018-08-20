using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MEDICALSHOP1
{
    public partial class SalesReturn : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public SalesReturn()
        {
            InitializeComponent();
            autoTextbox_suppliername();
            autoTextbox_itemname();
            autoTextbox_companyname();
            ReturnNO();
        }
        public void autoTextbox_suppliername()
        {


            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SupplierAutoText_Purchase", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                //SupplierName_txtbox.AutoCompleteCustomSource = MyCollection;
                con.Close();

            }
        }
        public void ReturnNO()
        {
            SqlDataReader myReader = null;
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection myConnection = new SqlConnection(conStr);
            // SqlCommand myCommand = new SqlCommand("select BillNo from  Tbl_Sales", myConnection);
            SqlCommand myCommand = new SqlCommand("ReturnIdREtrieve", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                String i = myReader["ReturnID"].ToString();
                int pid = Convert.ToInt32(i);
                int ReturnId = ++pid;
                ReturnNo_txtbox.Text = ReturnId.ToString();


            }
            myConnection.Close();
        }
        public void DisplayData()///display data function
        {
            SqlDataAdapter adapt;
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("tblSalesReturnDisplay ", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            //this.dataGridView1.Sort(this.dataGridView1.Columns["SlNo"], ListSortDirection.Descending);
            con.Close();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
        }

        public void autoTextbox_itemname()
        {


            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("autoTextbox_itemname_Purchase ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                ItemName_txtbox.AutoCompleteCustomSource = MyCollection;
                con.Close();

            }

        }

        public void autoTextbox_companyname()
        {


            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(" autoTextbox_companyname_Purchase ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                CompanyName_txtbox.AutoCompleteCustomSource = MyCollection;
                con.Close();

            }



        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand command = new SqlCommand("InsertIntoTableSalesReturnDisplay", connection);
            command.CommandType = CommandType.StoredProcedure;
            // command.Parameters.AddWithValue("@ReturnNo",ReturnNo_txtbox.Text);
            command.Parameters.AddWithValue("@Date", dateTimePicker_Sr.Text);
            //command.Parameters.AddWithValue("@SupplierName",SupplierName_txtbox.Text);
            command.Parameters.AddWithValue("@Itemname", ItemName_txtbox.Text);
            command.Parameters.AddWithValue("@CompanyName", CompanyName_txtbox.Text);
            command.Parameters.AddWithValue("@Batch", Batch_txtbox.Text);
            command.Parameters.AddWithValue("@Quantity", Quantity_Txtbox.Text);
            command.Parameters.AddWithValue("@Rate", Rate_textBox.Text);
            command.Parameters.AddWithValue("@ReturnTo", Return_txtbox.Text);
            command.Parameters.AddWithValue("@Total", total_txtbox.Text);
            command.ExecuteNonQuery();
            connection.Close();

            DisplayData();
            //SupplierName_txtbox.Clear();
            ItemName_txtbox.Clear();
            CompanyName_txtbox.Clear();
            Batch_txtbox.Clear();
            Quantity_Txtbox.Clear();
            Rate_textBox.Clear();
            Return_txtbox.Clear();
            total_txtbox.Clear();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            SqlConnection cont = new SqlConnection(conStr);
            cont.Open();
            SqlCommand cmd = new SqlCommand("tunicateSalesReturndisplaytable", cont);
            cmd.CommandType = CommandType.StoredProcedure;
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Data Entered");
                cont.Close();
                DisplayData();
                ReturnNO();

            }
            else
            {
                MessageBox.Show("Data Entering FAILED!!!");
                cont.Close();
                DisplayData();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //SupplierName_txtbox.Clear();
            ItemName_txtbox.Clear();
            CompanyName_txtbox.Clear();
            Batch_txtbox.Clear();
            Quantity_Txtbox.Clear();
            Rate_textBox.Clear();
            Return_txtbox.Clear();
            total_txtbox.Clear();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BillNO_txtbox_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SalesReturnBillFetch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BillNo", BillNO_txtbox.Text);
            //  cmd.Parameters.AddWithValue("@ToDate", TodateTimePickerSalesReport.Text);
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                ItemName_txtbox.Text = row.Cells["ItemName"].Value.ToString();
               CompanyName_txtbox.Text = row.Cells["Company"].Value.ToString();
                Batch_txtbox.Text = row.Cells["Batch"].Value.ToString();
                Quantity_Txtbox.Text = row.Cells["Qty"].Value.ToString();
                Rate_textBox.Text = row.Cells["Rate"].Value.ToString();
            }
        }
    }
}

