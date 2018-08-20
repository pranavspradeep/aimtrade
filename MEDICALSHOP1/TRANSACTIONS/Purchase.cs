using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace MEDICALSHOP1
{
    public partial class Purchase : Form
    {
        string Purchaseid;
        string itemname;
        string company;
        string qty;
        string batch;
        string expD;
        string rate;

        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public Purchase()
        {
            InitializeComponent();
            DisplayData();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            //   WindowState = FormWindowState.Maximized;
            TopMost = true;
            label3.Visible = true;
            purchaseidincrement();
            autoTextbox_itemname();
            autoTextbox_companyname();
            autoTextbox_suppliername();
            // dataGridView1.Rows.Clear();
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
                Suppliernme_txtbox.AutoCompleteCustomSource = MyCollection;
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
                itemname_txtboxauto.AutoCompleteCustomSource = MyCollection;
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
                company_textbox.AutoCompleteCustomSource = MyCollection;
                con.Close();

            }



        }
        public void purchaseidincrement()
        {
            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand("purchaseidincrement_Purchase", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                String i = myReader["PurchaseID"].ToString();
                int pid = Convert.ToInt32(i);
                int id = ++pid;
                PURCHASEid_auto_label.Text = id.ToString();


            }



        }




        private bool WithErrors()///TEXTBOX CONTROL VALIDATION
        {
            // if (Purchaseid_txtbox.Text.Trim() == String.Empty)
            //   return true; // Returns true if no input or only space is found
            if (Suppliernme_txtbox.Text.Trim() == String.Empty)
                return true;
            if (InvoiceNo_txtbox.Text.Trim() == String.Empty)
                return true;

            if (CreditDate_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Gstn_txtbox.Text.Trim() == String.Empty)
                return true;
            if (InvoiceDate_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Discount_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Addldiscount_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Rounding_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Adjustment_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Narration_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Grandtotal_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Netbalance_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Accountforaccounts_txtbox.Text.Trim() == String.Empty)
                return true;
            if (PaidAmt_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Balance_txtbox.Text.Trim() == String.Empty)
                return true;
            // Other textBoxes.

            return false;
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

        public void DisplayData()///display data function
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            DataTable dt = new DataTable();
            // adapt = new SqlDataAdapter("select ItemName,Batch,ExpDate,PQty,Rate,Company from tbl_Stock_dummy  ", con);
            adapt = new SqlDataAdapter("DisplayData_Purchase", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            // this.dataGridView1.Sort(this.dataGridView1.Columns["RowId"], ListSortDirection.Descending);
            con.Close();
            dataGridView1.CurrentCell = null;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            //dataGridView1.Columns["ItemName"].Width = 200;
            //dataGridView1.Columns["HSNCode"].Width = 90;
            //dataGridView1.Columns["Company"].Width = 90;
            //dataGridView1.Columns["Batch"].Width = 90;
            //dataGridView1.Columns["ExpDate"].Width = 90;
            //dataGridView1.Columns["PQty"].Width = 50;
            //dataGridView1.Columns["Rate"].Width = 50;
            //dataGridView1.Columns["MRP"].Width = 50;
            //dataGridView1.Columns["SGST"].Width = 50;
            //dataGridView1.Columns["Discount"].Width = 50;
            //dataGridView1.Columns["Amount"].Width = 50;
            //dataGridView1.Columns["SalesRate"].Width = 50;
            //dataGridView1.Columns["Rack"].Width = 50;
            //dataGridView1.Columns["NetRate"].Width = 50;
            //dataGridView1.Columns["Free"].Width = 90;
            /// this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
        }

        public void Purchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICALSHOPDataSet.tbl_Stock_dummy' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'mEDICALSHOPDataSet.tbl_Stock_dummy' table. You can move, or remove it, as needed.



        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            //label3.Visible = true;
            //if (WithErrors())
            //{
            //    label3.Text = "ALL FIELDS ARE REQUIRED";
            //}
            //else
            //{

            //label3.Visible = false;
            // Do whatever here... Submit

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("Purchase_Details", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@purchaseid",PURCHASEid_auto_label.Text);
            cmd.Parameters.AddWithValue("@suppliername", Suppliernme_txtbox.Text);
            cmd.Parameters.AddWithValue("@invoiceno", InvoiceNo_txtbox.Text);
            cmd.Parameters.AddWithValue("@receivedon", Receivedondatepicker.Text);
            cmd.Parameters.AddWithValue("@tmrp", TMRP1_txtbox.Text);
            cmd.Parameters.AddWithValue("@tmrp2", tmrp2_txtbox.Text);
            cmd.Parameters.AddWithValue("@date", Date_picker.Text);
            cmd.Parameters.AddWithValue("@creditdate", CreditDate_txtbox.Text);
            cmd.Parameters.AddWithValue("@gstn", Gstn_txtbox.Text);
            cmd.Parameters.AddWithValue("@invoicedate", InvoiceDate_txtbox.Text);
            cmd.Parameters.AddWithValue("@discount", Discount_txtbox.Text);
            cmd.Parameters.AddWithValue("@addldiscount", Addldiscount_txtbox.Text);
            cmd.Parameters.AddWithValue("@rounding", Rounding_txtbox.Text);
            cmd.Parameters.AddWithValue("@adjustment", Adjustment_txtbox.Text);
            cmd.Parameters.AddWithValue("@narration", Narration_txtbox.Text);
            cmd.Parameters.AddWithValue("@grandtotal", Grandtotal_txtbox.Text);
            cmd.Parameters.AddWithValue("@netbalance", Netbalance_txtbox.Text);
            cmd.Parameters.AddWithValue("@accountforaccounts", Accountforaccounts_txtbox.Text);
            cmd.Parameters.AddWithValue("@paidamt", PaidAmt_txtbox.Text);
            cmd.Parameters.AddWithValue("@balance", Balance_txtbox.Text);
            cmd.Parameters.AddWithValue("@setrack", setrack_txtbox.Text);
            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Saved");
            }

            con.Close();
            //SqlDataReader dataReader ;
            //SqlCommand command = new SqlCommand("ReadfromDummyTbl_Purchase", con);
            //command.CommandType = CommandType.StoredProcedure;
            //con.Open();


            //dataReader = command.ExecuteReader();

            //while (dataReader.Read())
            //{

            //    Purchaseid = dataReader["PurchaseID"].ToString();
            //    itemname = dataReader["ItemName"].ToString();
            //    company = dataReader["Company"].ToString();
            //    qty = dataReader["PQty"].ToString();
            //    batch = dataReader["Batch"].ToString();
            //    expD = dataReader["ExpDate"].ToString();
            //    rate = dataReader["Rate"].ToString();



            //    string connected= ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            //    SqlConnection connt = new SqlConnection(connected);

            //    SqlCommand command1 = new SqlCommand("tbl_Stockinsertfromdummy_purchase",connt );

            //    command1.CommandType = CommandType.StoredProcedure;
            //    connt.Open();
            //    command1.Parameters.AddWithValue("@purchaseid", Purchaseid.ToString());
            //    command1.Parameters.AddWithValue("@itemname", itemname.ToString());
            //    command1.Parameters.AddWithValue("@qty", qty.ToString());
            //    command1.Parameters.AddWithValue("@batch", batch.ToString());
            //    command1.Parameters.AddWithValue("@expd", expD.ToString());
            //    command1.Parameters.AddWithValue("@rate", rate.ToString());

            //    command1.ExecuteNonQuery();
            //    connt.Close();


            //}


            con.Close();



            SqlCommand command2 = new SqlCommand("TRUNCATETABLEtbl_Stock_dummy", con);
            command2.CommandType = CommandType.StoredProcedure;
            con.Open();
            command2.ExecuteNonQuery();
            con.Close();


            DisplayData();




            // connection.Open();
            // SqlCommand command1 = new SqlCommand(@"INSERT INTO tbl_Stock (PurchaseID,ItemName,Company,Batch,ExpDate,PQty,Rate)VALUES('" + Purchaseid + "','" + itemname + "','" + company + "','" + batch + "','" + expD + "','" + qty + "','" + rate + "')", connection);


            ClearTextBoxes();
            purchaseidincrement();
        }



        private void Clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            SqlCommand command2 = new SqlCommand("TRUNCATETABLEtbl_Stock_dummy", connection);
            command2.ExecuteNonQuery();
            connection.Close();
            DisplayData();

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            this.Refresh();

        }

        private void add2g_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i=0;i<dataGridView1.Rows.Count-1;i++)

            //{
            //    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MEDICALSHOP;Integrated Security=SSPI;");
            //    SqlCommand cmm = new SqlCommand(@"INSERT INTO tbl_Stock(ItemName,ItemDesc,Company,Batch,ExpDate,Pad,PQty,Qy,Rate,Discount,Amount,SalesRate)VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "','" + dataGridView1.Rows[i].Cells[9].Value + "','" + dataGridView1.Rows[i].Cells[10].Value + "','" + dataGridView1.Rows[i].Cells[11].Value + "')",conn);
            //    conn.Open();
            //    cmm.ExecuteNonQuery();
            //    conn.Close();

            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddItem_btn_Click(object sender, EventArgs e)
        {
            string itemno = "";
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlDataReader read;
            SqlCommand command = new SqlCommand("FetchItemNo", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@productname", itemname_txtboxauto.Text);
            read = command.ExecuteReader();
            while (read.Read())
            {
                itemno = read["PrdId"].ToString();
            }
            connection.Close();


            //  SqlCommand cmm = new SqlCommand(@"INSERT INTO tbl_Stock_dummy (PurchaseID,ItemName,Company,Batch,ExpDate,PQty,Rate,Amount)VALUES('" + PURCHASEid_auto_label.Text + "','" + itemname_txtboxauto.Text + "','" + company_textbox.Text + "','" + Batch_textbox.Text + "','" + Exp_textbox.Text + "','" + Pqty_textbox.Text + "','" + Rate_txtbox.Text + "','" + amt_textbox.Text + "')", conn);

            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmm = new SqlCommand("insert_into_Tablestockdummy", conn);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@purchaseid", PURCHASEid_auto_label.Text);
            cmm.Parameters.AddWithValue("@itemno", itemno);
            cmm.Parameters.AddWithValue("@itemname", itemname_txtboxauto.Text);
            cmm.Parameters.AddWithValue("@company", company_textbox.Text);
            cmm.Parameters.AddWithValue("@batch", Batch_textbox.Text);
            cmm.Parameters.AddWithValue("@expdate", ExpdateTimePicker.Text);
            cmm.Parameters.AddWithValue("@pqty", Pqty_textbox.Text);
            cmm.Parameters.AddWithValue("@rate", Rate_txtbox.Text);
            cmm.Parameters.AddWithValue("@amount", amt_textbox.Text);
            ///NEWLY ADDED as per requirements
            cmm.Parameters.AddWithValue("@MRP", MRP_TXTBOX.Text);
            cmm.Parameters.AddWithValue("@Rack", Rack_txtbox.Text);
            cmm.Parameters.AddWithValue("@SGST", sgst_textBox.Text);
            cmm.Parameters.AddWithValue("@HSNcode", Hsn_textbox.Text);
            cmm.Parameters.AddWithValue("@Discount", discount_txetbox.Text);
            cmm.Parameters.AddWithValue("@NetRate", Net_Rate_txtbox.Text);
            cmm.Parameters.AddWithValue("@Srate", Srate_txtbox.Text);
            cmm.Parameters.AddWithValue("@Free", Freetxtbox.Text);






            conn.Open();
            cmm.ExecuteNonQuery();
            conn.Close();
            DisplayData();
            itemname_txtboxauto.Clear();
            Batch_textbox.Clear();

            Rate_txtbox.Clear();
            MRP_TXTBOX.Clear();
            Rack_txtbox.Clear();
            sgst_textBox.Clear();
            discount_txetbox.Clear();
            Net_Rate_txtbox.Clear();
            Hsn_textbox.Clear();
            Srate_txtbox.Clear();
            Freetxtbox.Clear();
            Pqty_textbox.Clear();
            company_textbox.Clear();
            amt_textbox.Clear();
            conn.Open();

            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(conStr);
            //SqlCommand myCommand = new SqlCommand("select SUM(Amount)from tbl_Stock_dummy ", myConnection);
            SqlCommand myCommand = new SqlCommand("sumfromdummyStock ", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                Grandtotal_txtbox.Text = myReader.GetValue(0).ToString();
            }

            conn.Close();
            DisplayData();
            itemname_txtboxauto.Focus();
        }

        private void Rate_txtbox_Leave(object sender, EventArgs e)
        {
            try
            {
                string i = Pqty_textbox.Text;
                string j = Rate_txtbox.Text;
                 int k = Convert.ToInt32(i);
                int n = Convert.ToInt32(j);
                int c = k * n;
                string b = Convert.ToString(c);
                amt_textbox.Text = b;
            }
            catch(Exception x)

            { 
                if(x==null)
                {

                }
                else
                {
                    MessageBox.Show("Please Check Entry");
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                itemname_txtboxauto.Text = row.Cells["ItemName"].Value.ToString();
                Batch_textbox.Text = row.Cells["Batch"].Value.ToString();
                Pqty_textbox.Text = row.Cells["PQty"].Value.ToString();
                // company_textbox.Text=row.Cells["Company"].Value.ToString();
                //   Expdate_textbox.Text= row.Cells["Exp"].Value.ToString();
                // Rate_txtbox.Text=row.Cells["Rate"].Value.ToString();
                // amt_textbox.Text= row.Cells["Total"].Value.ToString();
                itemname_txtboxauto.Focus();
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteItemandStockupdatein_Purchase ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@PurchaseID", PURCHASEid_auto_label.Text);
            cmd.Parameters.AddWithValue("@Itemname", itemname_txtboxauto.Text);
            cmd.Parameters.AddWithValue("@Batch", Batch_textbox.Text);
            cmd.Parameters.AddWithValue("@Quantity", Pqty_textbox.Text);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Deleted");
                DisplayData();
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

        }

        private void sgst_textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                string rate = Rate_txtbox.Text;
                string sgst = sgst_textBox.Text;
                // string discount = discount_txetbox.Text;
                double Rate = Convert.ToDouble(rate);
                double Sgst = Convert.ToDouble(sgst);
                // double Discout= Convert.ToDouble(discount);
                double netrate = ((Rate * Sgst) / 100) + Rate;
                string Netrate = Convert.ToString(netrate);
                Net_Rate_txtbox.Text = Netrate;
            }
            catch(Exception x)
            {
                if(x==null)
                {

                }
                else
                {
                    MessageBox.Show("Please Check Entries");
                }
            }
        }

        private void discount_txetbox_Leave(object sender, EventArgs e)
        {
            try
            {
                string NetRATE = Net_Rate_txtbox.Text;
                string Discount = discount_txetbox.Text;
                double netrate = Convert.ToDouble(NetRATE);
                double discount = Convert.ToDouble(Discount);

                double d = discount / 100;
                double srate = (netrate - d);
                string salesrate = Convert.ToString(srate);
                Srate_txtbox.Text = salesrate;
            }
            catch(Exception x)
            {
                MessageBox.Show("Please check Entry");
            }
        }

        private void hsncode()
        {
            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand("FetchHsnCode", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@itemname", itemname_txtboxauto.Text);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                String i = myReader["HSNCode"].ToString();
                String j = myReader["RackNo"].ToString();
                String k = myReader["ManufactureName"].ToString();
                //  String K = myReader["GST"].ToString();
                Hsn_textbox.Text = i;
                Rack_txtbox.Text = j;
                company_textbox.Text = k.ToString();
                //sgst_textBox.Text = K;

            }
            myConnection.Close();
        }

        private void itemname_txtboxauto_Leave(object sender, EventArgs e)
        {
            hsncode();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Freetxtbox_Leave(object sender, EventArgs e)
        {
            add_btn.Focus();
        }

        private void StripNumtxtbox_Leave(object sender, EventArgs e)
        {

            if (Pcounttxtbox != null || StripNumtxtbox != null)
            {
                float productCount = Convert.ToInt64(Pcounttxtbox.Text);
                float Stripnumber = Convert.ToInt64(StripNumtxtbox.Text);
                float productQuantity = productCount * Stripnumber;
                Pqty_textbox.Text = productQuantity.ToString();

            }

            else
            {

            }


        }




    }
}




