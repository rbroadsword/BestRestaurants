using Microsoft.AspNetCore.Mvc;

namespace BestRestaurant.Controllers
{
    public class CuisinesController : Controller
    {
      private readonly BestRestaurantContext _db;

      public CuisinesController(BestRestaurantContext db)
      {
        _db = db;
      }
      
      public ActionResult Index()
      {
        List<Cuisine> model = _db.Cuisine.ToList();
        return View(model);
      }

    }
}