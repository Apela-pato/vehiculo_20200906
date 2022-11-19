using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using vehiculo_20200906.Data;
using vehiculo_20200906.Data.Context;
using vehiculo_20200906.Data.services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSqlite<vehiculo_20200906>("Data Source=.//Data//Context//localDB.sqlite");
builder.Services.AddScoped<Ivehiculo_20200906,vehiculo_20200906>();
builder.Services.AddScoped<Ivehiculo_20200906,vehiculo_20200906>();
builder.Services.AddSingleton<WeatherForecastService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
