using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Mvc;
using MyChartASPnetMVC.Models;

namespace MyChartASPnetMVC.Controllers
{
    public class HomeController : Controller
    {
        int[] px;
        int[] py;

        // создаем контекст данных
        UserDataContext db = new UserDataContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты UserData
            IEnumerable<UserData> ud = db.UserDatas;
            // передаем все объекты в динамическое свойство UserDatas в ViewBag
            ViewBag.UserDatas = ud; 
            
           //List<UserData> ud = new List<UserData>();
           //ud.Add(new UserData { a=5,b=5,c=16,step=1.0F,RangeFrom=-10,RangeTo=10 }) ;

            return View();
        }

        [HttpPost]
        public Chart Index(UserData udFirst)
        {
            if (ModelState.IsValid)
            {
                Point pt = new Point();
                //UserData udFirst = ud[0];

                int n = (udFirst.RangeTo - udFirst.RangeFrom) / (int)udFirst.step;
                px = new int[n + 1];
                py = new int[n + 1];
                int i;
                for (i = 0, pt.PointX = udFirst.RangeFrom; pt.PointX <= udFirst.RangeTo; pt.PointX += (int)udFirst.step, i++)
                {
                    pt.PointY = udFirst.a * (pt.PointX * pt.PointX) + udFirst.b * pt.PointX + udFirst.c;
                    px[i] = pt.PointX;
                    py[i] = pt.PointY;
                }

                return new Chart(600, 400, ChartTheme.Blue)
                .AddTitle("y = ax^2 + bx + c")
                .AddLegend()
                .AddSeries(
                    name: "Your plot",
                    chartType: "Spline", //not Line :)
                    xValue: px,
                    yValues: py)
                .Write(format: "png");
            }
            else
                return new Chart(300, 300, ChartTheme.Blue)
                .AddTitle("Your data is not valid :( ")
                .Write(format: "png");
        }
    }
}