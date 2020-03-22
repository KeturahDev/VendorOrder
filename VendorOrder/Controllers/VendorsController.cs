using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Controllers
{
  public class VendorsController : Controller
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
      Vendor chosenVendor = Vendor.Find(Id);
      return View(chosenVendor);
    }

    [HttpPost("/vendors/{Id}/orders")]
    public ActionResult Create(string title, string description, int price, string date, string ingredients, int Id)
    {
      Order newOrder = new Order(title, description, price, date, ingredients);
      Vendor currentVendor = Vendor.Find(Id);
      currentVendor.AddOrder(newOrder);
      return RedirectToAction("Show"); //unable to reach Update in vendorscontroller~ unsure how
    }
  }
}