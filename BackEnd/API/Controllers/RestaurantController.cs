using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace API.Controllers
{
    public class RestaurantController : BaseController<Restaurant>
    {
        public RestaurantController(ApplicationDbContext context, ILogger<BaseController<Restaurant>> logger) : base(context, logger)
        {

        }

        // lấy ra tất cả các nhà hàng theo ngày hiện tại trong order cân truyền id ngày


        [HttpGet("GetAllRestaurant")]
        public async Task<ApiResponse<List<Order>>> GetRestaurant(string date)
        {
            try
            {
                DateTime selectedDate;

                if (DateTime.TryParseExact(date, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out selectedDate))
                {
                    var orders = await _context.Set<Order>()
                        .Where(u => u.CreateDate.Date == selectedDate.Date)
                        .Include(x => x.Restaurant)
                        .ToListAsync();

                    if (orders != null)
                    {
                        return new ApiResponse<List<Order>>(System.Net.HttpStatusCode.OK, "lay thanh cong", orders);
                    }

                    return new ApiResponse<List<Order>>(System.Net.HttpStatusCode.NoContent, "Khong co du lieu", null);
                }
                else
                {
                    return new ApiResponse<List<Order>>(System.Net.HttpStatusCode.BadRequest, "Ngày không hợp lệ", null);
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<Order>>(System.Net.HttpStatusCode.InternalServerError, ex.Message, null);
            }
        }

    }
}
