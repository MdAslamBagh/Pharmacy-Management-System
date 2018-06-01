using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
   public class CustomerInfo
    {
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
       
        //public virtual ICollection<OrderInfo> OrderInfos { get; set; }


    }
}
