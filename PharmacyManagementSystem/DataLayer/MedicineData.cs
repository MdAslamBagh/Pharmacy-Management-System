using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLayer
{
    public class MedicineData
    {

    

        public static void InsertPermacyData(string Medicine_Name2, string Medicine_Catagory2,string Dosage2, string Manufacturer2,int Medicine_Available2, DateTime Entry_Date2, DateTime Production_Date2, DateTime Expire_Date2, int Buying_Price2, int Selling_Price2, int Medicine_Id2)
        {
            var context = new DataInformationContext();



            context.MedicineInfos.Add(new MedicineInfo()
            {



                Medicine_Name = Medicine_Name2,
                Medicine_Catagory = Medicine_Catagory2,
                Dosage = Dosage2,
                Manufacturer = Manufacturer2,
           
                Medicine_Available=Medicine_Available2,
                Entry_Date = Entry_Date2,
                Production_Date = Production_Date2,
                Expire_Date = Expire_Date2,
                Buying_Price = Buying_Price2,
                Selling_Price = Selling_Price2,
                Medicine_Id= Medicine_Id2


            });

            context.SaveChanges();




        }

      


        //public IEnumerable<dynamic> showMedicine(string MedicineName)
        //{
        //    var context = new DataInformationContext();
        //    var AllMedicine = (from Medicine in context.MedicineInfos
        //                       where Medicine.Medicine_Name == MedicineName
        //                       select Medicine);

        //    return AllMedicine.ToList();
        //}

    }
}