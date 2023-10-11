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

        // lấy danh sách categories và restaurant
        [HttpGet("GetAllCategory")]
        public async Task<ApiResponse<List<Category>>> GetCategory(string restaurantId){

            var categories  = _context.GetCategories(restaurantId).ToList();
            return new ApiResponse<List<Category>>(System.Net.HttpStatusCode.OK, "", categories);
        }
       
    }
}
