using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RestaurantController : BaseController<Restaurant>
    {
        public RestaurantController(ApplicationDbContext context, ILogger<BaseController<Restaurant>> logger) : base(context, logger)
        {

        }
    }
}
