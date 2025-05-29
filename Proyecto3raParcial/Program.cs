using Microsoft.EntityFrameworkCore;
using Proyecto3raParcial.Components;
using Proyecto3raParcial.Components.Data;
using Proyecto3raParcial.Components.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddDbContext<DBDbContext>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("BDDirectorioDBContext")
        ));


builder.Services.AddScoped<IFrutaRepo, FrutaRepo>();
builder.Services.AddScoped<IClienteRepo, ClienteRepo>();
builder.Services.AddScoped<IEnvioRepo, EnvioRepo>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();

}
app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();