using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALSHOP1
{
    public partial class UserSelection : Form
    {
        public UserSelection()
        {
            InitializeComponent();
        }

        private void User_btn_Click(object sender, EventArgs e)
        {
            
            UserLogin ul = new UserLogin();
            ul.Show();
            this.Hide();
            
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }
    }
    }

