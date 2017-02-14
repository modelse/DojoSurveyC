using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace ConsoleApplication.Controllers
{
 public class SurveyController : Controller
 {
  [HttpGet]
  [Route("index")]
  public IActionResult Index()
  {
   return View();
   //OR
  
   //Both of these returns will render the same view (You only need one!)
  }
  [HttpPost]
  [Route("survey")]
  public IActionResult Method(string name, string location, string language, string comment)
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
    return View("index");
  //Code Here
  }
 }
}