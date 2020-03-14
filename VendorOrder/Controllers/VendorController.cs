using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.Instances;
      return View(vendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New() {return View();}

    [HttpPost("/vendors")]
    public ActionResult Create(string vendName, string description)
    {
      Vendor newVendor = new Vendor(vendName, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int Id)
    {
      Console.WriteLine("touched show");
      Vendor chosenVendor = Vendor.Find(Id);
      return View(chosenVendor);
    }

    [HttpPost("/vendors/{Id}")]
    public ActionResult Update(Dictionary<string, object> model)
    {
      Console.WriteLine("in Update");
      int Id = (int) model["Id"];
      Order theOrder = (Order) model["newOrder"];
      Vendor thisVendor = Vendor.Find(Id);
      thisVendor.AddOrder(theOrder);
      return RedirectToAction("Show", Id);
    
    }

      [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult NewOrder( int Id) 
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
      return RedirectToAction("Update", model); 
    }
  }
}

// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using VendorOrder.Models;
// using System;

// namespace VendorOrder.Controllers
// {
//   public class OrderController : Controller
//   {
//     [HttpGet("/vendors/{Id}/orders/new")]
//     public ActionResult New( int Id) 
//     {
//       Vendor currentVendor = Vendor.Find(Id);
//       return View(currentVendor);
//     }
//     [HttpPost("/vendors/{Id}/orders")]
//     public ActionResult Create(string title, string description, int price, string date, string ingredients, int Id)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       int thisId = Id;
//       Console.WriteLine("Id" + Id);
//       Order newOrder = new Order(title, description, price, date, ingredients);
//       model.Add("Id" ,Id);
//       model.Add("Order" ,newOrder);
//       return RedirectToAction("update", "vendors", model); //unable to reach Update in vendorscontroller~ unsure how
//     }
    
    
//   }
// }
