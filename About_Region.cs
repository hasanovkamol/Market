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
    public partial class About_Region : Form
    {
        public About_Region()
        {
          
            InitializeComponent();
            txtSelectCountryname.DataSource = db.Counties.ToList();
           // txtSelectCountryname.ValueMember = "Country_Id";
            txtSelectCountryname.DisplayMember = "Country_name";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
            MarketEntities db = new MarketEntities();
        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (txtID.Text!="" && txtCountry_name.Text!="")
            {
                Counties con = new Counties();
                con.Counrty_Id = txtID.Text;
                con.Country_name = txtCountry_name.Text;
                db.Counties.Add(con);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Dont Null");
            }
        }

        private void About_Region_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCityname.Text!="")
                {
                    Cities cit = new Cities();
                    cit.City_name = txtCityname.Text;
                    cit.Country_Code = selectCountry();
                    db.Cities.Add(cit);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("dont City null");
                }
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }
        private string selectCountry()
        {
            var quert = (from i in db.Counties
                         where i.Country_name == txtSelectCountryname.Text
                         select i).ToList();
            string a = "";
            foreach (var item in quert)
            {
                 a = item.Counrty_Id;
            }
            return a;
        }
    }
}
