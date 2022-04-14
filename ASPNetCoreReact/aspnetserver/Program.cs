using aspnetserver.Data;
using Microsoft.OpenApi.Models;
using System.Collections.Specialized;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy",
        builder =>
        {
            builder.AllowAnyMethod()
                   .AllowAnyHeader()
                   .AllowAnyOrigin();
        }
    );
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(swaggerGenOptions =>
{
    swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo { Title = "Yasta", Version = "v1" });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(swaggerUIOptions =>
{
    swaggerUIOptions.DocumentTitle = "ASP.NET API YAAR";
    swaggerUIOptions.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API");
    swaggerUIOptions.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseCors("CORSPolicy");

app.MapGet("/get-all-Items", async () => await ItemRepository.GetItemsAsync())
    .WithTags("Items Endpoints");

app.MapGet("/get-Item-by-id/{ItemId}", async (int ItemId) =>
{
    Item ItemToReturn = await ItemRepository.GetItemByIdAsync(ItemId);

    if (ItemToReturn != null)
    {
        
        return Results.Ok(ItemToReturn);

    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Items Endpoints");

app.MapPost("/create-Item", async (Item ItemToCreate) =>
{
    bool createSuccess = await ItemRepository.CreateItemAsync(ItemToCreate);

    if (createSuccess != null)
    {
        return Results.Ok("Created Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Items Endpoints");

app.MapPut("/update-Item", async (Item ItemToUpdate) =>
{
    bool updateSuccess = await ItemRepository.UpdateItemAsync(ItemToUpdate);

    if (updateSuccess != null)
    {
        return Results.Ok("Updated Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Items Endpoints");


app.MapDelete("/delete-Item-by-id/{ItemId}", async (int ItemId) =>
{
    bool deleteSuccess = await ItemRepository.DeleteItemAsync(ItemId);

    if (deleteSuccess != null)
    {
        return Results.Ok("Deleted Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Items Endpoints");

app.MapGet("/get-all-Users", async () => await UserRepository.GetUsersAsync())
    .WithTags("Users Endpoints");

app.MapGet("/get-User-by-id/{UserId}", async (int UserId) =>
{
    User UserToReturn = await UserRepository.GetUserByIdAsync(UserId);

    if (UserToReturn != null)
    {
        return Results.Ok(UserToReturn);

    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Users Endpoints");

app.MapPost("/create-User", async (User UserToCreate) =>
{
    bool createSuccess = await UserRepository.CreateUserAsync(UserToCreate);

    if (createSuccess != null)
    {
        return Results.Ok("Created Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Users Endpoints");

app.MapPut("/update-User", async (User UserToUpdate) =>
{
    bool updateSuccess = await UserRepository.UpdateUserAsync(UserToUpdate);

    if (updateSuccess != null)
    {
        return Results.Ok("Updated Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Users Endpoints");


app.MapDelete("/delete-User-by-id/{UserId}", async (int UserId) =>
{
    bool deleteSuccess = await UserRepository.DeleteUserAsync(UserId);

    if (deleteSuccess != null)
    {
        return Results.Ok("Deleted Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Users Endpoints");

app.MapGet("/get-seller-items/{sellerID}", async (int sellerID) =>
{
    List<Item> allItems = await ItemRepository.GetItemsAsync();
    List<Item> itemsToReturn = new List<Item>();
    if (allItems != null)
    {
        for (int i = 0; i < allItems.Count; i++)
        {
            if (allItems[i].SellerID == sellerID)
            {
                itemsToReturn.Add(allItems[i]);
            }
        }
        return Results.Ok(itemsToReturn);
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Items Endpoints");

app.MapGet("/get-all-Carts", async () => await CartRepository.GetCartsAsync())
    .WithTags("Carts Endpoints");

app.MapGet("/get-Cart-by-id/{cartId}", async (int cartId) =>
{
    Cart CartToReturn = await CartRepository.GetCartByIdAsync(cartId);

    if (CartToReturn != null)
    {
        string[] cartList = CartToReturn.cartItems.Split(',');
        string[] quantityList = CartToReturn.Quantity.Split(',');
        Dictionary<string,string>[] cart = new Dictionary<string,string>[quantityList.Length];
        for (int i = 0; i < cartList.Length; i++)
        {
            Item cartItemYar = await ItemRepository.GetItemByIdAsync(Convert.ToInt32(cartList[i]));
            Dictionary<string, string> temp = new Dictionary<string, string>();
            temp.Add( "itemPrice",(cartItemYar.itemPrice.ToString()));
            temp.Add("itemName", (cartItemYar.itemName));
            temp.Add("image", (cartItemYar.image));
            temp.Add("quantity", (quantityList[i]));
            temp.Add("itemId", (cartList[i]));
            
            cart[i] = temp;


        }

        return Results.Ok(cart);

    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Carts Endpoints");

app.MapPost("/create-Cart", async (Cart CartToCreate) =>
{
    bool createSuccess = await CartRepository.CreateCartAsync(CartToCreate);

    if (createSuccess != null)
    {
        return Results.Ok("Created Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Carts Endpoints");




app.MapDelete("/delete-Cart-by-id/{CartId}", async (int cartId) =>
{
    bool deleteSuccess = await CartRepository.DeleteCartAsync(cartId);

    if (deleteSuccess != null)
    {
        return Results.Ok("Deleted Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Carts Endpoints");

app.MapGet("/get-all-Buyers", async () =>
{
    List<Buyer> yar = new List<Buyer> (await BuyerRepository.GetBuyersAsync());
    Dictionary<string,string>[] yar2 = new Dictionary<string, string>[yar.Count];

    for (int i = 0; i < yar.Count; i++)
    {
        var getUser = await UserRepository.GetUserByIdAsync(yar[i].UserId);
        string[] addy = new string[3]; 
        Dictionary<string, string> temp = new Dictionary<string, string>();
        temp.Add("name", yar[i].name);
        temp.Add("username", getUser.username);
        temp.Add("password", getUser.password);
        temp.Add("BuyerId", yar[i].BuyerId.ToString());
        temp.Add("CartID", yar[i].CartID.ToString());
        temp.Add("Address1", yar[i].Address1);
        temp.Add("Address2",yar[i].Address2);
        temp.Add("Address3",yar[i].Address3);
        yar2[i] = temp;
    }

    return Results.Ok(yar2);


}).WithTags("Buyers Endpoints");

app.MapGet("/get-Buyer-by-id/{BuyerId}", async (int BuyerId) =>
{
    Buyer BuyerToReturn = await BuyerRepository.GetBuyerByIdAsync(BuyerId);

    if (BuyerToReturn != null)
    {
        return Results.Ok(BuyerToReturn);

    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Buyers Endpoints");

app.MapPost("/create-Buyer", async (Buyer BuyerToCreate) =>
{
    bool createSuccess = await BuyerRepository.CreateBuyerAsync(BuyerToCreate);

    if (createSuccess != null)
    {
        return Results.Ok("Created Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Buyers Endpoints");

app.MapPut("/update-Buyer", async (Buyer BuyerToUpdate) =>
{
    bool updateSuccess = await BuyerRepository.UpdateBuyerAsync(BuyerToUpdate);

    if (updateSuccess != null)
    {
        return Results.Ok("Updated Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Buyers Endpoints");


app.MapDelete("/delete-Buyer-by-id/{BuyerId}", async (int BuyerId) =>
{
    bool deleteSuccess = await BuyerRepository.DeleteBuyerAsync(BuyerId);

    if (deleteSuccess != null)
    {
        return Results.Ok("Deleted Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Buyers Endpoints");



app.MapGet("/get-all-Sellers", async () =>
{
    List<Seller> yar = new List<Seller>(await SellerRepository.GetSellersAsync());
    Dictionary<string, string>[] yar2 = new Dictionary<string, string>[yar.Count];

    for (int i = 0; i < yar.Count; i++)
    {
        var getUser = await UserRepository.GetUserByIdAsync(yar[i].UserId);
        Dictionary<string, string> temp = new Dictionary<string, string>();
        temp.Add("name", yar[i].name);
        temp.Add("username", getUser.username);
        temp.Add("password", getUser.password);
        temp.Add("SellerId", yar[i].SellerId.ToString());
        temp.Add("Address", yar[i].Address);
        yar2[i] = temp;
    }

    return Results.Ok(yar2);

}).WithTags("Sellers Endpoints");

app.MapGet("/get-Seller-by-id/{SellerId}", async (int SellerId) =>
{
    Seller SellerToReturn = await SellerRepository.GetSellerByIdAsync(SellerId);

    if (SellerToReturn != null)
    {
        return Results.Ok(SellerToReturn);

    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Sellers Endpoints");

app.MapPost("/create-Seller", async (Seller SellerToCreate) =>
{
    bool createSuccess = await SellerRepository.CreateSellerAsync(SellerToCreate);

    if (createSuccess != null)
    {
        return Results.Ok("Created Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Sellers Endpoints");

app.MapPut("/update-Seller", async (Seller SellerToUpdate) =>
{
    bool updateSuccess = await SellerRepository.UpdateSellerAsync(SellerToUpdate);

    if (updateSuccess != null)
    {
        return Results.Ok("Updated Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Sellers Endpoints");


app.MapDelete("/delete-Seller-by-id/{SellerId}", async (int SellerId) =>
{
    bool deleteSuccess = await SellerRepository.DeleteSellerAsync(SellerId);

    if (deleteSuccess != null)
    {
        return Results.Ok("Deleted Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Sellers Endpoints");


app.MapPost("/create-Order", async (Order OrderToCreate) =>
{
    bool createSuccess = await OrderRepository.CreateOrderAsync(OrderToCreate);

    if (createSuccess != null)
    {
        return Results.Ok("Created Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Orders Endpoints");

app.MapPost("/buyer-log-in", async (Login userToLogin) =>
{
    string username = userToLogin.username;
    string password = userToLogin.password;
    User loginSuccess = await UserRepository.GetUserByUsernameAsync(username);
   
    if (loginSuccess != null && (password == loginSuccess.password) && (loginSuccess.userType ==1))
    {
        return Results.Ok("Login Successful");
    }
    else
    {
        return Results.Ok("Incorrect Details");
    }

}).WithTags("Login Endpoint");

app.MapPost("/seller-log-in", async (Login userToLogin) =>
{
    string username = userToLogin.username;
    string password = userToLogin.password;

    User loginSuccess = await UserRepository.GetUserByUsernameAsync(username);

    if (loginSuccess != null && (password == loginSuccess.password) && (loginSuccess.userType == 0))
    {
        return Results.Ok("Login Successful");
    }
    else
    {
        return Results.Ok("Incorrect Details");
    }

}).WithTags("Login Endpoint");
app.Run();