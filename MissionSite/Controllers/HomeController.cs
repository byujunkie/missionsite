using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Missions()
        {
            ViewBag.Message = "Missions Page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MexicoPueblaSouth()
        {
            ViewBag.Q1 = "Mission Name: ";
            ViewBag.Q2 = "Mission President: ";
            ViewBag.Q3 = "Mission Address: ";
            ViewBag.Q4 = "Mission Language: ";
            ViewBag.Q5 = "Mission Climate ";
            ViewBag.Q6 = "Country Flag: "; 

            ViewBag.Title = "Mexico Puebla South Facts";
            ViewBag.MissionName = "Mexcio Puebla South Mission";
            ViewBag.MissionPresident = "President John Stellmon";
            ViewBag.MissionAddress = "Mexico Puebla Mission Sur 31 Poniente 109 Int.201 Colonia Chula VistaPuebla, Puebla Mexico 72420";
            ViewBag.Language = "Spanish";
            ViewBag.Climate = " Subtropical highland climate";

            return View();
        }
        //public ActionResult FortCollins(string MissionName, string MissionPresident, string MissionAddress, string Language, string Climate)
        public ActionResult FortCollins()    
    {
            ViewBag.Q1 = "Mission Name: ";
            ViewBag.Q2 = "Mission President: ";
            ViewBag.Q3 = "Mission Address: ";
            ViewBag.Q4 = "Mission Language: ";
            ViewBag.Q5 = "Mission Climate ";
            ViewBag.Q6 = "Country Flag: "; 

            ViewBag.Title = "Fort Collins Mission ";
            
            ViewBag.MissionName = "Colorado Fort Collins Mission\n";
            ViewBag.MissionPresident = "President Sean S. McMurray\n";
            ViewBag.MissionAddress = "Colorado Fort Collins Mission\n"+
                                        " 500 Hillspire Dr\n"+
                                        " Windsor CO 80550\n"+
                                        " \nUSA";

            ViewBag.Language = "English\n";
            ViewBag.Climate = "semi-arid climate";
            

            return View();
        }
        public ActionResult SpainBarcelona()
        {
            ViewBag.Q1 = "Mission Name: ";
            ViewBag.Q2 = "Mission President: ";
            ViewBag.Q3 = "Mission Address: ";
            ViewBag.Q4 = "Mission Language: ";
            ViewBag.Q5 = "Mission Climate ";
            ViewBag.Q6 = "Country Flag: "; 

            ViewBag.Title = "Spain Barcelona FAQ's";
            ViewBag.MissionName = "Spain Barcelona Mission";
            ViewBag.MissionPresident = "President Mark L. Pace";
            ViewBag.MissionAddress = "Spain Barcelona Mission Calle Calatrava No 10-12, bajos Barcelona 08017 Barcelona Spain";
            ViewBag.Language = "Spanish";
            ViewBag.Climate = " Subtropical-Mediterranean climate";
            

            return View();
        }
        
    }
}