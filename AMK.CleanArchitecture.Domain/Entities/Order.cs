namespace AMK.CleanArchitecture.Domain.Entities;

public class Order
{
    public int Id { get; private set; }
    public string CustomerName { get; private set; }
    public decimal Amount { get; private set; }

    public Order(string customerName, decimal amount)
    {
        if (amount < 1)
            throw new ArgumentException("Order amount must be at least 1.");

        CustomerName = customerName;
        Amount = amount;
    }
}
