using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTest
  {
    [TestMethod]
    public void ConstructVendor_CreateInstanceOfVendor_Vendor()
    {
      string name = "BananaBakery";
      string description = "Pierre's first Vendor";
      Vendor firstVendor = new Vendor(name, description);

      Vendor result = firstVendor;

      Assert.AreEqual(typeof(Vendor), result.GetType());
    }
  }
}