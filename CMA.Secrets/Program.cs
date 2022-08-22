var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.AddUserSecrets<Program>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/secrets", () =>
{
    return string.Format("Hello Wordld! -> {0}", builder.Configuration["ConnectionStrings:localhost"]);
});


app.Run();