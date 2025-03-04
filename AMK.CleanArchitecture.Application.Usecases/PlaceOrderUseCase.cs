using AMK.CleanArchitecture.Domain.Entities;
using AMK.CleanArchitecture.Domain.Interfaces;

namespace AMK.CleanArchitecture.Application.Usecases;

public class PlaceOrderUseCase
{
    private readonly IOrderRepository _orderRepository;

    public PlaceOrderUseCase(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public void Execute(string customerName, decimal amount)
    {
        var order = new Order(customerName, amount);
        _orderRepository.Add(order);
    }
}
