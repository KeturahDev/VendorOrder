using System.Collections.Generic;
namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name {get;set;}
    public string Description {get;set;}
    public static List<Vendor> Instances {get;set;} = new List<Vendor> {};
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Instances.Add(this);
    }
  }
}