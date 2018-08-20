using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


using System.Web.Configuration;

namespace MEDICALSHOP1
{
    public partial class Sales : Form
    {

        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        string itemno = "";
        string quantity_UPDATE = "";
        string batch_UPDATE = "";

        public Sales()
        {


            //string quantity = qty_txtbox.Text;
            //string batch = Batchno_txtbox.Text;
            InitializeComponent();
            billincrement();
            autoTextbox();
            itemauto_textbox.Select();


        }

        public void autoTextbox()
        {

            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("autoTextbox_sales", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                itemauto_textbox.AutoCompleteCustomSource = MyCollection;
                con.Close();
                itemauto_textbox.Focus();
            }
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
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Tbl_SalesItem_DUMMY_sales ", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            //this.dataGridView1.Sort(this.dataGridView1.Columns["SlNo"], ListSortDirection.Descending);
            con.Close();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["ITEMNAME"].Width = 274;
            dataGridView1.Columns["HSNCode"].Width = 86;
            dataGridView1.Columns["COMPANY"].Width = 90;
            dataGridView1.Columns["BATCH"].Width = 90;
            dataGridView1.Columns["EXP DATE"].Width = 90;
            dataGridView1.Columns["QUANTITY"].Width = 90;
            dataGridView1.Columns["RATE"].Width = 90;
            dataGridView1.Columns["MRP"].Width = 90;
            dataGridView1.Columns["GST"].Width = 90;
            dataGridView1.Columns["DISCOUNT"].Width = 90;
            dataGridView1.Columns["TOTAL"].Width = 70;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            //  this.dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            //   dataGridView1.SelectedCells[0].Style= new DataGridViewCellStyle { ForeColor = Color.Black };
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Bold);

        }





