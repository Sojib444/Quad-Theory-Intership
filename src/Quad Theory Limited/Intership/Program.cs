using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Internship.Infrastructure.Context;
using Internship.Infrastructure.Muodule;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//connectionString
var connectionString = builder.Configuration.GetConnectionString("ConnectionString");

//AsseblyName
var assemblyName = Assembly.GetExecutingAssembly().FullName;

//Autofac Configuration
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
	containerBuilder.RegisterModule(new InfrastructureModule(connectionString, assemblyName));
});

//Set DBContext
builder.Services.AddDbContext<ApplicationDbContext>(option => 
option.UseSqlServer(connectionString, e => e.MigrationsAssembly(assemblyName)));

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
