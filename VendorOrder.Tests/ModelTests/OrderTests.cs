using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests //: Disposable
  {
    [TestMethod]
    public void CreateOrder_InstantiateOrderWithConstructor_Order()
    { 
      string title = "Muffin";
      string description = "like a cupcake but not";
      int price = 3;
      string date = "3/31/2020";
      string ingredients = "flour milk eggs sugar";
      Order newOrder = new Order(title, description, price, date, ingredients);

      Order result = newOrder;

      Assert.AreEqual(typeof(Order), result.GetType());
    }
  }
}