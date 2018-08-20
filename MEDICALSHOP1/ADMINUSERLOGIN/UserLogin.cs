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
    public partial class UserLogin : Form
    {
        public static string usernamepass;

        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            usernamepass = username_txtbox.Text;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string username = username_txtbox.Text, password = Pass_textbox.Text;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            cmd.Dispose();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfull");
                Main ma = new Main();
                    ma.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username/Password");
                
            }
            con.Close();
        }
    }
}
