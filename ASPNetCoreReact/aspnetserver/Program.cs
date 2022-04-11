using aspnetserver.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy",
        builder =>
        {
            builder.AllowAnyMethod()
                   .AllowAnyHeader()
                   .WithOrigins("http://localhost:3000", "https://appname.azurestaticapps.net");
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

app.MapGet("/get-all-Carts", async () => await CartRepository.GetCartsAsync())
    .WithTags("Carts Endpoints");

app.MapGet("/get-Cart-by-id/{CartId}", async (int CartId) =>
{
    Cart CartToReturn = await CartRepository.GetCartByIdAsync(CartId);

    if (CartToReturn != null)
    {
        return Results.Ok(CartToReturn);

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

app.MapPut("/update-Cart", async (Cart CartToUpdate) =>
{
    bool updateSuccess = await CartRepository.UpdateCartAsync(CartToUpdate);

    if (updateSuccess != null)
    {
        return Results.Ok("Updated Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Carts Endpoints");


app.MapDelete("/delete-Cart-by-id/{CartId}", async (int CartId) =>
{
    bool deleteSuccess = await CartRepository.DeleteCartAsync(CartId);

    if (deleteSuccess != null)
    {
        return Results.Ok("Deleted Successfully");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Carts Endpoints");

app.Run();