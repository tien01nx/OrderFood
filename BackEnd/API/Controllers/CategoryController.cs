using API.DTO;
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
        public async Task<ApiResponse<List<CategoryDto>>> GetCategory(string restaurantName)
        {

            var categories = _context.GetCategories(restaurantName).ToList();
            return new ApiResponse<List<CategoryDto>>(System.Net.HttpStatusCode.OK, "", categories);
        }


        // categories trang danh sách


        [HttpGet("GetCategory")]
        public async Task<ApiResponse<List<CategoryDto>>> GetCategory(string categoryName, string restaurantId)
        {

            var categories = _context.GetCategories(categoryName, restaurantId).ToList();

            return new ApiResponse<List<CategoryDto>>(System.Net.HttpStatusCode.OK, "", categories);
        }




    }
}
