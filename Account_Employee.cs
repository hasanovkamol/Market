using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Account_Employee : Form
    {
        public Account_Employee()
        {
            InitializeComponent();
        }
     

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Account_Employee_Load(object sender, EventArgs e)
        {
            Location = new Point(350, 180);
        }

        private void txtLoginUser_Click(object sender, EventArgs e)
        {
            txtLoginUser.BackColor = Color.White;
        }

        private void txtpasswordUser_Click(object sender, EventArgs e)
        {
            txtpasswordUser.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
            this.Hide();
        }
    }
}
