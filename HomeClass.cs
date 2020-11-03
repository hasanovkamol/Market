using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace Market
{
    class HomeClass
    {
    }

    static class AddData
    {
        public static void add()
        {
            MessageBox.Show("Ma'lumot qo'shildi");
        }
        public static void notadd()
        {
            MessageBox.Show("Ma'lumot qo'shilmadi");
        }
        public static void DataChange()
        {
            MessageBox.Show("Ma'lumotlar o'zgartirldi");
        }
        public static void notDataChange()
        {
            MessageBox.Show("Ma'lumotlar o'zgarmadi");
        }
        public static void Remove()
        {
            MessageBox.Show("Ma'lumot o'chirldi");
        }
        public static void NotRemove()
        {
            MessageBox.Show("Ma'lumot o'chirlmadi");
        }
        public static void NotRemove(Exception es)
        {
            MessageBox.Show("Ma'lumot o'chirlmadi",es.Message);
        }
        public static void ExceptionError(Exception es)
        {
            MessageBox.Show(es.Message);
        }
    }
    
    class RegionClass
    {
        MarketEntities db = new MarketEntities();
        ///View:
        public RegionClass(DataGridView  DTG)
        {
            var query = (from i in db.Counties
                         join j in db.Cities on i.Counrty_Id equals j.Country_Code
                         select new
                         {
                             Counties=i.Country_name,
                             Cities =j.City_name,
                             Code=j.Country_Code
                         }
                       ).ToList();
            DTG.DataSource = query;
        }

    }

    class PositionClass
    {
        MarketEntities db = new MarketEntities();
        Position pos = new Position();
        Create_Position crpos = new Create_Position();
        //Add New Position
        public PositionClass()
        {
            DialogResult result = crpos.ShowDialog();
            if (result==DialogResult.OK)
            {
            pos.Position_name = crpos.txtPosition_name.Text;
            pos.Payment = decimal.Parse(crpos.txtPayment.Text);
            db.Position.Add(pos);
            db.SaveChanges();
                AddData.add();
            }
            else
            {
                AddData.notadd();
            }
            
        }
        //view
        public PositionClass(DataGridView DGV)
        {
            var query = (from i in db.Position
                         select new 
                         {
                             Nomer=i.ID,
                             Position_Name=i.Position_name,
                             Payment=i.Payment
                         }).ToList();
            DGV.DataSource = query;
        }
        //delete
        public PositionClass(int RemovID)
        {
            try
            {
                Position deleteItem = db.Position.Find(RemovID);
                db.Position.Remove(deleteItem);
                db.SaveChanges();
                AddData.Remove();
            }
            catch (Exception es)
            {
                AddData.NotRemove(es);
            }
        }
        //Update
        public PositionClass(int UpdateID,string a)
        {
            var query = (from i in db.Position
                         where UpdateID == i.ID
                         select i).ToList();
            foreach (var item in query)
            {
                crpos.txtPosition_name.Text = item.Position_name;
                crpos.txtPayment.Text = item.Payment.ToString();
            }
            DialogResult result = crpos.ShowDialog();
            if (DialogResult.OK==result)
            {
                pos = db.Position.Find(UpdateID);
                pos.Position_name = crpos.txtPosition_name.Text;
                pos.Payment = decimal.Parse(crpos.txtPayment.Text);
                db.Entry(pos).State = EntityState.Modified;
                db.SaveChanges();
                AddData.DataChange();
            }
            else
            {
                AddData.notDataChange();
            }
        }

    }

    class EmployeeClass
    {
        MarketEntities db = new MarketEntities();
        Employees emp = new Employees();
        Add_Employee r = new Add_Employee();
        //Add
        public EmployeeClass()
        {
            DialogResult result = r.ShowDialog();

            if (DialogResult.OK == result)
            {

                emp.First_name = r.txtFirstname.Text;
                emp.Last_name = r.txtlastname.Text;
                emp.BirthDay = r.birthDayEmployees.Value;
                emp.HireDay = r.HireDayEmployees.Value;
                emp.Notes = r.txtAboutEmployees.Text;
                emp.Pasport_number = r.txtPasportNumber.Text;
                emp.Phone = r.txtPhoneNumber.Text;
                emp.Address = r.txtAddress.Text;
                emp.PhotoPath = r.txtPhotoPath.Text;
                emp.City = r.comCity.Text;
                emp.Country = r.comCountry.Text;
                emp.Email = r.txtEmail.Text;
                emp.Payment_Bonus = decimal.Parse(r.txtPayment.Text);
                emp.PositionID = (int)r.comPosition.SelectedValue;
                db.Employees.Add(emp);
                db.SaveChanges();
                AddData.add();

            }
            else
            {
                AddData.notadd();
            }
        }
        public EmployeeClass(int SelectItemUpDate, string UpDate)
        {
          
            emp = (from i in db.Employees
                   where i.ID == SelectItemUpDate
                   select i).First();
            r.Text = "Do you want to change Employee's information";
            r.txtAboutEmployees.Text = emp.Notes;
            r.txtAddress.Text = emp.Address;
            r.txtFirstname.Text = emp.First_name;
            r.txtlastname.Text = emp.Last_name;
            r.txtPasportNumber.Text = emp.Pasport_number;
            r.txtPhoneNumber.Text = emp.Phone;
            r.txtPhotoPath.Text = emp.PhotoPath;
            r.txtEmail.Text = emp.Email;
            r.birthDayEmployees.Value = emp.BirthDay.Value;
            r.HireDayEmployees.Value = emp.HireDay.Value;
            r.comCity.Text = emp.City;
            r.txtPayment.Text = emp.Payment_Bonus.ToString();
            r.comCountry.Text = emp.Country;
            r.comPosition.SelectedItem = emp.Position.Position_name;

            DialogResult result = r.ShowDialog();
            if (DialogResult.OK == result)
            {
                emp = db.Employees.Find(SelectItemUpDate);
                emp.First_name = r.txtFirstname.Text;
                emp.Last_name = r.txtlastname.Text;
                emp.BirthDay = r.birthDayEmployees.Value;
                emp.HireDay = r.HireDayEmployees.Value;
                emp.Notes = r.txtAboutEmployees.Text;
                emp.Pasport_number = r.txtPasportNumber.Text;
                emp.Phone = r.txtPhoneNumber.Text;
                emp.Address = r.txtAddress.Text;
                emp.PhotoPath = r.txtPhotoPath.Text;
                emp.City = r.comCity.Text;
                emp.Country = r.comCountry.Text;
                emp.PositionID = (int)r.comPosition.SelectedValue;
                db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                AddData.DataChange();

            }
            else
            {
                AddData.notDataChange();
            }

        }
        //Remove Item
        public EmployeeClass(int removeItem)
        {
            try
            {
                var query = (from i in db.Account

                             where removeItem == i.EmployeeID
                             select i).ToList();

                foreach (var item in query)
                {
                    Account ac = db.Account.Find(item.EmployeeID);
                    db.Account.Remove(ac);
                    db.SaveChanges();
                }

                emp = db.Employees.Find(removeItem);
                db.Employees.Remove(emp);
                db.SaveChanges();

                AddData.Remove();
            }
            catch (Exception es)
            {
                AddData.ExceptionError(es);
            }
        }
        //View
        public EmployeeClass(DataGridView DGV)
        {
            var query = from i in db.Employees
                        join f in db.Position on i.PositionID equals f.ID

                        select new
                        {
                            Number = i.ID,
                            FIO = i.First_name + " " + i.Last_name,
                            Email = i.Email,
                            Position = f.Position_name,
                            Pasport = i.Pasport_number,
                            Payment = i.Payment_Bonus + "$",
                            Phone = i.Phone,
                            BirthDay = i.BirthDay,
                            HireDay = i.HireDay,
                            Country = i.Country,
                            City = i.City,
                            Address = i.Address,
                            PhotoPath = i.PhotoPath,
                            Notes = i.Notes

                        };
            DGV.DataSource = query.ToList();
        }
    }

    class AccountClass
    {
        MarketEntities db = new MarketEntities();
        Account ac = new Account();
        Employee_Account empAcc = new Employee_Account();
        public AccountClass(DataGridView DGV)
        {
            var query = (from i in db.Account
                         select i).ToList();
            DGV.DataSource = query;
        }
        public AccountClass()
        {
            ac.EmployeeID = int.Parse(empAcc.txtEmploeeID.Text);
            ac.User_Login = empAcc.txtusername.Text;
            ac.User_Password = empAcc.txtuserpassword.Text;
            ac.Create_Account = DateTime.Now;
            db.Account.Add(ac);
            db.SaveChanges();
            MessageBox.Show("Create Account Employee");
        }
    }

    class ProductClass
    {
        MarketEntities db = new MarketEntities();

        ///--join table install items on ComBox
        void JoinComBoxItems(Add_Product r)
        {
            r.cobCategory.DataSource = db.Categories.ToList();
            r.cobCategory.DisplayMember = "Categories_name";
            r.cobCategory.ValueMember = "ID";
            r.cobSupplier.DataSource = db.Deliver.ToList();
            r.cobSupplier.DisplayMember = "Contract_name";
            r.cobSupplier.ValueMember = "ID";
        }


        ///AddProduct
        public ProductClass()
        {

            Add_Product r = new Add_Product();
            JoinComBoxItems(r);
            DialogResult result = r.ShowDialog();
            if (result == DialogResult.OK)
            {
                Product pro = new Product();
                pro.Product_Name = r.txtProductname.Text;
                pro.Unit_Price = decimal.Parse(r.txtProductPrice.Text);
                pro.UnitsInStock = int.Parse(r.txtProductStock.Text);
                pro.UnitsOnOrder = 0;
                pro.Olib_KeluvchiID = (int)r.cobSupplier.SelectedValue;
                pro.CategoryID = (int)r.cobCategory.SelectedValue;
                pro.EnterDate = r.dateEnterDate.Value;
                pro.LastDate = r.dateLastDate.Value;
                db.Product.Add(pro);
                db.SaveChanges();
                AddData.add();
            }
            else
            {
                AddData.notadd();
            }


        }

        /// view
        public ProductClass(DataGridView daG)
        {
            var query = (from i in db.Product
                         join j in db.Deliver on
                         i.Olib_KeluvchiID equals j.ID
                         join k in db.Categories on
                         i.CategoryID equals k.ID
                         select new
                         {
                             Number = i.ID,
                             Product_name = i.Product_Name,
                             UnitPrice = i.Unit_Price,
                             UnitsInStock = i.UnitsInStock,
                             UnitsOnOrder = i.UnitsOnOrder,
                             EnterDate = i.EnterDate,
                             LastDate = i.LastDate,
                             Categories_name = k.Categories_name,
                             Description = k.Description,
                             Company_name = j.Company_name,
                             Cantract_name = j.Contract_name,
                             CantractTitle = j.Contract_Title,
                             Country = j.Country,
                             Address = j.Address,
                             City = j.City

                         }).ToList();
            daG.DataSource = query;
        }

        ///Remove
        public ProductClass(int removeItem)
        {
            try
            {
                Product pr = db.Product.Find(removeItem);
                db.Product.Remove(pr);
                db.SaveChanges();
                AddData.Remove();
            }
            catch (Exception es)
            {
                AddData.ExceptionError(es);
            }
        }

        /// UpDate --Product<>
        public ProductClass(int UPDateItem, string a)
        {
            var query = (from i in db.Product
                         join j in db.Deliver on
                         i.Olib_KeluvchiID equals j.ID
                         join c in db.Categories on
                         i.CategoryID equals c.ID

                         where i.ID == UPDateItem
                         select new
                         {
                             Product_name = i.Product_Name,
                             Product_stock = i.UnitsInStock,
                             Product_Price = i.Unit_Price,
                             Enter_Time = i.EnterDate,
                             Last_Time = i.LastDate,
                             CategoryID = c.ID,
                             Olib_KeluvchiID = j.ID

                         }).ToList();
           Add_Product add = new Add_Product();
            JoinComBoxItems(add);
            foreach (var item in query)
            {
                add.txtProductname.Text = item.Product_name;
                add.txtProductPrice.Text = item.Product_Price.ToString();
                add.txtProductStock.Text = item.Product_stock.ToString();
                add.dateEnterDate.Value = (DateTime)item.Enter_Time;
                add.dateLastDate.Value = (DateTime)item.Last_Time;
                add.cobCategory.SelectedValue = item.CategoryID;
                add.cobSupplier.SelectedValue = item.Olib_KeluvchiID;

            }
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK)
            {
                Product pro = db.Product.Find(UPDateItem);
                pro.Product_Name = add.txtProductname.Text;
                pro.Unit_Price = decimal.Parse(add.txtProductPrice.Text);
                pro.UnitsInStock = int.Parse(add.txtProductStock.Text);
                pro.Olib_KeluvchiID = (int)add.cobSupplier.SelectedValue;
                pro.CategoryID = (int)add.cobCategory.SelectedValue;
                pro.EnterDate = add.dateEnterDate.Value;
                pro.LastDate = add.dateLastDate.Value;
                db.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                AddData.DataChange();
            }
            else
            {
                AddData.notDataChange();
            }




        }
    }

    class CategoryClass
    {
        MarketEntities db = new MarketEntities();
        Add_Categorya r = new Add_Categorya();
        Categories cat = new Categories();
        ///Add Category 
        public CategoryClass()
        {


            DialogResult result = r.ShowDialog();
            if (DialogResult.OK == result)
            {
                cat.Categories_name = r.txtCategoryname.Text;
                cat.Description = r.txtDiscription.Text;
                cat.PhotoPath = r.txtPhotoPath.Text;
                db.Categories.Add(cat);
                db.SaveChanges();
                AddData.add();

            }
            else
            {
                AddData.notadd();

            }
        }

        ///view
        public CategoryClass(DataGridView DatG)
        {
            var query = (from i in db.Categories
                         select i).ToList();
            DatG.DataSource = query;
        }

        //remove
        public CategoryClass(int removeIndex)
        {
            try
            {
                cat = db.Categories.Find(removeIndex);
                db.Categories.Remove(cat);
                db.SaveChanges();
                AddData.Remove();
            }
            catch (Exception es)
            {
                AddData.ExceptionError(es);
            }
        }

        ///UpDate Category Items
        public CategoryClass(int UpDateItem, string a)
        {
            var query = (from i in db.Categories
                         where i.ID == UpDateItem
                         select i).ToList();
            foreach (var item in query)
            {
                r.txtCategoryname.Text = item.Categories_name;
                r.txtDiscription.Text = item.Description;
                r.txtPhotoPath.Text = item.PhotoPath;

            }
            DialogResult result = r.ShowDialog();
            if (result == DialogResult.OK)
            {
                cat = db.Categories.Find(UpDateItem);
                cat.Categories_name = r.txtCategoryname.Text;
                cat.Description = r.txtDiscription.Text;
                cat.PhotoPath = r.txtPhotoPath.Text;
                db.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                AddData.DataChange();
            }
            else
            {
                AddData.notDataChange();
            }






        }


    }

    class SuppliersClass
    {
        MarketEntities db = new MarketEntities();
        Add_Deliver add = new Add_Deliver();
        Deliver sup = new Deliver();

        /// Add Olib keluvchi:
        public SuppliersClass()
        {

            DialogResult result = add.ShowDialog();

            if (result == DialogResult.OK)
            {
                sup.Company_name = add.txtCompanyname.Text;
                sup.Contract_name = add.txtContractname.Text;
                sup.Contract_Title = add.txtContractTitle.Text;
                sup.Country = add.combCountry.Text;
                sup.Full_name = add.txtFullname.Text;
                sup.Company_Phone = add.txtPhoneNumber.Text;
                sup.City = add.combCity.Text;
                sup.Address = add.txtAddress.Text;
                db.Deliver.Add(sup);
                db.SaveChanges();
                AddData.add();
            }
            else
            {
                AddData.notadd();
            }
        }

        /// view     
        public SuppliersClass(DataGridView DatG)
        {
            var query = (from i in db.Deliver
                         select i).ToList();
            DatG.DataSource = query;
        }

        /// Remove
        public SuppliersClass(int id)
        {
            try
            {
                Deliver r = db.Deliver.Find(id);
                db.Deliver.Remove(r);
                db.SaveChanges();
                AddData.Remove();
            }
            catch (Exception ex)
            {
                AddData.ExceptionError(ex);
            }
        }

        ///UpDate Olib keluvchi Items
        public SuppliersClass(int UpDateItem, string a)
        {
            var query = (from i in db.Deliver
                         where i.ID == UpDateItem
                         select i).ToList();
            foreach (var item in query)
            {
                add.txtFullname.Text = item.Full_name;
                add.txtPhoneNumber.Text = item.Company_Phone;
                add.txtCompanyname.Text = item.Company_name;
                add.txtContractname.Text = item.Contract_name;
                add.txtContractTitle.Text = item.Contract_Title;
                add.txtAddress.Text = item.Address;
                add.combCountry.Text = item.Country;
                add.combCity.Text = item.City;

            }

            DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK)
            {
                sup = db.Deliver.Find(UpDateItem);
                sup.Company_name = add.txtCompanyname.Text;
                sup.Contract_name = add.txtContractname.Text;
                sup.Contract_Title = add.txtContractTitle.Text;
                sup.City = add.combCity.Text;
                sup.Country = add.combCountry.Text;
                sup.Address = add.txtAddress.Text;
                sup.Full_name = add.txtFullname.Text;
                sup.Company_Phone = add.txtPhoneNumber.Text;
                db.Entry(sup).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                AddData.DataChange();
            }
            else
            {
                AddData.notDataChange();
            }
        }

    }
}
