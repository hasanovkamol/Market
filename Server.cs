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
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 dd = new Form1();
            dd.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Saler_Manger saler_ = new Saler_Manger();
            saler_.Show();
            this.Hide();
            saler_.ff();

        }
    }
}
