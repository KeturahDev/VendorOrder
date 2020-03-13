using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void ConstructVendor_CreateInstanceOfVendor_Vendor()
    {
      string name = "BananaBakery";
      string description = "Pierre's first Vendor";
      Vendor firstVendor = new Vendor(name, description);

      Vendor result = firstVendor;

      Assert.AreEqual(typeof(Vendor), result.GetType());
    }
    [TestMethod]
    public void Count_CountNumberOfInstancesOfVendor_int()
    {
      string name = "BananaBakery";
      string description = "Pierre's first Vendor";
      Vendor firstVendor = new Vendor(name, description);

      int vendorQuantity = Vendor.Instances.Count;

      Assert.AreEqual(1, vendorQuantity);
    }
    [TestMethod]
    public void Find_ReturnSpecificVendorById_Vendor()
    {
      string name = "BananaBakery";
      string description = "Pierre's first Vendor";
      Vendor firstVendor = new Vendor(name, description);
      string name2 = "MarkoFellows";
      string description2 = "muffins made by Pierre's friend Marko";
      Vendor secondVendor = new Vendor(name2, description2);

      Vendor result = Vendor.Find(2);
      // Console.WriteLine("result type" + Vendor.Find(2).GetType());

      Assert.AreEqual(secondVendor.Id, result.Id);
    }
  }
}