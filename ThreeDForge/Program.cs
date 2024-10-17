using Microsoft.EntityFrameworkCore;
using ThreeDForge.Application.Interfaces;
using ThreeDForge.Components;
using ThreeDForge.Infrastructure.Context;
using ThreeDForge.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContextFactory<ThreeDForgeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ThreeDForgeConnectionString"));
});
builder.Services.AddScoped<IStoreRepository, StoreRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
