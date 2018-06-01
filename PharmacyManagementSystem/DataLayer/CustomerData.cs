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
    public class CustomerData
    {
        public static void InsertCustomerData(int Customer_Id3,string CustomerName3, string Phone3, string Address3, string City3,string PostalCode3,string Country3)
        {
            var context = new DataInformationContext();

            context.CustomerInfos.Add(new CustomerInfo()
            {
               Customer_Id = Customer_Id3,
               CustomerName =CustomerName3,
               Phone=Phone3,
               Address= Address3,
               City=City3,
               PostalCode= PostalCode3,
               Country=Country3
               

            });

            context.SaveChanges();



        }
    }
}



