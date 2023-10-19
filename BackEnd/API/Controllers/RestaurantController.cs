using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System.Globalization;
using System.Net;

namespace API.Controllers
{
    public class RestaurantController : BaseController<Restaurant>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly ImageHelper _imageHelper;
        public RestaurantController(ApplicationDbContext context, ILogger<BaseController<Restaurant>> logger, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment) : base(context, logger)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _imageHelper = new ImageHelper(_webHostEnvironment);
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
                        .Include(x => x.Restaurant).OrderByDescending(o=>o.Restaurant.FavoriteLevel)
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

        // Lấy thông tin nhà hàng theo từ khóa
        [HttpGet("GetRestaurantByKeyword")]
        public async Task<ApiResponse<List<Restaurant>>> GetRestaurant(string restaurant, string favoriteLevel, string time)
        {
            try
            {
                var restaurants = _context.GetRestaurant(restaurant, favoriteLevel, time).ToList();

                return new ApiResponse<List<Restaurant>>(System.Net.HttpStatusCode.OK, "lay thanh cong", restaurants);

            }
            catch (Exception ex)
            {
                return new ApiResponse<List<Restaurant>>(System.Net.HttpStatusCode.InternalServerError, ex.Message, null);
            }

        }



        [HttpPost("UpLoadImage/{restaurantId}")]
        public async Task<ApiResponse<Restaurant>> UpLoadImage(string restaurantId, IFormFile file)
        {
            try


            {
                var restaurant = _unitOfWork.Restaurant.Get(u => u.Id.Equals(restaurantId));
                if (restaurant == null)
                {
                    return new ApiResponse<Restaurant>(HttpStatusCode.NotFound, $"restaurantID {restaurantId}", null);
                }


                string restaurantPath = @"images/restaurants/restaurant-" + restaurant.Id;
                string imageUrl = _imageHelper.UploadImage(restaurantPath, file);

                if (!string.IsNullOrEmpty(imageUrl))
                {
                    restaurant.ImageUrl = imageUrl;
                    _unitOfWork.Restaurant.Update(restaurant);
                    _unitOfWork.Save();
                    return new ApiResponse<Restaurant>(HttpStatusCode.OK, "Thêm hình thành công", restaurant);
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex.Message);
                return new ApiResponse<Restaurant>(HttpStatusCode.BadRequest, ex.Message, null);
            }
            return new ApiResponse<Restaurant>(HttpStatusCode.BadRequest, "Thêm hình thất bại", null);
        }

        // thực hiện xóa hình ảnh theo restaurantId
        [HttpDelete("DeleteImage/{restaurantId}")]
        public async Task<ApiResponse<Restaurant>> DeleteImage(string restaurantId)
        {
            try
            {
                var restaurant = _unitOfWork.Restaurant.Get(u => u.Id.Equals(restaurantId));
                if (restaurant == null)
                {
                    return new ApiResponse<Restaurant>(HttpStatusCode.NotFound, $"restaurantID {restaurantId}", null);
                }

                string restaurantPath = @"images/restaurants/restaurant-" + restaurant.Id;
                _imageHelper.DeleteImage(restaurantPath);

                restaurant.ImageUrl = null;
                _unitOfWork.Restaurant.Update(restaurant);
                _unitOfWork.Save();
                return new ApiResponse<Restaurant>(HttpStatusCode.OK, "Xóa hình thành công", restaurant);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex.Message);
                return new ApiResponse<Restaurant>(HttpStatusCode.BadRequest, ex.Message, null);
            }

        }

        // xóa restaurant theo id và xóa hình ảnh theo restaurantId
        [HttpDelete("DeleteRestaurant/{restaurantId}")]
        public async Task<ApiResponse<Restaurant>> DeleteRestaurant(string restaurantId)
        {
            try
            {
                var restaurant = _unitOfWork.Restaurant.Get(u => u.Id.Equals(restaurantId));
                if (restaurant == null)
                {
                    return new ApiResponse<Restaurant>(HttpStatusCode.NotFound, $"restaurantID {restaurantId}", null);
                }

                string restaurantPath = @"images/restaurants/restaurant-" + restaurant.Id;
                _imageHelper.DeleteImage(restaurantPath);

                _unitOfWork.Restaurant.Remove (restaurant);
                _unitOfWork.Save();
                return new ApiResponse<Restaurant>(HttpStatusCode.OK, "Xóa nhà hàng thành công", restaurant);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex.Message);
                return new ApiResponse<Restaurant>(HttpStatusCode.BadRequest, ex.Message, null);
            }

        }
    }

}
