using TestAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddScoped<IRandomNumberService, RandomNumberService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

// Define the endpoint
app.MapGet("/random", (IRandomNumberService randomNumberService) =>
{
    var randomNumber = randomNumberService.GetRandomNumber();
    return Results.Ok(new { Value = randomNumber });
})
.WithName("GetRandomNumber");

app.Run();