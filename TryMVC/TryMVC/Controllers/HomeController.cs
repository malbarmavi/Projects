using System.Web.Mvc;
using TryMVC.Models;
namespace TryMVC.Controllers
{
  public class HomeController : Controller
  {

    public ActionResult Index()
    {
      return View(EquipmentStorage.GetAll());
    }
    [HttpPost]
    public ActionResult Create(string equipment)
    {
      EquipmentStorage.AddEquipment(equipment);
      return RedirectToAction("Index");

    }
  }
}