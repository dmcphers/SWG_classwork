using SendDataToASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SendDataToASPNET.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public ActionResult Path1()
    {
      var model = new ProductSearch();

      model.Category = RouteData.Values["category"].ToString();
      model.Subcategory = RouteData.Values["subcategory"].ToString();

      return View("SearchResult", model);
    }

    [HttpGet]
    public ActionResult Path2(string category, string subcategory)
    {
      var model = new ProductSearch();

      model.Category = category;
      model.Subcategory = subcategory;

      return View("SearchResult", model);
    }

    [HttpGet]
    public ActionResult Path3(ProductSearch model)
    {
      return View("SearchResult", model);
    }

    [HttpPost]
    public ActionResult Form1()
    {
      var model = new ProductSearch();

      model.Category = Request.Form["category"].ToString();
      model.Subcategory = Request.Form["subcategory"].ToString();

      return View("SearchResult", model);
    }

    [HttpPost]
    public ActionResult Form2(string category, string subcategory)
    {
      var model = new ProductSearch();

      model.Category = category;
      model.Subcategory = subcategory;

      return View("SearchResult", model);
    }

    [HttpPost]
    public ActionResult Form3(ProductSearch model)
    {
      return View("SearchResult", model);
    }
  }
}