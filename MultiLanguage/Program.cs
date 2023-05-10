using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using MultiLanguage.Helpers;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddLocalization( options => options.ResourcesPath = "Resources");

builder.Services.AddMvc()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

builder.Services.AddScoped<RequestLocalizationCookiesMiddleware>();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    //options.DefaultRequestCulture = new("tr-TR");

    CultureInfo[] cultures = new CultureInfo[]
    {
        new ("tr-TR"),
        new ("en-US")
    };
    options.SupportedCultures = cultures;
    options.SupportedUICultures = cultures;

});



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

app.UseRequestLocalization();
app.UseRequestLocalizationCookies();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
