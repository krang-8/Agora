using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal static class UserRepository
    {
        internal async static Task<List<User>> GetUsersAsync()
        {

            using (var db = new AppDBContext())
            {
                return await db.Users.ToListAsync();
            }
        }


        internal async static Task<User> GetUserByIdAsync(int UserId)
        {
            using (var db = new AppDBContext())
            {
                return await db.Users
                    .FirstOrDefaultAsync(user => user.UserId == UserId);
            }
        }

        internal async static Task<bool> CreateUserAsync(User UserToCreate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Users.AddAsync(UserToCreate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        internal async static Task<bool> UpdateUserAsync(User UserToUpdate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    db.Users.Update(UserToUpdate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> DeleteUserAsync(int UserId)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    User UserToDelete = await GetUserByIdAsync(UserId);
                    db.Remove(UserToDelete);
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
