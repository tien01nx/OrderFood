
using API.Entities;
using DataAccess.Model;


namespace API.Controllers
{

    public class BankController : BaseController<Bank>
    {
    

        public BankController(ApplicationDbContext context, ILogger<BaseController<Bank>> logger) : base(context, logger)
        {

        }


    }
}