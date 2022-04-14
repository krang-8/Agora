using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal static class ItemRepository
    {
        internal async static Task<List<Item>> GetItemsAsync()
        {

            using (var db = new AppDBContext())
            {
                return await db.Items.ToListAsync();
            }
        }


        internal async static Task<Item> GetItemByIdAsync(int ItemID)
        {
            using (var db = new AppDBContext())
            {
                return await db.Items
                    .FirstOrDefaultAsync(item => item.ItemID == ItemID);
            }
        }

        internal async static Task<bool> CreateItemAsync(Item itemToCreate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Items.AddAsync(itemToCreate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        internal async static Task<bool> UpdateItemAsync(Item itemToUpdate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    db.Items.Update(itemToUpdate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> DeleteItemAsync(int ItemID)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    Item itemToDelete = await GetItemByIdAsync(ItemID);
                    db.Remove(itemToDelete);
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
