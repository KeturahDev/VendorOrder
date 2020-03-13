using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult New( int Id) 
    {
      Vendor currentVendor = Vendor.Find(Id);
      return View(currentVendor);
    }
    [HttpPost("/vendors/{Id}/orders")]
    public ActionResult Create(string title, string description, int price, string date, string ingredients, int Id)
    {
      int thisId = Id;
      Order newOrder = new Order(title, description, price, date, ingredients);
      return RedirectToAction("edit", "vendors/1", newOrder);
    }
    
    
  }
}
