using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer;




namespace EntityLayer
{
    public class DataInformationContext:DbContext
    {

        public DataInformationContext() : base("AllDataInformation")
        {


        }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<MedicineInfo>MedicineInfos { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
        public DbSet<OrderInfo> OrderInfos { get; set; }

    }


}

