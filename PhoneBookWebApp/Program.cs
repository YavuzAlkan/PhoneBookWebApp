using DataAccess.Context;
using DataAccess.DAL.Concrete;
using DataAccess.DAL.Interfaces;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PhoneBookAppDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});
builder.Services.AddIdentity<User, IdentityRole>()
        .AddEntityFrameworkStores<PhoneBookAppDbContext>()
        .AddDefaultTokenProviders();

builder.Services.AddScoped<IContactDAL, ContactDAL>();
builder.Services.AddScoped<IContactCrudDAL, ContactCrudDAL>();
builder.Services.AddScoped<ILoginDAL, LoginDAL>();
builder.Services.AddScoped<IRegisterDAL, RegisterDAL>();


var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<PhoneBookAppDbContext>().Database.Migrate();
}

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=LogIn}/{id?}");

app.Run();
