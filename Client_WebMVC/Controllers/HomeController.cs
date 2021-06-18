

using System.Web.Mvc;
using Client_WebMVC.ServiceReference1_3;


namespace Client_WebMVC.Controllers
{
    public class HomeController : Controller
    {

        FirstWebServiceClient sc = new FirstWebServiceClient();
        
        public ActionResult Index()
        {
            ViewBag.X = sc.Message(); 
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