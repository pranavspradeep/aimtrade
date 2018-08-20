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
    public partial class ManufacturingMaster : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public ManufacturingMaster()
        {
            InitializeComponent();
            DisplayData();
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
            adapt = new SqlDataAdapter("ManufacturermasterDataGridDisplay  ", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            // this.dataGridView1.Sort(this.dataGridView1.Columns["RowId"], ListSortDirection.Descending);
            con.Close();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("Manufacturer_Master_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@manufacturername",  ManufacturerId_txtbox.Text);
            cmd.Parameters.AddWithValue("@manufacturerid", ManufacturerName_Txtbox.Text);
            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Saved");

                ManufacturerId_txtbox.Clear();
                ManufacturerName_Txtbox.Clear();

                DisplayData();
            }
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("Manufacturer_DeleteData", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@manufacturerMid", ManufactureMId_txtbox.Text);
            con.Open();
            int j = cmd.ExecuteNonQuery();



            if (j != 0)
            {
                MessageBox.Show("Data Deleted");

                DisplayData();
                ClearTextBoxes();

            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                ManufacturerName_Txtbox.Text = row.Cells["Manufacturer_Name"].Value.ToString();
                ManufacturerId_txtbox.Text = row.Cells["Manufacturer_Id"].Value.ToString();
                ManufactureMId_txtbox.Text = row.Cells["Mid"].Value.ToString();
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("Manufacturer_UpdateDateInTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    string i = ManufactureMId_txtbox.Text;
                    int a = Convert.ToInt32(i);

                    cmd.Parameters.Add("@manufacturerId", SqlDbType.VarChar).Value = ManufacturerId_txtbox.Text;
                    cmd.Parameters.Add("@manufacturerName", SqlDbType.VarChar).Value = ManufacturerName_Txtbox.Text;
                    cmd.Parameters.Add("@manufacturerMid", SqlDbType.Int).Value = a; 

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("DataUpdated");
                    DisplayData();

                }
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
