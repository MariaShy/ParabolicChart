using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyChartASPnetMVC.Models
{
    public class UserDataDbInitializer : DropCreateDatabaseAlways<UserDataContext>
    {
        protected override void Seed(UserDataContext db)
        {
            db.UserDatas.Add(new UserData { a = 5, b = 5, c = 16, step = 1.0F, RangeFrom = -10, RangeTo = 10 });            

            base.Seed(db);
        }
    }
}