using API.Entities;
using DataAccess.Model;

namespace API.Controllers
{
    public class CartController : BaseController<Cart>
    {
        public CartController(ApplicationDbContext context, ILogger<BaseController<Cart>> logger) : base(context, logger)
        {

        }
    }
}
