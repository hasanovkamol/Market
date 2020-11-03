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
    public partial class Saler_Manger : Form
    {
        public Saler_Manger()
        {
            InitializeComponent();
        }
        private void TextRead(string a)
        {
            if (bntProductNumber.Checked == true)
            {
                txtProductNumber.Text += a;
            }
            else if (btnProductID.Checked == true)
            {
                txtProductID.Text += a;
            }


        }
        private void metroButton13_Click(object sender, EventArgs e)
        {



        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            TextRead("2");
        }

        private void Saler_Manger_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Location = new Point(150, 50);
          

        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            TextRead("0");
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            TextRead("1");
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            TextRead("3");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            TextRead("4");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            TextRead("5");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            TextRead("6");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TextRead("7");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            TextRead("8");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            TextRead("9");
        }
        MarketEntities db = new MarketEntities();
        decimal cost = 0;
        private void metroButton10_Click(object sender, EventArgs e)
        {
            if (txtProductNumber.Text != "" && txtProductID.Text != "")
            {
                int a = int.Parse(txtProductID.Text);
                int b = int.Parse(txtProductNumber.Text);
                var query = (from i in db.Product
                             join j in db.Deliver on
                             i.Olib_KeluvchiID equals j.ID
                             join k in db.Categories on
                             i.CategoryID equals k.ID
                             where i.ID == a && i.UnitsInStock - i.UnitsOnOrder >= b
                             select new
                             {
                                 ID = i.ID,
                                 Product_Name = i.Product_Name,
                                 Unit_Price = i.Unit_Price,
                                 Nomer = b,
                                 Categories_Name = k.Categories_name,
                             }
                             ).ToList();

                foreach (var item in query)
                {

                    SaleryDataSours.Rows.Add(item.ID, item.Product_Name, item.Unit_Price, item.Nomer, item.Categories_Name);
                    cost += decimal.Parse(item.Unit_Price.ToString()) * int.Parse(item.Nomer.ToString());
                }
                txtTotalCost.Text = cost.ToString();

            }
            else
            {
                if (txtProductID.Text == "")
                {
                    txtProductID.BackColor = Color.Red;
                }
                else if (txtProductNumber.Text == "")
                {
                    txtProductNumber.BackColor = Color.Red;
                }

            }
        }

        private void txtDescount_Click(object sender, EventArgs e)
        {

        }

        private void txtProductNumber_Click(object sender, EventArgs e)
        {
            txtProductNumber.BackColor = Color.WhiteSmoke;
        }

        private void txtProductID_Click(object sender, EventArgs e)
        {
            txtProductID.BackColor = Color.WhiteSmoke;
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (btnProductID.Checked == true && txtProductID.Text.Length > 0)
            {
                txtProductID.Text = txtProductID.Text.Substring(0, txtProductID.Text.Length - 1);
            }
            else if (txtProductNumber.Text.Length > 0)
            {
                txtProductNumber.Text = txtProductNumber.Text.Substring(0, txtProductNumber.Text.Length - 1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton14_Click(object sender, EventArgs e)
        {



        }

        private void metroButton16_Click(object sender, EventArgs e)
        {

        }

        private void metroButton15_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Saler_Manger_timeNow.Text = "Clock: " + DateTime.Now.ToString();
        }
        int EmployeeID = 0;
        private void metroButton17_Click(object sender, EventArgs e)
        {


        }

        private void metroButton18_Click(object sender, EventArgs e)
        {

        }

        private void metroButton19_Click(object sender, EventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            SaleryDataSours.Rows.Clear();
            SaleryDataSours.Refresh();  
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SaleryDataSours.SelectedRows.Count > 0)
                {
                    SaleryDataSours.Rows.RemoveAt(this.SaleryDataSours.SelectedRows[0].Index);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("No Fount Delete Items" + es.Message);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                if (int.TryParse(txtProductID.Text, out id) || int.TryParse(SaleryDataSours.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    var q = (from i in db.Product
                             join j in db.Categories on i.CategoryID equals j.ID
                             join k in db.Deliver on i.Olib_KeluvchiID equals k.ID
                             where i.ID == id
                             select new
                             {
                                 Product = i.Product_Name,
                                 LastDate = i.LastDate,
                                 EnterDate = i.EnterDate,
                                 UnitsInStock = i.UnitsInStock,
                                 UnitsOnOrder = i.UnitsOnOrder,
                                 Unit_Price = i.Unit_Price,
                                 Categories_name = j.Categories_name,
                                 Description = j.Description,
                                 Company_name = k.Company_name,
                                 Company_Phone = k.Company_Phone,
                                 Contract_name = k.Contract_name,
                                 Contract_Title = k.Contract_Title,
                                 Full_name = k.Full_name,


                             }).ToList();
                    foreach (var item in q)
                    {
                        MessageBox.Show("---Product About---\nProduct Name: " + item.Product + "\nEnterDate: " + item.EnterDate + "\nLastDate: " + item.LastDate + "\nUnitsOnOrder: " + item.UnitsOnOrder +
                            "\nUnitsInStock: " + item.UnitsInStock + "\nUnit_Price: " + item.Unit_Price + "\n---Categories About---\nCategory_Name: " + item.Categories_name +
                            "\nDescription: " + item.Description + "\n----Deliver About---- \nCompany_name: " + item.Company_name + "\nCompany Phone: " + item.Company_Phone +
                            "\nContract name: " + item.Contract_name + "\nContract Title: " + item.Contract_Title + "\nDeliver Full name: " + item.Full_name);
                    }
                }

            }
            catch (Exception eas)
            {

                MessageBox.Show(eas.Message);
            }
         
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductNumber.Text = "";
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ff();
        }
      public  void ff()
        {
            Account_Employee account = new Account_Employee();
            var query = (from i in db.Account
                         select i).ToList();
            bool f = true;
            while (true)
            {
                DialogResult result = account.ShowDialog();
                if (result == DialogResult.OK)
                {

                    foreach (var item in query)
                    {

                        if (item.User_Login == account.txtLoginUser.Text && item.User_Password == account.txtpasswordUser.Text)
                        {
                            EmployeeID = item.EmployeeID;
                            f = false;
                        }
                    }

                }
                if (result==DialogResult.Cancel)
                {
                    this.Hide();
                    break;
                }

                if (f != true)
                {
                    var qq = db.Employees.Where(i => i.ID == EmployeeID).Select(p => new { Name = p.First_name, surname = p.Last_name, path = p.PhotoPath }).ToList();

                    foreach (var item1 in qq)
                    {
                        txtEmployee.Text = item1.Name + "\n" + item1.surname;

                        try
                        {
                            pictureBox1.Image = Image.FromFile(item1.path);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
                }
                else
                {
                    account.txtLoginUser.BackColor = Color.Red;
                    account.txtpasswordUser.BackColor = Color.Red;
                    account.Location = new Point(350, 150);
                }

            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (bntProductNumber.Checked == true)
            {
                txtProductNumber.Text = "";
            }
            else if (btnProductID.Checked == true)
            {
                txtProductID.Text = "";
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {
                if (bntProductNumber.Checked == true)
                {
                    txtProductNumber.Text = (int.Parse(txtProductNumber.Text) + 1).ToString();
                }
                else if (btnProductID.Checked == true)
                {
                    txtProductID.Text = (int.Parse(txtProductID.Text) + 1).ToString();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            try
            {
                if (bntProductNumber.Checked == true && int.Parse(txtProductNumber.Text) > 2)
                {
                    txtProductNumber.Text = (int.Parse(txtProductNumber.Text) - 1).ToString();
                }
                else if (btnProductID.Checked == true && int.Parse(txtProductID.Text) > 2)
                {
                    txtProductID.Text = (int.Parse(txtProductID.Text) - 1).ToString();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            try
            {
                dd("Naxt");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            try
            {
            dd("Plastic");

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        void dd(string money)
        {
            BuyProduct buy = new BuyProduct();

            string[,] r = new string[SaleryDataSours.Rows.Count, 5];
            int i = 0;
            foreach (DataGridViewRow row in SaleryDataSours.Rows)
            {
                r[i, 0] = row.Cells[0].Value.ToString();
                r[i, 1] = row.Cells[1].Value.ToString();
                r[i, 2] = row.Cells[2].Value.ToString();
                r[i, 3] = row.Cells[3].Value.ToString();
                r[i, 4] = row.Cells[4].Value.ToString();
                if (i == SaleryDataSours.Rows.Count - 2)
                {
                    break;
                }
                i++;
            }
            try
            {
                int OrderID = buy.BuyProductOrders(EmployeeID, money);
                for (int j = 0; j <= i; j++)
                {
                    buy.BuyProductAA(OrderID, int.Parse(r[j, 3]), int.Parse(r[j, 0]), decimal.Parse(r[j, 2]), 12);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            MessageBox.Show("Don");
        }

        private void fasfasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
