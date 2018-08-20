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
    public partial class BranchMaster : Form
    {

        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public BranchMaster()
        {
            InitializeComponent();
            DisplayData();
            

        }
        private bool WithErrors()///TEXTBOX CONTROL VALIDATION
        {
            if (Branchname_txtbox.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found
            if (Location_txtbox.Text.Trim() == String.Empty)
                return true;
            if (kgst_txtbox.Text.Trim() == String.Empty)
                return true;

            if (PhoneNo_txtbox.Text.Trim() == String.Empty)
                return true;
            
            // Other textBoxes.

            return false;
        }
        public void DisplayData()///display data function
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            DataTable dt = new DataTable();
             //adapt = new SqlDataAdapter("select BranchId,[Brannch Name],Location,[Kgst.No],[Phone No] from Tbl_BranchMaster ", con);

          adapt = new SqlDataAdapter("DisplayDatagridBranchMaster", con);
            adapt.Fill(dt);
            Branchmaster_datagrid.DataSource = dt;
            Branchmaster_datagrid.DataSource = dt;
           this.Branchmaster_datagrid.Sort(this.Branchmaster_datagrid.Columns["BranchId"], ListSortDirection.Descending);
            //this.Branchmaster_datagrid.DefaultCellStyle.Font = new Font("Tahoma", 12);
            Branchmaster_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Branchmaster_datagrid.RowHeadersVisible = false;
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


        private void Save_Button_Click(object sender, EventArgs e)
        {
            error_label.Visible = true;
            if (WithErrors())
            {
                error_label.Text = "ALL FIELDS ARE REQUIRED";
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);

                SqlCommand cmd = new SqlCommand("BranchMaster_insertEdit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@branchname", Branchname_txtbox.Text);
                cmd.Parameters.AddWithValue("@location", Location_txtbox.Text);
                cmd.Parameters.AddWithValue("@kgstno", kgst_txtbox.Text);
                cmd.Parameters.AddWithValue("@phoneno", PhoneNo_txtbox.Text);



                con.Open();
                int i = cmd.ExecuteNonQuery();



                if (i != 0)
                {
                    MessageBox.Show("Data Saved");



                }

                DisplayData();
                ClearTextBoxes();

            }


        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Branchmaster_datagrid_Click(object sender, EventArgs e)
        {
            
        }

        
       

        private void Edit_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("BranchMaster_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BrachID", BranchID_Label.Text);
            cmd.Parameters.AddWithValue("@branchname", Branchname_txtbox.Text);
            cmd.Parameters.AddWithValue("@location", Location_txtbox.Text);
            cmd.Parameters.AddWithValue("@kgstno", kgst_txtbox.Text);
            cmd.Parameters.AddWithValue("@phoneno", PhoneNo_txtbox.Text);



            con.Open();
            int i = cmd.ExecuteNonQuery();



            if (i != 0)
            {
                MessageBox.Show("Data Saved");
                DisplayData();
                BranchID_Label.Hide();
                Branchname_txtbox.Clear();
                Location_txtbox.Clear();
                kgst_txtbox.Clear();
                PhoneNo_txtbox.Clear();

            }
        }

        private void Branchmaster_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BranchID_Label.Show();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Branchmaster_datagrid.Rows[e.RowIndex];

                Branchname_txtbox.Text = row.Cells["BrannchName"].Value.ToString();
                Location_txtbox.Text = row.Cells["Location"].Value.ToString();
                kgst_txtbox.Text = row.Cells["Kgst.No"].Value.ToString();
                PhoneNo_txtbox.Text = row.Cells["PhoneNo"].Value.ToString();
                BranchID_Label.Text = row.Cells["BranchId"].Value.ToString();
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            BranchID_Label.Show();
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("BranchMaster_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BrachID", BranchID_Label.Text);
            cmd.Parameters.AddWithValue("@branchname", Branchname_txtbox.Text);
            cmd.Parameters.AddWithValue("@location", Location_txtbox.Text);
            cmd.Parameters.AddWithValue("@kgstno", kgst_txtbox.Text);
            cmd.Parameters.AddWithValue("@phoneno", PhoneNo_txtbox.Text);



            con.Open();
            int i = cmd.ExecuteNonQuery();



            if (i != 0)
            {
                MessageBox.Show("Data Deleted");
                DisplayData();
                BranchID_Label.Hide();
                
                ClearTextBoxes();

            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            BranchID_Label.Hide();
            
            ClearTextBoxes();

        }
    }
    }
    
    

