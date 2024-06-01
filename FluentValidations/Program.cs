// See https://aka.ms/new-console-template for more information
using FluentValidation;

Console.WriteLine("Hello, World!");

Customer cust = new Customer() { CustomerDiscount = 4, IsPreferredCustomer = false, CreditCardNumber=123, Photo= "" };

//var result = new CustomerValidator().Validate(cust);
var result2 = new CustomerValidator().Validate(cust);

Console.WriteLine(result2);

public class Customer
{
    public int? CustomerDiscount { get; set; }
    public int CreditCardNumber { get; set; }
    public bool IsPreferredCustomer { get; set; }
    public string Photo { get; set; }

}

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        

        RuleFor(customer => customer.Photo)
        .NotEmpty().WithMessage("photo is empty")
        .Matches("https://wwww.photos.io/\\d+\\.png")
        .When(customer => customer.IsPreferredCustomer, ApplyConditionTo.AllValidators).WithMessage("yo")
        .Matches("https://wwww.photos.io/\\d*\\.png")
        .When(customer => !customer.IsPreferredCustomer, ApplyConditionTo.CurrentValidator);
    }
}