        public void grandtotal()
        {

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);

            }
            Grandtotal_txtbox.Text = sum.ToString();



        }

        private bool WithErrors()///TEXTBOX CONTROL VALIDATION
        {
            // if (Purchaseid_txtbox.Text.Trim() == String.Empty)
            //   return true; // Returns true if no input or only space is found
            if (customername_txtbox.Text.Trim() == String.Empty)
                return true;
            if (UserName_txtbox.Text.Trim() == String.Empty)
                return true;

            if (Doctor_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Patients_txtbox.Text.Trim() == String.Empty)
                return true;
            if (CashDiscount_txtbox.Text.Trim() == String.Empty)
                return true;
            if (SalesReturn_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Notes_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Grandtotal_txtbox.Text.Trim() == String.Empty)
                return true;
            if (CashReceived_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Balance_txtbox.Text.Trim() == String.Empty)
                return true;

            // Other textBoxes.

            return false;
        }



        public void billincrement()
        {
            SqlDataReader myReader = null;
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection myConnection = new SqlConnection(conStr);
            // SqlCommand myCommand = new SqlCommand("select BillNo from  Tbl_Sales", myConnection);
            SqlCommand myCommand = new SqlCommand("billincrement_sales", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                String i = myReader["BillNo"].ToString();
                int pid = Convert.ToInt32(i);
                int billid = ++pid;
                label1.Text = billid.ToString();


            }
            myConnection.Close();
        }


        private void Save_button_Click(object sender, EventArgs e)
        {
            //FieldValidatorMsg_label.Visible = true;
            //if (WithErrors())
            //{
            //    FieldValidatorMsg_label.Text = "ALL FIELDS ARE REQUIRED";
            //}
            //else
            //{

            //    FieldValidatorMsg_label.Visible = false;
            //  Do whatever here...Submit

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("Sales_insert_bill", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@purchaseid", Purchaseid_txtbox.Text);
            cmd.Parameters.AddWithValue("@customername", customername_txtbox.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker.Text);
            cmd.Parameters.AddWithValue("@username", UserName_txtbox.Text);
            cmd.Parameters.AddWithValue("@doctor", Doctor_txtbox.Text);
            cmd.Parameters.AddWithValue("@patient", Patients_txtbox.Text);
            cmd.Parameters.AddWithValue("@cashdiscount", CashDiscount_txtbox.Text);
            cmd.Parameters.AddWithValue("@salesreturn", SalesReturn_txtbox.Text);
            cmd.Parameters.AddWithValue("@notes", Adj_textbox.Text);
            cmd.Parameters.AddWithValue("@adj", Notes_txtbox.Text);
            cmd.Parameters.AddWithValue("@grandtotal", Grandtotal_txtbox.Text);
            cmd.Parameters.AddWithValue("@cashreceived", CashReceived_txtbox.Text);

            cmd.Parameters.AddWithValue("@balance", Balance_txtbox.Text);

            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Saved");
            }

            con.Close();
            //data insert from dummy table

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand command = new SqlCommand("readfromsalesitemdummy_sales ", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                string itemname = reader["ItemName"].ToString();
                string qty = reader["Qty"].ToString();
                string batch = reader["Batch"].ToString();
                string expD = reader["Exp"].ToString();
                string rate = reader["Rate"].ToString();

                connection.Close();


                connection.Open();
                //SqlCommand command1 = new SqlCommand(@"INSERT INTO Tbl_SalesItem (BillNo,ItemName,Batch,Exp,Qty,Rate,Total)VALUES('" + label1.Text + "','" + itemname + "','" +batch+ "','" + expD + "','" + qty + "','" + rate + "','" + Grandtotal_txtbox.Text+ "')", connection);
                SqlCommand command1 = new SqlCommand("insertsalesitem_sales", connection);

                command1.CommandType = CommandType.StoredProcedure;
                command1.Parameters.AddWithValue("@billno", label1.Text);
                command1.Parameters.AddWithValue("@itemname", itemname);
                command1.Parameters.AddWithValue("@batch", batch);
                command1.Parameters.AddWithValue("@qty", qty);
                command1.Parameters.AddWithValue("@exp", expD);
                command1.Parameters.AddWithValue("@rate", rate);
                command1.Parameters.AddWithValue("@total", Grandtotal_txtbox.Text);





                command1.ExecuteNonQuery();


                SqlCommand command2 = new SqlCommand("trunicateSalesDummy_Sales", connection);
                command2.ExecuteNonQuery();

                connection.Close();
                DisplayData();

            }





            billincrement();
            ClearTextBoxes();
            //DisplayData();

        }



        public void savedata()
        {

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("Sales_insert_bill", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@purchaseid", Purchaseid_txtbox.Text);
            cmd.Parameters.AddWithValue("@customername", customername_txtbox.Text);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime((dateTimePicker.Value)));
            cmd.Parameters.AddWithValue("@username", UserName_txtbox.Text);
            cmd.Parameters.AddWithValue("@doctor", Doctor_txtbox.Text);
            cmd.Parameters.AddWithValue("@patient", Patients_txtbox.Text);
            cmd.Parameters.AddWithValue("@cashdiscount", CashDiscount_txtbox.Text);
            cmd.Parameters.AddWithValue("@salesreturn", SalesReturn_txtbox.Text);
            cmd.Parameters.AddWithValue("@notes", Adj_textbox.Text);
            cmd.Parameters.AddWithValue("@adj", Notes_txtbox.Text);
            cmd.Parameters.AddWithValue("@grandtotal", Grandtotal_txtbox.Text);
            cmd.Parameters.AddWithValue("@cashreceived", CashReceived_txtbox.Text);

            cmd.Parameters.AddWithValue("@balance", Balance_txtbox.Text);

            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Saved");
            }

            con.Close();
            //data insert from dummy table

            ClearTextBoxes();

            billincrement();

            DisplayData();

        }










        private void itemauto_textbox_Leave(object sender, EventArgs e)//ITEM TEXTBOX LEAVE FUNCTION
        {
            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(conStr);
            // SqlCommand myCommand = new SqlCommand("select Batch,ExpDate,PQty,Rate from  Tbl_Stock where ItemName='" + itemauto_textbox.Text+ "'", myConnection);
            SqlCommand myCommand = new SqlCommand("itemautoTxtbox_Leave_Sales", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@itemname", itemauto_textbox.Text);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                // String Batchno = myReader["Batch"].ToString();

                String ExpDate = myReader["ExpDate"].ToString();

                // String qty = myReader["PQty"].ToString();

                string rate = myReader["SalesRate"].ToString();
                itemno = myReader["ItemNo"].ToString();


                company_textbox.Text = myReader["Company"].ToString();
                sgst_textBox.Text = myReader["SGST"].ToString();
                MRP_TXTBOX.Text = myReader["MRP"].ToString();
                Rack_txtbox.Text = myReader["Rack"].ToString();
                discount_txetbox.Text = myReader["Discount"].ToString();
                Hsn_textbox.Text = myReader["HSN Code"].ToString();
                // Batchnocombobox.Text = Batchno.ToString();
                Expdate_textbox.Text = ExpDate.ToString();
                // qty_txtbox.Text = qty.ToString();
                Rate_txtbox.Text = rate.ToString();
                company_textbox.Focus();
                if (itemauto_textbox.Text == null)
                {
                    //donothing
                }
                else

                { }
                //Outofstock();



            }
        }

        private void qty_txtbox_Leave(object sender, EventArgs e)
        {
            // QuantityCheckonSales();

            if (Pqty_textbox.Text == "")
            {
                itemauto_textbox.Select();
            }
            else
            {
                QuantityCheckonSales();
                if (Pqty_textbox.Text == "")
                {

                }
                else
                {
                    double qty = Convert.ToInt32(Pqty_textbox.Text);
                    double rated = Convert.ToDouble(Rate_txtbox.Text);
                    double amount = qty * rated;
                    amt_textbox.Text = amount.ToString();
                }


            }


        }
    
            
        

        private void ADDItem_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStr);
            // SqlCommand cmm = new SqlCommand(@"INSERT INTO Tbl_SalesItem_DUMMY (BillNo,ItemName,Batch,Exp,Qty,Rate,Total)VALUES('" + label1.Text + "','"+ itemauto_textbox.Text + "','" +Batchno_txtbox.Text+"','"+Expdate_textbox.Text+"','" + qty_txtbox.Text + "','" + Price_txtbox.Text + "','"  +Amount_txtbox.Text+ "')", conn);

            SqlCommand cmm = new SqlCommand("insertintosalesdummy_Sales", conn);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@itemno", itemno);
            cmm.Parameters.AddWithValue("@billno", label1.Text);
            cmm.Parameters.AddWithValue("@itemname", itemauto_textbox.Text);
            cmm.Parameters.AddWithValue("@batch", Batchnocombobox.Text);
            cmm.Parameters.AddWithValue("@Company", company_textbox.Text);
            cmm.Parameters.AddWithValue("@exp", Expdate_textbox.Text);
            cmm.Parameters.AddWithValue("@qty", Pqty_textbox.Text);
            cmm.Parameters.AddWithValue("@rate", Rate_txtbox.Text);
            cmm.Parameters.AddWithValue("@total", amt_textbox.Text);
            //New updation on 18/10/2017 as per requirements
            cmm.Parameters.AddWithValue("@MRP", MRP_TXTBOX.Text);
            cmm.Parameters.AddWithValue("@Discount", discount_txetbox.Text);
            cmm.Parameters.AddWithValue("@SGST", sgst_textBox.Text);

            cmm.Parameters.AddWithValue("@HSNCode", Hsn_textbox.Text);



            conn.Open();
            cmm.ExecuteNonQuery();
            conn.Close();
            DisplayData();
            ClearTextBoxes();
            conn.Open();

            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand("sumtotal_Sales", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                Grandtotal_txtbox.Text = myReader.GetValue(0).ToString();
            }

            conn.Close();
            itemauto_textbox.Focus();
            itemauto_textbox.Focus();
            itemauto_textbox.Focus();
            itemauto_textbox.Focus();
            Rate_txtbox.Clear();
            MRP_TXTBOX.Clear();
            Rack_txtbox.Clear();
            sgst_textBox.Clear();
            discount_txetbox.Clear();
            Hsn_textbox.Clear();
            amt_textbox.Clear();

            itemauto_textbox.Focus();
        }

        private void NextSale_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conStr);
            SqlCommand command2 = new SqlCommand("TRUNCATE_Tbl_SalesItem_DUMMY;", connection);
            connection.Open();
            command2.ExecuteNonQuery();
            this.Refresh();
            ClearTextBoxes();
            DisplayData();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICALSHOPDataSet.Tbl_SalesItem_DUMMY' table. You can move, or remove it, as needed.
            //this.tbl_SalesItem_DUMMYTableAdapter.Fill(this.mEDICALSHOPDataSet.Tbl_SalesItem_DUMMY);
            // TODO: This line of code loads data into the 'mEDICALSHOPDataSet.Tbl_SalesItem_DUMMY' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'mEDICALSHOPDataSet.Tbl_SalesItem' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'mEDICALSHOPDataSet.Tbl_SalesItem_DUMMY' table. You can move, or remove it, as needed.

        }

        private void CashReceived_txtbox_Leave(object sender, EventArgs e)
        {
            if (Grandtotal_txtbox.Text == "")
            {

            }
            else
            {
                try
                {
                    string a = Grandtotal_txtbox.Text;
                    string b = CashReceived_txtbox.Text;
                    Decimal a1 = Convert.ToDecimal(a);
                    Decimal b1 = Convert.ToDecimal(b);
                    Decimal c = 0;
                    c = b1 - a1;
                    Balance_txtbox.Text = Convert.ToString(c);
                }
                catch (Exception x)
                {
                    if (x == null)
                    {

                    }
                    else
                    { MessageBox.Show("Check Entry"); }

                }

            }
        }


        public void print()
        {

            billprint print = new billprint();
            print.TopMost = true;
            print.Show();

        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            savedata();
            // printit();
            print();
            //QuantityUpdateINStock();

           
            clearSalesDummy();




        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////QUANTITY UPDATE IN STOCK
        //public void QuantityUpdateINStock()
        //{
        //    string itno="";//itemno
        //    SqlDataReader reader_stock;
        //    string stockconnection = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        //    SqlConnection stockcon = new SqlConnection(stockconnection);
        //    stockcon.Open();
        //    SqlCommand commandstock = new SqlCommand("readfromsalesdummyforitemnameandbatch",stockcon);
        //    commandstock.CommandType = CommandType.StoredProcedure;
        //   reader_stock= commandstock.ExecuteReader();
        //    while(reader_stock.Read())
        //    {

        //        quantity_UPDATE = reader_stock["Qty"].ToString();
        //        batch_UPDATE = reader_stock["Batch"].ToString();
        //        itno = reader_stock["ItemNo"].ToString();

        //        string QuantityUpdateConnection = ConfigurationManager.ConnectionStrings["coonstring"].ToString();

        //        // int noitem = Convert.ToInt32(itemno.ToString());

        //        SqlConnection connection = new SqlConnection(QuantityUpdateConnection);
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("update_quantity_in_stock", connection);
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.Parameters.AddWithValue("@quantity", quantity_UPDATE.ToString());
        //        command.Parameters.AddWithValue("@itemno", itno.ToString());
        //        command.Parameters.AddWithValue("@batch", batch_UPDATE.ToString());
        //        command.ExecuteNonQuery();
        //        connection.Close();





        //    }
        //    reader_stock.Close();








        //}
        //OUT OF STOCK
        public void Outofstock()
        {
            if (itemauto_textbox.Text == "")
            {

            }
            else
            {
                string productlimit = "";
                // string itemname = itemauto_textbox.Text;
                string quantity = "";


                //FOR FETCHING MIN LEVEL FROM PRODUCT MASTER

                SqlDataReader read;
                string connect = ConfigurationManager.ConnectionStrings["coonstring"].ToString();

                SqlConnection connected = new SqlConnection(connect);
                connected.Open();
                SqlCommand command = new SqlCommand("fetch_outofstockfromproductmaster", connected);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@itemname", itemauto_textbox.Text);
                // command.ExecuteNonQuery();
                read = command.ExecuteReader();
                if (read.Read())
                {
                    productlimit = read["MinLevel"].ToString();
                }
                read.Close();
                connected.Close();

                //FOR FETCHING PRODUCT QUANTITY FROM STOCK
                SqlDataReader Rread;
                string Connect = ConfigurationManager.ConnectionStrings["coonstring"].ToString();

                SqlConnection Connected = new SqlConnection(Connect);
                Connected.Open();
                SqlCommand Command = new SqlCommand("FetchQuantityfromstock", Connected);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@itemname", itemauto_textbox.Text);
                Command.Parameters.AddWithValue("@Batch", Batchnocombobox.Text);
                // command.ExecuteNonQuery();
                Rread = Command.ExecuteReader();
                if (Rread.Read())
                {
                    quantity = Rread["PQty"].ToString();
                }
                Rread.Close();
                Connected.Close();


                int Quantity = Convert.ToInt32(quantity);
                int ProductLimit = Convert.ToInt32(productlimit.ToString());

                if (Quantity >= ProductLimit)
                {
                    //MessageBox.Show("Available Stock:"+ Quantity);
                }
                else
                {
                    MessageBox.Show("OUT OF STOCK !" + Quantity);
                    itemauto_textbox.BackColor = Color.Red;

                }

            }
        }

        private void qty_txtbox_Enter(object sender, EventArgs e)
        {
            if (Pqty_textbox.Text == "")
            {

            } else
            {
                Outofstock();
            }

        }

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            //int qty = Convert.ToInt32(qty_txtbox.Text);
            //int rated = Convert.ToInt32(Price_txtbox.Text);
            //int amount = qty * rated;
            //Amount_txtbox.Text = amount.ToString();
        }

        private void Amount_txtbox_Enter(object sender, EventArgs e)
        {
            //Outofstock();
        }

        public void QuantityCheckonSales()
        {
            string quantitytextbox = Pqty_textbox.Text;

            if (quantitytextbox == "")
            {

            }
            else
            {
                SqlDataReader Rread;
                string Connect = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
                string Qquantity = "";


                SqlConnection Connected = new SqlConnection(Connect);
                Connected.Open();
                SqlCommand Command = new SqlCommand("FetchQuantityfromstock", Connected);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@itemname", itemauto_textbox.Text);
                Command.Parameters.AddWithValue("@Batch", Batchnocombobox.Text);
                // command.ExecuteNonQuery();
                Rread = Command.ExecuteReader();
                if (Rread.Read())
                {
                    Qquantity = Rread["PQty"].ToString();
                }
                Rread.Close();
                Connected.Close();

                int i = Convert.ToInt32(Qquantity);
                int j = Convert.ToInt32(quantitytextbox);


                if (j > i)
                {
                    Pqty_textbox.Clear();
                    itemauto_textbox.BackColor = Color.Red;
                    MessageBox.Show("Out Of Stock");
                    MessageBox.Show("Stock Available:" + Qquantity);
                }

            }
        }

        private void itemauto_textbox_TextChanged(object sender, EventArgs e)
        {
            itemauto_textbox.BackColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                itemauto_textbox.Text = row.Cells["ItemName"].Value.ToString();
                Batchnocombobox.Text = row.Cells["Batch"].Value.ToString();
                Pqty_textbox.Text = row.Cells["Quantity"].Value.ToString();
                // company_textbox.Text=row.Cells["Company"].Value.ToString();
                //   Expdate_textbox.Text= row.Cells["Exp"].Value.ToString();
                // Rate_txtbox.Text=row.Cells["Rate"].Value.ToString();
                // amt_textbox.Text= row.Cells["Total"].Value.ToString();
                itemauto_textbox.Focus();
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteItemandStockupdatein_Sales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@billno", label1.Text);
            cmd.Parameters.AddWithValue("@Itemname", itemauto_textbox.Text);
            cmd.Parameters.AddWithValue("@Batch", Batchnocombobox.Text);
            cmd.Parameters.AddWithValue("@Quantity", Pqty_textbox.Text);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            con.Close();
            DisplayData();
            itemauto_textbox.Clear();
            Hsn_textbox.Clear();
           // Batchnocombobox.Clear();
            company_textbox.Clear();
            Expdate_textbox.Clear();
            Pqty_textbox.Clear();
            Rack_txtbox.Clear();
            Rate_txtbox.Clear();
            MRP_TXTBOX.Clear();
            sgst_textBox.Clear();
            discount_txetbox.Clear();
            amt_textbox.Clear();

            ClearTextBoxes();
        }


       
        private void clearSalesDummy()
            {
            SqlConnection connection = new SqlConnection(conStr);
            SqlCommand command2 = new SqlCommand("TRUNCATE_Tbl_SalesItem_DUMMY;", connection);
            connection.Open();
            command2.ExecuteNonQuery();
            this.Refresh();
            ClearTextBoxes();
            DisplayData();
            connection.Close();

        }

        public void BATCHcombobox()
        {

         //   SqlDataReader Rread;
            string Connect = ConfigurationManager.ConnectionStrings["coonstring"].ToString();

            DataSet ds = new DataSet();

            SqlConnection Connected = new SqlConnection(Connect);
            Connected.Open();
            string oString = "select Batch from tbl_Stock where ItemName=@itemname and company=@comp";
            SqlCommand oCmd = new SqlCommand(oString, Connected);
     
            oCmd.Parameters.AddWithValue("@itemname", itemauto_textbox.Text);
            oCmd.Parameters.AddWithValue("@comp", company_textbox.Text);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = oCmd;
            da.Fill(ds);
            Batchnocombobox.DisplayMember = "Batch";
            // comboBox1.ValueMember = "ID";
            Batchnocombobox.DataSource = ds.Tables[0];

            // command.ExecuteNonQuery();
           
            Connected.Close();





        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GrandTotal_label_Click(object sender, EventArgs e)
        {

        }

        private void Cashreceived_label_Click(object sender, EventArgs e)
        {

        }

        private void Balance_label_Click(object sender, EventArgs e)
        {

        }

        private void company_textbox_Leave(object sender, EventArgs e)
        {
            BATCHcombobox();
        }

        private void Batchnocombobox_Leave(object sender, EventArgs e)
        {
            Outofstock();
        }

        private void amt_textbox_Leave(object sender, EventArgs e)
        {
            ADD_ITM_BTN.Focus();
        }
    }

   

}
