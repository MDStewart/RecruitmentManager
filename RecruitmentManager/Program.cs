using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Components;
using RecruitmentManager.Data;
using RecruitmentManager.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddSqlite<HRMSContext>(builder.Configuration.GetConnectionString("DevelopmentConnection"));
builder.Services.AddScoped<HRMSService>();
builder.Services.AddScoped<MailService>();

//builder.Services.AddDbContext<RecruitmentManagerContext>(options =>
//{
//    options.UseSqlite(builder.Configuration.GetConnectionString("DevelopmentConnection"));
//    options.UseLazyLoadingProxies();
//}
//);
builder.Services.AddQuickGridEntityFrameworkAdapter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(RecruitmentManager.Client._Imports).Assembly);

app.Run();
