using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    
    class BuyProduct
    {
        MarketEntities db = new MarketEntities();
        public int BuyProductOrders(int EployeeID,string MoneyType)
        {
            Orders r = new Orders();
            r.EmployeeID = EployeeID;
            r.Money_Type = MoneyType;
            r.OrderDate=DateTime.Now;
            db.Orders.Add(r);
            db.SaveChanges();
            int q = (from i in db.Orders
                     select new
                     {
                         id = i.ID
                     }).Max(p => p.id);
            return q;
          
        }
        public void BuyProductAA(int orderID,int quentity,int ProductID,decimal Price,int de)
        {
            Order_Details rr = new Order_Details();
            rr.OrderID = orderID;
            rr.Quentity = quentity;
            rr.UnitPrice = Price;
            rr.ProductID = ProductID;
            rr.Discount = de;
            db.Order_Details.Add(rr);
            db.SaveChanges();
        }
    }
}
