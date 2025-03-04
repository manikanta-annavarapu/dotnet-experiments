using AMK.CleanArchitecture.Domain.Entities;

namespace AMK.CleanArchitecture.Domain.Interfaces;

public interface IOrderRepository
{
    void Add(Order order);
}
