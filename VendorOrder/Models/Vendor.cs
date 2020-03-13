using System.Collections.Generic;
namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name {get;set;}
    public string Description {get;set;}
    public int Id {get;set;}
    public static List<Vendor> Instances {get;set;} = new List<Vendor> {};
    public List<Order> OrderList {get;set;} = new List<Order> {};
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Instances.Add(this);
      Id = Instances.Count;
    }
    public static void ClearAll()
    {
      Instances.Clear();
    }
    public static Vendor Find( int searchById )
    {
      return Instances[searchById - 1];
    }
    public void AddOrder(Order order)
    {
      // OrderList.Add(order);
    }
  }
}