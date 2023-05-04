using Microsoft.AspNetCore.Mvc;

namespace p138FirstWebApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {

            return View();


            //if(id % 2 == 0)
            //{
            //    //ContentResult contentResult  = new ContentResult();
            //    //contentResult.Content= $"salam {id}";

            //    //return contentResult;

            //    return Content($"salam {id}");
            //}
            //else if(true)
            //{
            //    //ViewResult viewResult = new ViewResult();
            //    //viewResult.ViewName= "p138";

            //    //return viewResult;

            //    return View("p138");
            //}
            //else
            //{
            //    return Json("");
            //}


            //ContentResult contentResult  = new ContentResult();
            //contentResult.Content= $"salam {name} {age}";

            //return contentResult;
        }
    }
}
