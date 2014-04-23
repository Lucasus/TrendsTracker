using System;
using System.Web.Mvc;

namespace TrendsTracker.Tests.Js.Controllers
{
    public class JasmineController : Controller
    {
        public ActionResult Run()
        {
            return new RedirectResult("/spec_runner.html");
        }
    }
}
