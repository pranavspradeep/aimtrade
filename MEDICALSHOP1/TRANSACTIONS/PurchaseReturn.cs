using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MEDICALSHOP1
{
    public partial class PurchaseReturn : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public PurchaseReturn()
        {
            InitializeComponent();
            autoTextbox_suppliername();
            autoTextbox_itemname();
            autoTextbox_companyname();
            PurchaseReturnID();
        }
        public void PurchaseReturnID()
        {
            SqlDataReader myReader = null;
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection myConnection = new SqlConnection(conStr);
            // SqlCommand myCommand = new SqlCommand("select BillNo from  Tbl_Sales", myConnection);
            SqlCommand myCommand = new SqlCommand("PurchaseReturnIdFetch", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                String i = myReader["Purchase_ReturnID"].ToString();
                int pid = Convert.ToInt32(i);
                int billid = ++pid;
                ReturnNo_txtbox.Text = billid.ToString();


            }
            myConnection.Close();
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
                SupplierName_txtbox.AutoCompleteCustomSource = MyCollection;
                con.Close();

            }
        }


        public void StockUPdate()
        {
            int i = 0;
            string Itemname = "";
            string Batch = "";
            SqlDataReader sqlDataupdate;
            string ReadCON = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection sqlConnection1 = new SqlConnection(ReadCON);
            sqlConnection1.Open();

            SqlCommand upcommand1 = new SqlCommand("StockUpDateitemBatchRetreive", sqlConnection1);
            upcommand1.CommandType = CommandType.StoredProcedure;
            sqlDataupdate = upcommand1.ExecuteReader();
        while(sqlDataupdate.Read())
            { 

                Itemname = sqlDataupdate["ItemName"].ToString();

                Batch = sqlDataupdate["Batch"].ToString();

                string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand upcommand = new SqlCommand("UpdateStock", con);
                upcommand.CommandType = CommandType.StoredProcedure;
                upcommand.Parameters.AddWithValue("@item", Itemname);
                upcommand.Parameters.AddWithValue("@batch", Batch);
                i = upcommand.ExecuteNonQuery();

                con.Close();
                
            }
           
            if (i != 0)
            {
                MessageBox.Show("StockUpdated");
            }
        }
    
            
            

        









        //private void add_button_Click(object sender, EventArgs e)
        //{

        //}
        public void DisplayData()///display data function
        {
            SqlDataAdapter adapt;
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("PurchaseReturnDisplay", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            //this.dataGridView1.Sort(this.dataGridView1.Columns["SlNo"], ListSortDirection.Descending);
            con.Close();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
        }

        private void ClearTextBoxes()///clear textbox
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }





        private void add_button_Click_1(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoPurchaseReturnDisplay", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SupplierName", SupplierName_txtbox.Text);
            cmd.Parameters.AddWithValue("@ItemName", ItemName_txtbox.Text);
            cmd.Parameters.AddWithValue("@CompanyName", CompanyName_txtbox.Text);
            cmd.Parameters.AddWithValue("@Batch", Batch_txtbox.Text);
            cmd.Parameters.AddWithValue("@Reason", Reason_Txtbox.Text);
            cmd.Parameters.AddWithValue("@Rate", Rate_textBox.Text);
            cmd.Parameters.AddWithValue("@Quantity",QuantitytextBox.Text);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                //  MessageBox.Show("DataEntered");
                DisplayData();
            }
            // else
            //{
            ////MessageBox.Show("Data Not Saved");
            //  }
            con.Close();
            SupplierName_txtbox.Clear();
            ItemName_txtbox.Clear();

            CompanyName_txtbox.Clear();
            Batch_txtbox.Clear();
            Rate_textBox.Clear();
            Reason_Txtbox.Clear();

            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand("sumtotal_PurchaseReturn", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                total_txtbox.Text = myReader.GetValue(0).ToString();
            }

           




        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlDataReader sqlData;
            string constr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("FetchdatafromPurchaseReturnDisplay", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            sqlData = command.ExecuteReader();

            while (sqlData.Read())
            {
                string SupplierName = sqlData["SupplierName"].ToString();
                string Itemname = sqlData["ItemName"].ToString();
                string CompanyName = sqlData["Company"].ToString();
                string Batch = sqlData["Batch"].ToString();
                string Reason = sqlData["Reason"].ToString();
                string R = sqlData["Amount"].ToString();
                float Rate = float.Parse(R);
                string quantity = sqlData["Quantity"].ToString();
                float Quantity = float.Parse(quantity);

                string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
                SqlConnection con = new SqlConnection(conStr);

                SqlCommand cmd = new SqlCommand("InsertToPurchaseReturn", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                cmd.Parameters.AddWithValue("@ItemName", Itemname);
                cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                cmd.Parameters.AddWithValue("@Batch", Batch);
                cmd.Parameters.AddWithValue("@Reason", Reason);
                cmd.Parameters.AddWithValue("@Rate", Rate);
                ///from this design
                cmd.Parameters.AddWithValue("@PurchaseId", purchaseid_txtbox.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker_p.Text);
                //cmd.Parameters.AddWithValue("@Total", total_txtbox.Text);
                cmd.Parameters.AddWithValue("@ReturnTo", Return_txtbox.Text);
                cmd.Parameters.AddWithValue("@Quantity", quantity);





                i = cmd.ExecuteNonQuery();
            }
            sqlData.Dispose();
            if (i != 0)
            {
                string conn = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
                SqlConnection sql = new SqlConnection(constr);
                sql.Open();
                SqlCommand mycommand = new SqlCommand("TRUNICATE_PURCHASERETURNDISPLAY", sql);
                mycommand.ExecuteReader();
                sql.Close();
                // ClearTextBoxes();
                purchaseid_txtbox.Clear();
                SupplierName_txtbox.Clear();
                ItemName_txtbox.Clear();
                CompanyName_txtbox.Clear();
                Batch_txtbox.Clear();
                Reason_Txtbox.Clear();
                Rate_textBox.Clear();
                ReturnNo_txtbox.Clear();
                total_txtbox.Clear();

                DisplayData();
                sqlData.Close();
                MessageBox.Show("DataEntered");
                sqlConnection.Close();
               
                
            }
            else
            {
                MessageBox.Show("Data Not Saved");
                sqlConnection.Close();
            }
            PurchaseReturnID();
            //StockUPdate();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICALSHOPDataSet.Tbl_PurchaseReturnDisplay' table. You can move, or remove it, as needed.
            

        }

        private void ReturnQuantity_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("PurchaseReturnonBatch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SupplierName", SupplierName_txtbox.Text);
            cmd.Parameters.AddWithValue("@ItemName", ItemName_txtbox.Text);
            cmd.Parameters.AddWithValue("@CompanyName", CompanyName_txtbox.Text);
            cmd.Parameters.AddWithValue("@Batch", Batch_txtbox.Text);
            cmd.Parameters.AddWithValue("@Reason", Reason_Txtbox.Text);
            cmd.Parameters.AddWithValue("@Rate", Rate_textBox.Text);
            cmd.Parameters.AddWithValue("@Quantity", QuantitytextBox.Text);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                //  MessageBox.Show("DataEntered");
                DisplayData();
            }
            // else
            //{
            ////MessageBox.Show("Data Not Saved");
            //  }
            con.Close();
            SupplierName_txtbox.Clear();
            ItemName_txtbox.Clear();

            CompanyName_txtbox.Clear();
            Batch_txtbox.Clear();
            Rate_textBox.Clear();
            Reason_Txtbox.Clear();
            QuantitytextBox.Clear();
            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand("sumtotal_PurchaseReturn", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                total_txtbox.Text = myReader.GetValue(0).ToString();
            }



        }

        private void purchaseid_txtbox_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("purchasereturn_pid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Purchaseid", purchaseid_txtbox.Text);
         
            da.SelectCommand = cmd;
            da.Fill(dt);
            
          
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.CurrentCell = null;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["ItemName"].Width = 200;
            
            dataGridView1.Columns["Company"].Width = 90;
            dataGridView1.Columns["Batch"].Width = 90;
            
           
            dataGridView1.Columns["Rate"].Width = 50;
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                ItemName_txtbox.Text = row.Cells["ItemName"].Value.ToString();
               CompanyName_txtbox.Text = row.Cells["Company"].Value.ToString();
                Batch_txtbox.Text = row.Cells["Batch"].Value.ToString();
                Rate_textBox.Text = row.Cells["Rate"].Value.ToString();
                
            }
        }
    }
}




           



   

