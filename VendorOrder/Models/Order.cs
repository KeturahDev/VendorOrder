namespace VendorOrder.Models
{
  public class Order
  {
    public string Title {get;set;}
    public string Description {get;set;}
    public int Price {get;set;}
    public string Date {get;set;}
    public string Ingredients {get;set;}

    public Order (string title, string description, int price, string date, string ingredients)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Ingredients = ingredients;
    }
  }
}