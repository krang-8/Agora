using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal static class SellerRepository
    {
        internal async static Task<List<Seller>> GetSellersAsync()
        {

            using (var db = new AppDBContext())
            {
                return await db.Sellers.ToListAsync();
            }
        }


        internal async static Task<Seller> GetSellerByIdAsync(int SellerId)
        {
            using (var db = new AppDBContext())
            {
                return await db.Sellers
                    .FirstOrDefaultAsync(seller => seller.SellerId == SellerId);
            }
        }

        internal async static Task<bool> CreateSellerAsync(Seller SellerToCreate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Sellers.AddAsync(SellerToCreate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        internal async static Task<bool> UpdateSellerAsync(Seller SellerToUpdate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    db.Sellers.Update(SellerToUpdate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> DeleteSellerAsync(int SellerId)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    Seller SellerToDelete = await GetSellerByIdAsync(SellerId);
                    db.Remove(SellerToDelete);
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
