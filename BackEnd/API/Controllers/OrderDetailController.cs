using API.Entities;
using DataAccess.Model;

namespace API.Controllers
{
    public class OrderDetailController : BaseController<OrderDetail>
    {
        public OrderDetailController(ApplicationDbContext context, ILogger<BaseController<OrderDetail>> logger) : base(context, logger)
        {

        }


    }
}