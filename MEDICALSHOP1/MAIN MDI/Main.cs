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
using MEDICALSHOP1.REPORTS;

namespace MEDICALSHOP1
{
    public partial class Main : Form
    {


        public Main()
        {
            
            
            InitializeComponent();
            
        }

        

            public void newToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Sales s = new Sales();
                s.MdiParent = this;
                s.Show();
            }



            public void newToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                Purchase s = new Purchase();
                s.MdiParent = this;
                s.Show();
            }

            private void newToolStripMenuItem2_Click(object sender, EventArgs e)
            {
                ProductMaster M = new ProductMaster();
                M.MdiParent = this;
                M.Show();
            }

            private void newToolStripMenuItem4_Click(object sender, EventArgs e)
            {
                ManufacturingMaster Manufacturer = new ManufacturingMaster();
                Manufacturer.MdiParent = this;
                Manufacturer.Show();
            }

            private void newToolStripMenuItem3_Click(object sender, EventArgs e)
            {
                BranchMaster branchmaster = new BranchMaster();
                branchmaster.MdiParent = this;
                branchmaster.Show();
            }

            private void newToolStripMenuItem5_Click(object sender, EventArgs e)
            {
                SupplierMaster supplmaster = new SupplierMaster();
                supplmaster.MdiParent = this;
                supplmaster.Show();
            }

            private void newToolStripMenuItem6_Click(object sender, EventArgs e)
            {

               // SalesReport salesreport = new SalesReport();
               //salesreport.MdiParent = this;
               //// this.Visible = false;
               // salesreport.Show();
            }

           
        
        public void Privelageset()///FUNCTION TO DISPLAY According to privelages
        {
            string username = UserLogin.usernamepass;
            string userid = "";
            string formid = "";
            label1.Text = username;



            string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("privelages_according_to_user", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userid = reader["UserID"].ToString();

            }
            reader.Close();
            SqlDataReader Nreader = null;
            SqlConnection connn = new SqlConnection(conStr);
            SqlCommand comm = new SqlCommand("privelage_retrive_formid", con);
            connn.Open();
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@userid", userid);
            Nreader = comm.ExecuteReader();
            while (Nreader.Read())

            {
                formid = Nreader["FormID"].ToString();



                // label2.Text = formid;
                if (formid.Equals("1"))
                {
                    menuStrip1.Visible = true;
                    newToolStripMenuItem.Visible = true;
                    salesToolStripMenuItem.Visible = true;
                    salesReturnToolStripMenuItem.Visible = true;
                    //sTOCKToolStripMenuItem.Visible = true;
                    //Sales s = new Sales();
                    //s.MdiParent = this;

                    //s.Show();


                }
                if (formid.Equals("2"))
                {
                    menuStrip1.Visible = true;
                    newToolStripMenuItem1.Visible = true;
                    purchaseToolStripMenuItem.Visible = true;
                    purchaseReturnToolStripMenuItem.Visible = true;
                }



                if (formid.Equals("3"))
                {
                    menuStrip1.Visible = true;
                    newToolStripMenuItem2.Visible = true;
                    productMasterToolStripMenuItem.Visible = true;



                }
                if (formid.Equals("4"))
                {

                    menuStrip1.Visible = true;
                    newToolStripMenuItem3.Visible = true;
                    manufacturerMasterToolStripMenuItem.Visible = true;
                    // ManufacturingMaster Manufacturer = new ManufacturingMaster();
                    // Manufacturer.MdiParent = this;
                    // Manufacturer.Show();
                }
                if (formid.Equals("5"))
                {
                    menuStrip1.Visible = true;
                    newToolStripMenuItem4.Visible = true;
                    branchMasterToolStripMenuItem.Visible = true;
                    //BranchMaster branchmaster = new BranchMaster();
                    //branchmaster.MdiParent = this;
                    //branchmaster.Show();
                }
                if (formid.Equals("6"))
                {
                    menuStrip1.Visible = true;
                    newToolStripMenuItem5.Visible = true;
                    supplierMasterToolStripMenuItem.Visible = true;
                    //SupplierMaster supplmaster = new SupplierMaster();
                    //supplmaster.MdiParent = this;
                    //supplmaster.Show();
                }
                if (formid.Equals("7"))
                {


                    menuStrip1.Visible = true;
                    //newToolStripMenuItem6.Visible = true;
                    salesReportToolStripMenuItem.Visible = true;

                    //SalesReport salesreport = new SalesReport();
                    //salesreport.MdiParent = this;
                    //salesreport.Show();

                }
                if(formid.Equals("8"))
                {

                }

            }

        }





        public void Main_Load(object sender, EventArgs e)
        {

           Privelageset();

        }

        private void newToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SalesReturn s = new SalesReturn();
            s.MdiParent = this;
            s.Show();
        }

        private void newToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            PurchaseReturn s = new PurchaseReturn();
            s.MdiParent = this;
            s.Show();
        }

        private void salesReturnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SalesReturnReport s = new SalesReturnReport();
            s.MdiParent = this;
                s.Show();
        }

        private void purchaseReturnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseReturnReportview s = new PurchaseReturnReportview();
            s.MdiParent = this;
            s.Show();
        }

        private void outOfStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OUTofSTOCKreport s = new OUTofSTOCKreport();
            s.MdiParent = this;
            s.Show();
        }

        private void sTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.MdiParent = this;
            s.Show();
        }

        private void reportGstPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GstPurchaseToACC s = new GstPurchaseToACC();
            s.MdiParent = this;
            s.Show();
        }

        private void sALESREPORTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaleReport C = new SaleReport();
            C.MdiParent = this;
            C.Show();

        }

        private void oUTOFSTOCKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OUTofSTOCKreport c = new OUTofSTOCKreport();
            c.MdiParent = this;
            c.Show();
        }

        private void pURCHASEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseReturnReportview n = new PurchaseReturnReportview();
            n.MdiParent = this;
            n.Show();
        }

        private void sALESRETURNREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReturnReport n = new SalesReturnReport();
            n.MdiParent = this;
            n.Show();
        }

        private void pURCHASERETURNToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            PurchaseReturnReportview p = new PurchaseReturnReportview();
            p.MdiParent = this;
            p.Show();
        }

        private void iTEMWISEREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemwiseReport R = new ItemwiseReport();
            R.MdiParent = this;
            R.Show();
        }
    }
    }


