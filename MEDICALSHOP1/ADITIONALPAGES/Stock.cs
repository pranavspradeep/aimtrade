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

namespace MEDICALSHOP1
{
    public partial class Stock : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["coonstring"].ToString();
        public Stock()
        {
            InitializeComponent();
            Display_Stock();
            totalproduct();
            sumofamount();

        }

        public void Display_Stock()
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            DataTable dt = new DataTable();
            // adapt = new SqlDataAdapter("select ItemName,Batch,ExpDate,PQty,Rate,Company from tbl_Stock_dummy  ", con);
            adapt = new SqlDataAdapter("DisplayStock",con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            // this.dataGridView1.Sort(this.dataGridView1.Columns["RowId"], ListSortDirection.Descending);
            con.Close();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

           
        }
        public void totalproduct()
        {
            int numRowCount = dataGridView1.RowCount;
            int Num = numRowCount - 1;
            String totalproduct = Convert.ToString(Num);
            
            TotalProduct_textBox.Text = totalproduct;
        }
        public void sumofamount()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value);
                
            }
            string SUM = Convert.ToString(sum);
            TotalAmount_textbox.Text = SUM;
        }

        

        private void Close_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
