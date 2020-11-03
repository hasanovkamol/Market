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
    public partial class Add_Categorya : MetroFramework.Forms.MetroForm
    {
        public Add_Categorya()
        {
            InitializeComponent();
        }

        private void Add_Categorya_Load(object sender, EventArgs e)
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
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
