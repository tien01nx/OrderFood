using API.Entities;
using DataAccess.Model;

namespace API.Controllers;
// [Authorize]
public class UsersController : BaseController<User>
{
    public UsersController(ApplicationDbContext context, ILogger<BaseController<User>> logger) : base(context, logger)
    {

    }



}