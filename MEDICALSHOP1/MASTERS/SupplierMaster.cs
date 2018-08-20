using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MEDICALSHOP1
{
    public partial class SupplierMaster : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public SupplierMaster()
        {
           
            InitializeComponent();
            DisplayData();
        }

        
        public void DisplayData()///display data function
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            DataTable dt = new DataTable();
            // adapt = new SqlDataAdapter("select ItemName,Batch,ExpDate,PQty,Rate,Company from tbl_Stock_dummy  ", con);
            adapt = new SqlDataAdapter("select Supplierid,SupplierName,Address,Mobile from Tbl_SupplierMaster  ", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            // this.dataGridView1.Sort(this.dataGridView1.Columns["RowId"], ListSortDirection.Descending);
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










        private void Save_btn_Click(object sender, EventArgs e)
        {///RADIO BUTTON DAY SELECTION  
            string day = "";
            if (sun_rad.Checked)
            {
                day = sun_rad.Text;
            }

            if (mon_rad.Checked)
            {
                day = mon_rad.Text;
            }
            if (tue_rad.Checked)
            {
                day = tue_rad.Text;
            }
            if (wed_radio.Checked)
            {
                day = wed_radio.Text;
            }
            if (thu_rad.Checked)
            {
                day = thu_rad.Text;
            }
            if (fri_rad.Checked)
            {
                day = fri_rad.Text;
            }
            if (sat_rad.Checked)
            {
                day = sat_rad.Text;
            }
            ///END

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("SupplierMaster", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@purchaseid",PURCHASEid_auto_label.Text);
            cmd.Parameters.AddWithValue("@suppliername", Supplier_txtb.Text);
            cmd.Parameters.AddWithValue("@address",Add_txtb.Text);
            cmd.Parameters.AddWithValue("@email", email_txtb.Text);
            cmd.Parameters.AddWithValue("@gnst", gsttxb.Text);
            cmd.Parameters.AddWithValue("@type", typetxtb.Text);
            cmd.Parameters.AddWithValue("@druglic",drugtxtb.Text);
            cmd.Parameters.AddWithValue("@contactpers", conbttxtb.Text);
            cmd.Parameters.AddWithValue("@reference",Reftxtb.Text);
            cmd.Parameters.AddWithValue("@description", descriptiontxtb.Text);
            cmd.Parameters.AddWithValue("@firstvisitdate", firstvisttxtb.Text);
            cmd.Parameters.AddWithValue("@duration", durtxtb.Text);
            cmd.Parameters.AddWithValue("@note", notetxtb.Text);
            cmd.Parameters.AddWithValue("@phoneoffi", phtxtb.Text);
            cmd.Parameters.AddWithValue("@phoneres", phrestxtb.Text);
            cmd.Parameters.AddWithValue("@mobile", mobtxtb.Text);
            cmd.Parameters.AddWithValue("@fax", faxtxtb.Text);
            cmd.Parameters.AddWithValue("@cst", cstbtxt.Text);
            cmd.Parameters.AddWithValue("@descr", destxtb.Text);
            cmd.Parameters.AddWithValue("@visitdays",day);
            
            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Saved");

                DisplayData();

                ClearTextBoxes();
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            sun_rad.Checked = false;
            mon_rad.Checked = false;
            tue_rad.Checked = false;
            wed_radio.Checked = false;
            thu_rad.Checked = false;
            fri_rad.Checked = false;
            sat_rad.Checked = false;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
               SupplierID_txtbox.Text= row.Cells["Supplierid"].Value.ToString();
                Supplier_txtb.Text = row.Cells["SupplierName"].Value.ToString();
                Add_txtb.Text = row.Cells["Address"].Value.ToString();
              //  email_txtb.Text = row.Cells["Email"].Value.ToString();
             //   gsttxb.Text = row.Cells["GSTN"].Value.ToString();
             //   typetxtb.Text = row.Cells["Type"].Value.ToString();
              //  drugtxtb.Text = row.Cells["DrugLicense"].Value.ToString();
               // conbttxtb.Text = row.Cells["ContactPerson"].Value.ToString();
               // Reftxtb.Text = row.Cells["Reference"].Value.ToString();
              //  descriptiontxtb.Text = row.Cells["Description"].Value.ToString();
              //  firstvisttxtb.Text = row.Cells["FirstVisitDate"].Value.ToString();
              //  durtxtb.Text = row.Cells["Duration"].Value.ToString();
              //  notetxtb.Text = row.Cells["Note"].Value.ToString();
              //  phtxtb.Text = row.Cells["PhoneNooff"].Value.ToString();
                mobtxtb.Text = row.Cells["Mobile"].Value.ToString();
               // phrestxtb.Text = row.Cells["PhoneRes"].Value.ToString();
              //  faxtxtb.Text = row.Cells["FAX"].Value.ToString();
               // cstbtxt.Text = row.Cells["CSTNo"].Value.ToString();
               // descriptiontxtb.Text = row.Cells["Descr"].Value.ToString();
                //radiodata = row.Cells["VisitDays"].ToString();
            }
        }

        private void SupplierID_txtbox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("FetchSupplierDetailswithsuppliierId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@supplierid", SupplierID_txtbox.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            string radiodata = "";
            while (reader.Read())
            {
                Supplier_txtb.Text = reader["SupplierName"].ToString();
                Add_txtb.Text = reader["Address"].ToString();
                email_txtb.Text = reader["Email"].ToString();
                gsttxb.Text = reader["GSTN"].ToString();
                typetxtb.Text = reader["Type"].ToString();
                drugtxtb.Text = reader["DrugLicense"].ToString();
                conbttxtb.Text = reader["ContactPerson"].ToString();
                Reftxtb.Text = reader["Reference"].ToString();
                descriptiontxtb.Text = reader["Description"].ToString();
                firstvisttxtb.Text = reader["FirstVisitDate"].ToString();
                durtxtb.Text = reader["Duration"].ToString();
                notetxtb.Text = reader["Note"].ToString();
                phtxtb.Text = reader["PhoneNooff"].ToString();
                mobtxtb.Text = reader["Mobile"].ToString();
                phrestxtb.Text = reader["PhoneRes"].ToString();
                faxtxtb.Text = reader["FAX"].ToString();
                cstbtxt.Text = reader["CSTNo"].ToString();
                descriptiontxtb.Text = reader["Descr"].ToString();
                radiodata = reader["VisitDays"].ToString();
            }
            if (radiodata == "SUN")
            {
                sun_rad.Checked = true;
            }
            if (radiodata == "MON")
            {
                mon_rad.Checked = true;
            }

            if (radiodata == "TUE")
            {
                tue_rad.Checked = true;
            }
            if (radiodata == "WED")
            {
                wed_radio.Checked = true;
            }
            if (radiodata == "THU")
            {
                thu_rad.Checked = true;
            }
            if (radiodata == "FRI")
            {
                fri_rad.Checked = true;
            }
            if (radiodata == "SAT")
            {
                sat_rad.Checked = true;
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            string day = "";
            if (sun_rad.Checked)
            {
                day = sun_rad.Text;
            }

            if (mon_rad.Checked)
            {
                day = mon_rad.Text;
            }
            if (tue_rad.Checked)
            {
                day = tue_rad.Text;
            }
            if (wed_radio.Checked)
            {
                day = wed_radio.Text;
            }
            if (thu_rad.Checked)
            {
                day = thu_rad.Text;
            }
            if (fri_rad.Checked)
            {
                day = fri_rad.Text;
            }
            if (sat_rad.Checked)
            {
                day = sat_rad.Text;
            }
            ///END

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("SupplierMaster_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@purchaseid",PURCHASEid_auto_label.Text);
            cmd.Parameters.AddWithValue("@supplierid", SupplierID_txtbox.Text);
            cmd.Parameters.AddWithValue("@suppliername", Supplier_txtb.Text);
            cmd.Parameters.AddWithValue("@address", Add_txtb.Text);
            cmd.Parameters.AddWithValue("@email", email_txtb.Text);
            cmd.Parameters.AddWithValue("@gnst", gsttxb.Text);
            cmd.Parameters.AddWithValue("@type", typetxtb.Text);
            cmd.Parameters.AddWithValue("@druglic", drugtxtb.Text);
            cmd.Parameters.AddWithValue("@contactpers", conbttxtb.Text);
            cmd.Parameters.AddWithValue("@reference", Reftxtb.Text);
            cmd.Parameters.AddWithValue("@description", descriptiontxtb.Text);
            cmd.Parameters.AddWithValue("@firstvisitdate", firstvisttxtb.Text);
            cmd.Parameters.AddWithValue("@duration", durtxtb.Text);
            cmd.Parameters.AddWithValue("@note", notetxtb.Text);
            cmd.Parameters.AddWithValue("@phoneoffi", phtxtb.Text);
            cmd.Parameters.AddWithValue("@phoneres", phrestxtb.Text);
            cmd.Parameters.AddWithValue("@mobile", mobtxtb.Text);
            cmd.Parameters.AddWithValue("@fax", faxtxtb.Text);
            cmd.Parameters.AddWithValue("@cst", cstbtxt.Text);
            cmd.Parameters.AddWithValue("@descr", destxtb.Text);
            cmd.Parameters.AddWithValue("@visitdays", day);

            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data updated");

                DisplayData();
                ClearTextBoxes();

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("SupplierMaster_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
          
            cmd.Parameters.AddWithValue("@supplierid", SupplierID_txtbox.Text);
            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Deleted");

                DisplayData();
                ClearTextBoxes();

            }
        }
    }
}
