using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;

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
  }
}