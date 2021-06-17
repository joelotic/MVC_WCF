

using System.Web.Mvc;
 


namespace Client_WebMVC.Controllers
{
    public class HomeController : Controller
    {
        FirstWebServiceReference client = 

             //client = new FirstWebServiceReference();
        public ActionResult Index()
        {
            client.
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
    }
}