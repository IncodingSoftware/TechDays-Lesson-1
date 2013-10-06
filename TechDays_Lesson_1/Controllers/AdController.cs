namespace TechDays_Lesson_1.Controllers
{
    #region << Using >>

    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Incoding.MvcContrib;
    using TechDays_Lesson_1.Models;

    #endregion

    public class AdController : Controller
    {
        #region Static Fields

        static List<AdVm> ads = new List<AdVm>();

        #endregion

        #region Http action

        [HttpPost]
        public ActionResult Add(AddAdCommand command)
        {
            ads.Add(new AdVm
                        {
                                Name = command.Name,
                                Root = command.Root,
                                Sub = command.Sub
                        });
            return IncodingResult.Success();
        }

        [HttpPost]
        public ActionResult Del(string name)
        {
            int index = ads.FindIndex(r => r.Name == name);
            ads.RemoveAt(index);
            return IncodingResult.Success();
        }

        [HttpGet]
        public ActionResult Fetch(SearchAdQuery query)
        {
            return IncodingResult.Success(ads.Where(r => string.IsNullOrWhiteSpace(query.Root) || r.Root == query.Root)
                                             .Where(r => string.IsNullOrWhiteSpace(query.Sub) || r.Sub == query.Sub));
        }

        [HttpPost]
        public ActionResult RemoveAll()
        {
            ads = new List<AdVm>();
            return IncodingResult.Success();
        }

        #endregion
    }
}