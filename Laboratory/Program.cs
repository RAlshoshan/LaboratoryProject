using Laboratory.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// ****{ MultiLanguage }****

//builder.Services.AddSingleton<LocService>();
//builder.Services.AddLocalization(opt => { opt.ResourcesPath = "Resource"; });


//builder.Services.AddControllersWithViews().AddViewLocalization()
//    .AddDataAnnotationsLocalization(options =>
//    {
//        options.DataAnnotationLocalizerProvider = (type, factory) =>
//        {
//            var assemblyName = new AssemblyName(typeof(SharedResource).GetTypeInfo().Assembly.FullName); 
//            return factory.Create("a", assemblyName.Name);
//        };
//    });
//builder.Services.AddRazorPages();
//builder.Services.Configure<RequestLocalizationOptions>(
//    options =>
//    {
//        var supportedCultures = new List<CultureInfo>
//        {
//            new CultureInfo("en-US"),
//            new CultureInfo("ar-SA")
//        };
//        options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
//        options.SupportedCultures = supportedCultures;
//        options.SupportedUICultures = supportedCultures;

//        options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
//    });
//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromSeconds(5);
//    options.Cookie.HttpOnly = true;
//    options.Cookie.IsEssential = true;
//});


// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
var locOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(locOptions.Value);
app.UseStaticFiles();

app.UseRouting();
//app.UseCookiePolicy(); 

app.UseAuthentication();
app.UseAuthorization();
//app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
