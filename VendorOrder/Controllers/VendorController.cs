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
  }
}