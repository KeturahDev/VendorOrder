using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

// comments mark the intention of each route, and the flow of information from one rout to another

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {
    //list of vendors page | #shows vendors | "there are no vendors"
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.Instances;
      return View(vendorList);
    }

    //New Vendor FORM | SUBMIT GOES TO POST(/VENDORS)
    [HttpGet("/vendors/new")]
    public ActionResult New() {return View();}

    //Creation of Vendor | GOES TO INDEX
    [HttpPost("/vendors")]
    public ActionResult Create(string vendName, string description)
    {
      Vendor newVendor = new Vendor(vendName, description);
      return RedirectToAction("Index");
    }

    //Goes specific dynamic page | *description* + no orders | *description* + orders 
    [HttpGet("/vendors/{Id}")] 
    public ActionResult Show(int Id, Dictionary<string, object> model)
    {
      Console.WriteLine("in Show");

      //------------code from UPDATE --------- 
      // newOrder form is skipping update and going straght here
      
      // int Id = (int) model["Id"];
      // Order theOrder = (Order) model["Order"];
      // Vendor thisVendor = Vendor.Find(Id);
      // thisVendor.AddOrder(theOrder);
      //---------------------------------------

      //-----------old code------------------
      Console.WriteLine("touched show"); 
      Vendor chosenVendor = Vendor.Find(Id);
      return View(chosenVendor);
    }

    // attempting to update. Inaccessable at the moment - is it because of going from CreateOrder POST to UpdateVendor POST?
    //moving functionality from this rouch into CreateOrder route

    // [HttpPost("/vendors/{Id}")]
    // public ActionResult UpdateVendor(Dictionary<string, object> model)
    // {
    //   Console.WriteLine("in Update");
    //   int Id = (int) model["Id"];
    //   Order theOrder = (Order) model["Order"];
    //   Vendor thisVendor = Vendor.Find(Id);
    //   thisVendor.AddOrder(theOrder);
    //   return RedirectToAction("Show", Id);
    // }

    // Takes to OrderForm for {Id} specific Vendor {accessed through button on show page}
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult NewOrder( int Id) 
    {
      Vendor currentVendor = Vendor.Find(Id);
      return View(currentVendor);
    }
    
    // the create for Order | supposed to take information to Update - X | to 
    //to make project work, will do Updates functionality inside of CreateOrder
    [HttpPost("/vendors/{Id}/orders")]
    public ActionResult CreateOrder(string title, string description, int price, string date, string ingredients, int Id)
    {
      // Dictionary<string, object> model = new Dictionary<string, object>();    
      Console.WriteLine("Entered Create Order");
      Console.WriteLine("Order title:" + title);
      Order newOrder = new Order(title, description, price, date, ingredients);
      Vendor thisVendor = Vendor.Find(Id);
      thisVendor.AddOrder(newOrder);
      // model.Add("Id" ,Id);
      // model.Add("Order" ,newOrder);
      return RedirectToAction("Show"); 
    }
  }
}

