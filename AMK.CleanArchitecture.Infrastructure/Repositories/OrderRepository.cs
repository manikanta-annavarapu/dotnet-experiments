using AMK.CleanArchitecture.Domain.Entities;
using AMK.CleanArchitecture.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AMK.CleanArchitecture.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _context;

    public OrderRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }
}
