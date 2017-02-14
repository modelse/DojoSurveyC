using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace ConsoleApplication.Controllers
{
 public class SurveyController : Controller
 {
   //Index method of your aspp's first route is usually just "" for the home route
  [HttpGet]
  [Route("")]
  public IActionResult Index()
  {
   return View();
   //OR
  
   //Both of these returns will render the same view (You only need one!)
  }
  [HttpPost]
  [Route("survey")]
  //Method is not a great method name~!
  // public IActionResult Method(string name, string location, string language, string comment)
  public IActionResult SurveyResults(string name, string location, string language, string comment)
  {
    ViewBag.Name= name;
    ViewBag.Location= location;
    ViewBag.Language= language;
    ViewBag.Comment= comment;

    return View("Results");
  //Code Here
  }
  [HttpPost]
  [Route("goback")]
  public IActionResult GoBack()
  {
    //Instead of loading a view from here you can use a redirect
    //return View("index");
    return RedirectToAction("Index");

    //Note I also added an <a> tag to your view to show you don't need to make a post request for this :)
  }
 }
}