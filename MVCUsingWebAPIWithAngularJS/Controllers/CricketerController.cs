using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


public class CricketerController : Controller
{
    // GET: Cricketer
    public ActionResult Index()
    {
        return View();
    }

    [ChildActionOnly]
    public ActionResult GetHtmlPage(string path)
    {
        return new FilePathResult(path, "text/html");
    }
}
