

using DataAcess.Connection;
using DataAcess.Contexts;
using DataAcess.Repository;
using Domain.Interfaces.Database;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
var connectionString = configuration.GetConnectionString("DefaultConnection");


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
builder.Services.AddScoped<IApplicationReadFromDb, ApplicationReadDbConnection>();
builder.Services.AddScoped<IApplicationWriteToDb, ApplicationWriteDbConnection>();
builder.Services.AddScoped<IDutyRepository, DutyRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddRazorPages().AddNToastNotifyNoty(new NotyOptions
{
    ProgressBar = true,
    Timeout = 5000
});
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

app.UseAuthorization();

app.UseNToastNotify();

app.MapRazorPages();

app.Run();
