using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CategoryController : BaseController<Category>
    {
        public CategoryController(ApplicationDbContext context, ILogger<BaseController<Category>> logger) : base(context, logger)
        {
        }

       
    }
}
