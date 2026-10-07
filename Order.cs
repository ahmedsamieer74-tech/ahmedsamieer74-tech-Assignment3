namespace CSharpBasicsAssignment;

public class Order
{
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public decimal DiscoutPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;

    public void CalculateTotal()
    {
        TotalPrice = Quantity * UnitPrice * (1 - DiscoutPercent / 100);
    }

    public void PrintSummary()
    {
        Console.WriteLine($"The customer name is {CustomerName} , The order is {OrderId} , The total price is {TotalPrice} , The paid {IsPaid}");
    }
}