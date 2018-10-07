using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Demo.KeyVaultManagedIdentity.Application.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ViewBag.Secret = ConfigurationManager.AppSettings["Secret"];

            return View();
        }
    }
}