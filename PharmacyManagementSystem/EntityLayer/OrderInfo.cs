using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class OrderInfo
    {
       
        public int Id { get;set; }
        public int Order_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Medicine_Id { get; set; }
        public DateTime OrderDate { get; set; }
       

        //public virtual ICollection<CustomerInfo> CustomerInfos { get; set; }
        //public virtual MedicineInfo MedicineInfo { get; set; }


    }
}
