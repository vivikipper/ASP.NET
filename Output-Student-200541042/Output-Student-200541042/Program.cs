using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Output_Student_200541042.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Output_Student_200541042Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Output_Student_200541042Context") ?? throw new InvalidOperationException("Connection string 'Output_Student_200541042Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
