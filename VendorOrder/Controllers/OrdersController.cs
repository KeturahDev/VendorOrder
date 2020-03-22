using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult New( int Id) 
    {
      Vendor currentVendor = Vendor.Find(Id);
      return View(currentVendor);
    }
  }
}