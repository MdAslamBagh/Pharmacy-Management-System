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
    public class EmployeeData
    {
        public static void InsertEmployee(string FullName3, string MobileNumber3, DateTime Dob3, string Address3, string Email3, int Salary3, string UserName3, string Password3)
        {

            var context = new DataInformationContext();

            context.EmployeeInfos.Add(new EmployeeInfo()
            {

                FullName = FullName3,
                MobileNumber = MobileNumber3,
                Dob = Dob3,
                Address = Address3,
                Email = Email3,
                Salary = Salary3,
                UserName = UserName3,
                Password = Password3
            });

            context.SaveChanges();




        }
    }
}

