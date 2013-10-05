namespace TechDays_Lesson_1.Controllers
{
    #region << Using >>

    using System.Collections.Generic;
    using System.Web.Mvc;
    using Incoding.MvcContrib;

    #endregion

    public class CategoryController : Controller
    {
        #region Http action

        [HttpGet]
        public ActionResult FetchRoot()
        {
            var vms = new List<KeyValueVm>
                          {
                                  new KeyValueVm("Cars"), 
                                  new KeyValueVm("Houses"), 
                                  new KeyValueVm("Electronics"), 
                          };
            return IncodingResult.Success(vms);
        }

        [HttpGet]
        public ActionResult FetchSub(string root)
        {
            var vms = new Dictionary<string, List<KeyValueVm>>
                          {
                                  {
                                          "Cars", new List<KeyValueVm>
                                                      {
                                                              new KeyValueVm("Coupe"), 
                                                              new KeyValueVm("Jeep"), 
                                                              new KeyValueVm("Sedan"), 
                                                      }
                                  }, 
                                  {
                                          "Houses", new List<KeyValueVm>
                                                        {
                                                                new KeyValueVm("Rooms"), 
                                                                new KeyValueVm("Apartments"), 
                                                        }
                                  }, 
                                  {
                                          "Electronics", new List<KeyValueVm>
                                                             {
                                                                     new KeyValueVm("Phones"), 
                                                                     new KeyValueVm("Computers"), 
                                                             }
                                  }, 
                          };
            return IncodingResult.Success(vms[root]);
        }

        #endregion
    }
}