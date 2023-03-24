using SamCrafts.Website.Models;
using SamCrafts.Website.Services;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// ** how to add services in Visual Studio 2022 [https://www.dofactory.com/code-examples/csharp/unable-to-resolve-service]
builder.Services.AddScoped<JsonFileProductsService>();


var app = builder.Build();


// var productService = app.Services.GetService<JsonFileProductsService>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages();
});
app.Run();
