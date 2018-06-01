using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer;
using DataLayer;


namespace DataLayer
{
    public class OrderData
    {

        public static void InsertOrderData(int Order_Id5,int Customer_Id5,int Medicine_Id5, DateTime OrderDate5)
        {
            var context = new DataInformationContext();



            context.OrderInfos.Add(new OrderInfo()
            {

                Order_Id = Order_Id5,
                Customer_Id=Customer_Id5,
                Medicine_Id= Medicine_Id5,
                OrderDate = OrderDate5

            });

            context.SaveChanges();




        }



    }
}
