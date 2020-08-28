using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace MyChartASPnetMVC.Models
{
    public class UserDataContext : DbContext
    {
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<Point> Points { get; set; }
    }
    
}