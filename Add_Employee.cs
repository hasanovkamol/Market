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
    public partial class Add_Employee : MetroFramework.Forms.MetroForm
    {
        public Add_Employee()
        {
            InitializeComponent();
            comPosition.DataSource = db.Position.ToList();
            comPosition.DisplayMember = "Position_name";
            comPosition.ValueMember = "ID";
            comCountry.DataSource = db.Counties.ToList();
            comCountry.DisplayMember = "Country_name";
            comCountry.ValueMember = "Counrty_Id";
            f = true;
        }
        bool f = false; 
        MarketEntities db = new MarketEntities();

        private void Add_Employee_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog rr = new OpenFileDialog() { Filter = "JPG | *.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (rr.ShowDialog() == DialogResult.OK)
                    {
                        txtPhotoPath.Text = rr.FileName.ToString();
                        pictureBox1.Image = Image.FromFile(rr.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f==true)
            {
                var query = (from i in db.Cities
                             where i.Country_Code == comCountry.SelectedValue.ToString()
                             select i).ToList();
                comCity.DataSource = query;
                comCity.DisplayMember = "City_name";
            }
        }

        private void comPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f == true)
            {
                var query = (from i in db.Position
                                 where i.Position_name == comPosition.Text
                                 select new
                                 {
                                     Narx = i.Payment
                                 }
                                 ).ToList();
                foreach (var item in query)
                {
                    txtPayment.Text = item.Narx.ToString();
                }
                
            }
        }
    }
}
