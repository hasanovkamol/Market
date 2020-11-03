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
    public partial class Employee_Account : MetroFramework.Forms.MetroForm
    {
        public Employee_Account()
        {
            InitializeComponent();
        }

        private void Employee_Account_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AccountClass account = new AccountClass();
            this.Hide();
        }
    }
}
