using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Item[] itemsToSeed = new Item[6];
            User[] usersToSeed = new User[6];
            Cart[] cartsToSeed = new Cart[6];
            Buyer[] buyersToSeed = new Buyer[3];
            Seller[] sellersToSeed = new Seller[3];


            for (int i = 1; i <= 6; i++)
            {
                itemsToSeed[i - 1] = new Item
                {
                    ItemID = i,
                    itemName = $"Item { i}",
                    Description = $"This is item {i} and it is very cheap.",
                    image = $"https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg",
                    itemPrice = i * 10,
                    stock = i * 50,
                    SellerID = i * 1000
                };

                cartsToSeed[i - 1] = new Cart
                {
                    CartID = i * 1000,
                    cartItems = $"1,2,4",
                    BuyerID = i,
                    Quantity = "1,1,2"
                };

                if (i % 2 == 0)
                {
                    usersToSeed[i - 1] = new User
                    {
                        UserId = i ,
                        username = $"User{ i }",
                        password = $"password",
                        userType = i % 2
                    };
                }
                else
                {
                    usersToSeed[i - 1] = new User
                    {
                        UserId = i ,
                        username = $"User{ i}",
                        password = $"password",
                        userType = i % 2
                    };

                }
            }

            for (int i = 0; i < 3; i++)
            {

                buyersToSeed[i ] = new Buyer
                {
                    CartID = i * 1000,
                    Address1 = "addy",
                    Address2 = "ta",
                    Address3 = "bhai home",
                    name = "test",
                    UserId = 2*i + 1 ,
                    BuyerId = 2*i +1
                };
            }
            for (int j = 0; j < 3; j++)
            {
                sellersToSeed[j ] = new Seller
                {
                    Address1 = "addy",
                    name = "test",
                    UserId = (j+1) *2,
                    SellerId = (j+1) *2
                };
            }
        



            modelBuilder.Entity<Item>().HasData(data: itemsToSeed);
            modelBuilder.Entity<User>().HasData(data: usersToSeed);
            modelBuilder.Entity<Cart>().HasData(data: cartsToSeed);
            modelBuilder.Entity<Buyer>().HasData(data: buyersToSeed);
            modelBuilder.Entity<Seller>().HasData(data: sellersToSeed);

        }
    }
}
