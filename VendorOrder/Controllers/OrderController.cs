using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

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
      Dictionary<string, object> model = new Dictionary<string, object>();
      int thisId = Id;
      Console.WriteLine("Id" + Id);
      Order newOrder = new Order(title, description, price, date, ingredients);
      model.Add("Id" ,Id);
      model.Add("Order" ,newOrder);
      return RedirectToAction("update", "vendors", model); //unable to reach Update in vendorscontroller~ unsure how
    }
    
    
  }
}
