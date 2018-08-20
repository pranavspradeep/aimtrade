using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALSHOP1.Trail
{
    public partial class TrialTracker : Form
    {

        string d1frombase;
        string d2frombase;

        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public TrialTracker()
        {
         
            fetchtraildates();
         
            InitializeComponent();
            if (d1frombase == null || d2frombase == null)
            {
                trialbtn.Visible = true;
               
            }
            else
            {
                trialbtn.Visible = false;
            }
            DateTime d1 = DateTime.Now;
            DateTime datefromdbstart = Convert.ToDateTime(d1frombase);
            DateTime d2 = Convert.ToDateTime(d2frombase);
            if(d1.Date<d2.Date)
            {  
                
                    conttrail.Visible = true;
               
            }
            else
            {
                MessageBox.Show("TRAIL EXPIRED");
             
            }


        }

        private void trialbtn_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = d1.AddDays(15);

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("TrailTracker", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@trailstart", d1.Date);
            cmd.Parameters.AddWithValue("@trailends", d2.Date);




            con.Open();
            int i = cmd.ExecuteNonQuery();



            if (i != 0)
            {
                MessageBox.Show("Sucessfully Started Trail");
                trialbtn.Visible = false;
                conttrail.Visible = true;
            }
        }

        public void fetchtraildates()
        {
            DataTable dataTable=new DataTable() ;
            string Query = "select * from TRIALTRACKER";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(Query, con);
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    d1frombase = row["TRIALSTART"].ToString();
                    d2frombase = row["TRAILENDS"].ToString();

                }
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void conttrail_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSelection userSelection = new UserSelection();
            userSelection.Show();
           
            
        }
    }
}
