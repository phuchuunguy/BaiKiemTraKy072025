using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VicemMVCIdentity.Models;

namespace VicemMVCIdentity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
// sinh mã tự động controller: 
// dotnet aspnet-codegenerator controller -name EmployeeController -m NhanVien -dc VicemMVC.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

// sinh mã login,..
// dotnet aspnet-codegenerator identity -dc VicemMVC.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout" -f

// sinh mã các chức năng sau login,..
// dotnet aspnet-codegenerator identity -dc VicemMVC.Data.ApplicationDbContext -f

