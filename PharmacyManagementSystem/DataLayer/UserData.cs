using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer;



namespace DataLayer
{
    public class UserData
    {

        public static void Insertuser(string Name1, string Gender1, string Address1, string MobileNumber1, string UserType1, string UserName1, string Password1)

        {
            var context = new DataInformationContext();
           

            context.UserInfos.Add(new UserInfo()
            {
                Name = Name1,
                Gender = Gender1,
                Address = Address1,
                MobileNumber = MobileNumber1,
                UserType = UserType1,
                UserName = UserName1,
                Password = Password1,


            });
            context.SaveChanges();

        }
    }
}
    
