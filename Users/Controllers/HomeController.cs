using System.Web.Mvc;

namespace Users.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
           
            return View();
        }
	}
}