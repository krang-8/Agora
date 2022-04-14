using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal static class OrderRepository
    {
        internal async static Task<List<Order>> GetOrdersAsync()
        {

            using (var db = new AppDBContext())
            {
                return await db.Orders.ToListAsync();
            }
        }



        internal async static Task<bool> CreateOrderAsync(Order OrderToCreate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Orders.AddAsync(OrderToCreate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

    }
}
