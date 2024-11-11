using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

/*Course: 		Web Programming 3
* Assessment: 	Milestone 3
* Created by:   Kyle Fournier - 2276840
* Date: 		11/11/2024
* Class Name: 	HomeController.cs
* Description: 	used for the index page.
* Time Task B):	2 hours. 
*/

namespace HPlusSport.Security.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
