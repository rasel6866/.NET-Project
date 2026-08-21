using BLL.Services;
using DAL.EF;
using DAL.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DbBloodContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbBloodContext"));
});

builder.Services.AddScoped<UserRepo>();
builder.Services.AddScoped<DonorRepo>();
builder.Services.AddScoped<BloodStockRepo>();
builder.Services.AddScoped<BloodRequestRepo>();

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<DonorService>();
builder.Services.AddScoped<BloodStockService>();
builder.Services.AddScoped<BloodRequestService>();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
