using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Item>Items { get; set; }
        public DbSet<User>Users { get; set; }
        public DbSet<Cart>Carts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Item[] itemsToSeed = new Item[6];
            User[] usersToSeed = new User[6];
            for (int i=1; i<=6; i++)
            {
                itemsToSeed[i - 1] = new Item
                {
                    ItemID = i,
                    itemName = $"Post { i}",
                    Description = $"This is item {i} and it is very cheap.",
                    image = $"URL",
                    itemPrice = i*10,
                    stock = i*50,
                    SellerID = i*1000
                };

                usersToSeed[i - 1] = new User
                {
                    UserId = i,
                    username = $"Post { i}",
                    password = $"This is item {i} and it is very cheap.",
                    Address1 = $"My Location 1",
                    Address2 = $"My Location 2",
                    Address3 = $"My Location 3",
                    cartID = i * 1000,
                    name = $"My name is Agent {i}",
                    userType = i %2
                };
            }

            modelBuilder.Entity<Item>().HasData(data: itemsToSeed);
            modelBuilder.Entity<User>().HasData(data: usersToSeed);
            modelBuilder.Entity<Cart>();
        }



    }
}
