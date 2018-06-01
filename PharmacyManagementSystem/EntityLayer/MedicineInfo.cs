using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class MedicineInfo
    {
        public int Id { get; set; }
        public int Medicine_Id { get; set; }
        public string Medicine_Name { get; set; }
        public string Medicine_Catagory { get; set; }
        public string Dosage { get; set; }
        public string Manufacturer { get; set; }
        public int Medicine_Available { get; set; }
        public DateTime Entry_Date { get; set; }
        public DateTime Production_Date { get; set; }
        public DateTime Expire_Date { get; set;}
        public int Buying_Price { get; set; }
        public int Selling_Price { get; set; }
       
      

    }
}








