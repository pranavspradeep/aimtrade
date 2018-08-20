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
    public partial class ProductMaster : Form
    {

        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public ProductMaster()
        {
            InitializeComponent();
            radiobuttondata();
            DisplayData();

        }

        public void radiobuttondata()
        {
            string valueofradiobuttons = null;
            if (General_radio.Checked)
            {
                valueofradiobuttons = General_radio.Text;

            }
            if (Medical_radio.Checked)
            {
                valueofradiobuttons = Medical_radio.Text;
            }




        }
        public void DisplayData()///display data function
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("ProductMasterDatagridDisplay", con);
            adapt.Fill(dt);
            Productmaster_datagrid.DataSource = dt;
            // this.Productmaster_datagrid.Sort(this.Productmaster_datagrid.Columns["PrdId"], ListSortDirection.Descending);
            con.Close();
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







        private bool WithErrors()///TEXTBOX CONTROL VALIDATION
        {
            // if (Purchaseid_txtbox.Text.Trim() == String.Empty)
            //   return true; // Returns true if no input or only space is found
            if (Productname_txtbox.Text.Trim() == String.Empty)
                return true;
            if (Manufacturerename_txtbox.Text.Trim() == String.Empty)
                return true;

            if (GenericName_txtbox.Text.Trim() == String.Empty)
                return true;
            if (shedule_txbox.Text.Trim() == String.Empty)
                return true;
            if (Rack_txtbox.Text.Trim() == String.Empty)
                return true;
            if (min_txtbox.Text.Trim() == String.Empty)
                return true;
            if (max_textbox.Text.Trim() == String.Empty)
                return true;
            if (HSN_textbox.Text.Trim() == String.Empty)
                return true;
            if (gst_txtbox.Text.Trim() == String.Empty)
                return true;
            if (subhead_txtbox.Text.Trim() == String.Empty)
                return true;

            // Other textBoxes.

            return false;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {






            //label3.Visible = true;
            //if (WithErrors())
            //{
            //    label3.Text = "ALL FIELDS ARE REQUIRED";
            //}
            //else
            //{
            ///RADIO 


        }



        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productmaster_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayData();
        }

        private void Save_Button_Click_1(object sender, EventArgs e)
        {
            string valueofradiobuttons = null;
            if (General_radio.Checked)
            {
                valueofradiobuttons = General_radio.Text;

            }
            if (Medical_radio.Checked)
            {
                valueofradiobuttons = Medical_radio.Text;
            }
            label3.Visible = false;
            // Do whatever here... Submit

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("ProductMaster_proc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@purchaseid", Purchaseid_txtbox.Text);
            cmd.Parameters.AddWithValue("@productname", Productname_txtbox.Text);
            cmd.Parameters.AddWithValue("@subcategory", subcat_textbox.Text);
            cmd.Parameters.AddWithValue("@manaufaturername", Manufacturerename_txtbox.Text);
            cmd.Parameters.AddWithValue("@category", valueofradiobuttons);
            cmd.Parameters.AddWithValue("@genericname", GenericName_txtbox.Text);
            cmd.Parameters.AddWithValue("@shedule", shedule_txbox.Text);
            cmd.Parameters.AddWithValue("@date", Rack_txtbox.Text);
            cmd.Parameters.AddWithValue("@minlevel", min_txtbox.Text);
            cmd.Parameters.AddWithValue("@maxlevel", max_textbox.Text);
            cmd.Parameters.AddWithValue("@hsn", HSN_textbox.Text);
            cmd.Parameters.AddWithValue("@gst", gst_txtbox.Text);
            cmd.Parameters.AddWithValue("@sunhead", subhead_txtbox.Text);

            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Saved");

                ClearTextBoxes();

                DisplayData();
            }
        }

        private void Close_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productmaster_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Productmaster_datagrid.Rows[e.RowIndex];

                Productname_txtbox.Text = row.Cells["ProductName"].Value.ToString();
                Manufacturerename_txtbox.Text = row.Cells["ManufactureName"].Value.ToString();
                GenericName_txtbox.Text = row.Cells["GenericName"].Value.ToString();
                shedule_txbox.Text = row.Cells["Schedule"].Value.ToString();
                Rack_txtbox.Text = row.Cells["RackNo"].Value.ToString();
                min_txtbox.Text = row.Cells["MinLevel"].Value.ToString();
                max_textbox.Text = row.Cells["MaxLevel"].Value.ToString();
                HSN_textbox.Text = row.Cells["HSNCode"].Value.ToString();
                subcat_textbox.Text= row.Cells["SubCategory"].Value.ToString();
                gst_txtbox.Text= row.Cells["GST"].Value.ToString();
                subhead_txtbox.Text= row.Cells["SubHead"].Value.ToString();
                CurrentPID_Text.Text = row.Cells["PrdId"].Value.ToString();
                General_radio.Text = row.Cells["Category"].Value.ToString();
                //Medical_radio.Text = row.Cells["Category"].Value.ToString();
                if (General_radio.Text=="General")
                {
                    General_radio.Checked = true;
                    Medical_radio.Text = "Medical";
                }
                else
                {
                    Medical_radio.Checked = true;
                    General_radio.Text = "General";
                }
               
                
               
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            string valueofradiobuttons = null;
            if (General_radio.Checked)
            {
                valueofradiobuttons = General_radio.Text;

            }
            if (Medical_radio.Checked)
            {
                valueofradiobuttons = Medical_radio.Text;
            }
            label3.Visible = false;
            // Do whatever here... Submit

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("ProductMaster_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@purchaseid", Purchaseid_txtbox.Text);
            cmd.Parameters.AddWithValue("@PID", CurrentPID_Text.Text);
            cmd.Parameters.AddWithValue("@productname", Productname_txtbox.Text);
            cmd.Parameters.AddWithValue("@subcategory", subcat_textbox.Text);
            cmd.Parameters.AddWithValue("@manaufaturername", Manufacturerename_txtbox.Text);
            cmd.Parameters.AddWithValue("@category", valueofradiobuttons);
            cmd.Parameters.AddWithValue("@genericname", GenericName_txtbox.Text);
            cmd.Parameters.AddWithValue("@shedule", shedule_txbox.Text);
            cmd.Parameters.AddWithValue("@date", Rack_txtbox.Text);
            cmd.Parameters.AddWithValue("@minlevel", min_txtbox.Text);
            cmd.Parameters.AddWithValue("@maxlevel", max_textbox.Text);
            cmd.Parameters.AddWithValue("@hsn", HSN_textbox.Text);
            cmd.Parameters.AddWithValue("@gst", gst_txtbox.Text);
            cmd.Parameters.AddWithValue("@sunhead", subhead_txtbox.Text);

            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Saved");

                ClearTextBoxes();

                DisplayData();
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("ProductMaster_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@PID", CurrentPID_Text.Text);
            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Saved");

                ClearTextBoxes();

                DisplayData();
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
