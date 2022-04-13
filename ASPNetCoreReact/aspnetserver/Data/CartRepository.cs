using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal static class CartRepository
    {
        internal async static Task<List<Cart>> GetCartsAsync()
        {

            using (var db = new AppDBContext())
            {
                return await db.Carts.ToListAsync();
            }
        }


        internal async static Task<Cart> GetCartByIdAsync(int CartID)
        {
            using (var db = new AppDBContext())
            {
                return await db.Carts
                    .FirstOrDefaultAsync(cart => cart.CartID == CartID);
            }
        }

        internal async static Task<bool> CreateCartAsync(Cart CartToCreate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Carts.AddAsync(CartToCreate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        internal async static Task<bool> UpdateCartAsync(Cart CartToUpdate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    db.Carts.Update(CartToUpdate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> DeleteCartAsync(int CartID)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    Cart CartToDelete = await GetCartByIdAsync(CartID);
                    db.Remove(CartToDelete);
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
