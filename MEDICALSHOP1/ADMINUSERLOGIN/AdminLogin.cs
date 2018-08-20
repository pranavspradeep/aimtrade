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
    public partial class AdminLogin : Form
    {

        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string username = username_txtbox.Text, password = Password_txtbox.Text;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("adminlogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@password", password);
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            cmd.Dispose();

            if (dt.Rows.Count > 0)
            {
                 MessageBox.Show("Login Successfull");
                UserCreationMaster usr = new UserCreationMaster();
                usr.Show();
                this.Close();
                //Or in show messagebox using  ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Login Successfull');", true);
                //Or write using Response.Write("Login Successfull");
                //Or redirect using Response.Redirect("Mypanel.aspx");
            }
            else
            {
               MessageBox.Show("Wrong Username/Password");
                //Or show in messagebox usingScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Wrong Username/Password');", true);
                //Or write using Response.Write("Wrong Username/Password");
            }


            
            con.Close();


        }
    }
}
