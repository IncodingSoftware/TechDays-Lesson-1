namespace TechDays_Lesson_1.Controllers
{
    #region << Using >>

    using System.Web.Mvc;

    #endregion

    public class HomeController : Controller
    {
        #region Http action

        [HttpGet]
        public ActionResult Iml()   
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Jquery()
        {
            return View();
        }

        #endregion
    }
}