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
        static int p = 1;
        static string title = "";

        // создаем контекст данных
        UserDataContext db = new UserDataContext();

        public ActionResult Index()
        {
            ////получаем из бд все объекты UserData
            //IEnumerable<UserData> ud = db.UserDatas;
            ////передаем все объекты в динамическое свойство UserDatas в ViewBag
            //ViewBag.UserDatas = ud;

            return View();
        }

        [HttpPost]
        public Chart Index(UserData udInput)
        {
            if (ModelState.IsValid)
            {
                Point pt = new Point { ChartId=p };                
                p++;
                int n = (udInput.RangeTo - udInput.RangeFrom) / (int)udInput.step;
                px = new int[n + 1];
                py = new int[n + 1];
                int i;
                for (i = 0, pt.PointX = udInput.RangeFrom; pt.PointX <= udInput.RangeTo; pt.PointX += (int)udInput.step, i++)
                {
                    pt.PointY = udInput.a * (pt.PointX * pt.PointX) + udInput.b * pt.PointX + udInput.c;
                    px[i] = pt.PointX;
                    py[i] = pt.PointY;
                    db.Points.Add(pt);
                    db.SaveChanges();
                }

                // добавляем информацию о графике в базу данных                
                db.UserDatas.Add(udInput);
                // сохраняем в бд все изменения
                db.SaveChanges();

                title = "y = "+ udInput.a + "x^2 + "+ udInput.b + "x + "+ udInput.c;

                return new Chart(600, 400, ChartTheme.Blue)
                .AddTitle("y = ax^2 + bx + c")
                .AddLegend()
                .AddSeries(
                    name: title,
                    chartType: "Spline", //not Line :)
                    xValue: px,
                    yValues: py)
                .Write(format: "png");
            }
            else
                return new Chart(300, 300, ChartTheme.Blue)
                .AddTitle("Sorry, your data is not valid :( ")
                .Write(format: "png");
        }
    }
}