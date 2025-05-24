using MBGestaoEscolar.Components;
using MBGestaoEscolar.Data.Context;
using MBGestaoEscolar.Repository.Implementation;
using MBGestaoEscolar.Repository.Interfaces;
using MBGestaoEscolar.Services.Implementations;
using MBGestaoEscolar.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
// String de conexão do SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registrar o DbContext com SQL Server
builder.Services.AddDbContext<SQLServerDBContext>(options =>
{
    options.UseSqlServer(connectionString);

    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging();
        options.LogTo(Console.WriteLine);
    }
});

// Registrar servicos de uso
builder.Services.AddScoped<IAlunoService, AlunoService>();

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
