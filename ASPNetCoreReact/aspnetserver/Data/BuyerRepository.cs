using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal static class BuyerRepository
    {
        internal async static Task<List<Buyer>> GetBuyersAsync()
        {

            using (var db = new AppDBContext())
            {
                return await db.Buyers.ToListAsync();
            }
        }


        internal async static Task<Buyer> GetBuyerByIdAsync(int BuyerId)
        {
            using (var db = new AppDBContext())
            {
                return await db.Buyers
                    .FirstOrDefaultAsync(buyer=> buyer.BuyerId == BuyerId);
            }
        }

        internal async static Task<bool> CreateBuyerAsync(Buyer BuyerToCreate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Buyers.AddAsync(BuyerToCreate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        internal async static Task<bool> UpdateBuyerAsync(Buyer BuyerToUpdate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    db.Buyers.Update(BuyerToUpdate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> DeleteBuyerAsync(int BuyerId)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    Buyer BuyerToDelete = await GetBuyerByIdAsync(BuyerId);
                    db.Remove(BuyerToDelete);
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
