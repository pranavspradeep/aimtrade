using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Configuration;

namespace MEDICALSHOP1
{
    public partial class UserCreationMaster : Form
    {
       
        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public UserCreationMaster()
        {
            InitializeComponent();

        }

        public void Datinserttousertable()
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand command = new SqlCommand("insertuserdetails", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", Name_txtbox.Text);
            command.Parameters.AddWithValue("@Address", Address_txtbox.Text);
            command.Parameters.AddWithValue("@UserName", UserNAME_Txtbox.Text);
            command.Parameters.AddWithValue("@UserPassword", Password_textbox.Text);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                MessageBox.Show("Data Entered succesfully ");
            }
            else
            {
                MessageBox.Show("Error ");
            }

        }
        //get userid to set privalage in privilage table
        public void UseridRetrive()
        {
            SqlDataReader myReader = null;
            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlConnection myConnection = new SqlConnection(conStr);
            // SqlCommand myCommand = new SqlCommand("select BillNo from  Tbl_Sales", myConnection);
            SqlCommand myCommand = new SqlCommand("Useridretrivalfromusertableforprivilageset", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                String i = myReader["UserID"].ToString();
                int uid = Convert.ToInt32(i);
                CurrentUser_Txtbox.Text = Convert.ToString(uid);



            }
        }


        private void Save_Button_Click(object sender, EventArgs e)
        {
            Datinserttousertable();
            UseridRetrive();

        }

        private void Privelageset_button_Click(object sender, EventArgs e)
        {
            string a="",b="", c="", d="", x="", f="", g="", h="";


            if (Sales_checkBox.Checked == true)
            {
                int j = 1;
                a = Convert.ToString(j);
            }

            if (PUrchase_checkbox.Checked == true)
            {
                int k = 2;
                b = Convert.ToString(k);
            }
                    if (ProductMaster_checkbox.Checked == true)
                    {
                        int l = 3;
                        c = Convert.ToString(l);
                    }
                    if (Manufacturer_Master_checkbox.Checked == true)
                    {
                        int m = 4;
                        d = Convert.ToString(m);
                    }
                    if (BranchMaster_checkBox.Checked == true)
                    {
                        int n = 5;
                        x= Convert.ToString(n);
                    }

                    if (SupplierMaster_checkbox.Checked == true)
                    {
                        int s = 6;
                        f = Convert.ToString(s);
                    }
                    if (Report_checkbox.Checked == true)
                    {
                        int gh = 7;
                        g = Convert.ToString(gh);
                    }
                    if (Acc_report_checkbox.Checked == true)
                    {

                        int rb = 8;
                        h = Convert.ToString(rb);

                    }





                    String Useridforprivelageset = CurrentUser_Txtbox.Text;
                    SqlConnection connection = new SqlConnection(conStr);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("setprivilageforuser", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId",Useridforprivelageset);
                    cmd.Parameters.AddWithValue("@salescheck",a.ToString());
                    cmd.Parameters.AddWithValue("@purchase",b.ToString());
                    cmd.Parameters.AddWithValue("@productmaster", c.ToString());
                    cmd.Parameters.AddWithValue("@manufacturermaster",d.ToString());
                    cmd.Parameters.AddWithValue("@branchmaster",x.ToString());
                    cmd.Parameters.AddWithValue("@supplier",f.ToString());
                    cmd.Parameters.AddWithValue("@salesreport",g.ToString());
                    cmd.Parameters.AddWithValue("@accounts",h.ToString());

            int i = cmd.ExecuteNonQuery();
            string ma = Convert.ToString(i);
            if (i == 8)
            {
                MessageBox.Show("Privelages are set");

            }
            else
            {
                MessageBox.Show("failed");
            }         
            
                   
                    connection.Close();

                }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Closebutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }


        }
    

