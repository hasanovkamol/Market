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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(2);

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
        
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
         
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(2);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(2);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(2);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(2);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(3);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(1);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

            AddViewDeleteUpdate(2);
        }
        
        public void AddViewDeleteUpdate(int IndexItem)
        {
            switch (metroComboBox1.SelectedItem.ToString())
            {
                ///Employee
                case "Employee":
                    {
                        EmployeeClass employee;
                        switch (IndexItem)
                        {

                            ///Add
                            case 1:
                                {
                                    employee = new EmployeeClass();

                                    break;
                                }
                            ///View
                            case 2:
                                {
                                    employee = new EmployeeClass(dataGridView1);
                                    break;
                                }
                            ///Update
                            case 3:
                                {
                                    employee = new EmployeeClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), "");
                                    employee = new EmployeeClass(dataGridView1);
                                    break;
                                }
                            ///delete
                            case 4:
                                {
                                    employee = new EmployeeClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                                    employee = new EmployeeClass(dataGridView1);
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }

                ///Account
                case "Account":
                    {
                        AccountClass ac;
                        switch (IndexItem)
                        {
                            case 1:
                                {
                                    Employee_Account ss = new Employee_Account();
                                    ss.Show();
                                    break;
                                }
                            case 2:
                                {
                                    ac = new AccountClass(dataGridView1);
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                            case 4:
                                {
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                ///Region
                case "Region":
                    {
                        About_Region about = new About_Region();
                        switch (IndexItem)
                        {
                            case 1:
                                {
                                    about.Show();
                                    break;
                                }
                            case 2:
                                {
                                    RegionClass region = new RegionClass(dataGridView1);
                                    break;
                                }

                            default:
                                break;
                        }
                        break;
                    }
                ///Position
                case "Position":
                    {
                        PositionClass position;
                        switch (IndexItem)
                        {

                            //Add Item
                            case 1:
                                {
                                    position = new PositionClass();
                                    AddViewDeleteUpdate(2);
                                    break;
                                }
                            //View Item
                            case 2:
                                {
                                    position = new PositionClass(dataGridView1);
                                    break;
                                }
                            //Update Item
                            case 3:
                                {
                                    position = new PositionClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), " ");
                                    break;
                                }
                            // Delete Item
                            case 4:
                                {
                                    position = new PositionClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                ///Product
                case "Product":
                    {
                        ProductClass ac;
                        switch (IndexItem)
                        {
                            case 1:
                                {
                                    ac = new ProductClass();

                                    break;
                                }
                            case 2:
                                {
                                    ac = new ProductClass(dataGridView1);
                                    break;
                                }
                            case 3:
                                {
                                    ac = new ProductClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), "");
                                    break;
                                }
                            case 4:
                                {
                                    ac = new ProductClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                                    break;
                                }
                        }
                        break;
                    }
                ///Categorya
                case "Categories":
                    {
                        CategoryClass category;
                        switch (IndexItem)
                        {
                            case 1:
                                {
                                    category = new CategoryClass();
                                    break;
                                }

                            case 2:
                                {
                                    category = new CategoryClass(dataGridView1);
                                    break;
                                }

                            case 3:
                                {
                                    category = new CategoryClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), " ");
                                    category = new CategoryClass();
                                    break;
                                }

                            case 4:
                                {
                                    category = new CategoryClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                                    break;
                                }
                            default:
                                break;
                        }


                        break;
                    }
                ///Deliver
                case "Deliver":
                    {
                        SuppliersClass suppliers;
                        switch (IndexItem)
                        {
                            ///Add
                            case 1:
                                {
                                    suppliers = new SuppliersClass();
                                    break;
                                }
                            ///View
                            case 2:
                                {
                                    suppliers = new SuppliersClass(dataGridView1);

                                    break;
                                }
                            case 3:
                                {
                                    suppliers = new SuppliersClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), "");
                                    break;
                                }
                            case 4:
                                {
                                    suppliers = new SuppliersClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                ///order
                case "Orders":
                    {
                        break;
                    }
                default:
                    break;
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(4);
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(2);
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            AddViewDeleteUpdate(2);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
            this.Hide();
        }
    }
}
