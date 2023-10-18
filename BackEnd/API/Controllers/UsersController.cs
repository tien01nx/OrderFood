using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
// [Authorize]
public class UsersController : BaseController<User>
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    private readonly ImageHelper _imageHelper;
    public UsersController(ApplicationDbContext context, ILogger<BaseController<User>> logger, IWebHostEnvironment webHostEnvironment) : base(context, logger)
    {
        _webHostEnvironment = webHostEnvironment;
        _imageHelper = new ImageHelper(_webHostEnvironment);
    }
    // lấy  tất cả dah sách user
    [HttpGet("GetListUsers")]
    public async Task<ApiResponse<List<User>>> GetUser(string search, string birthday)
    {
        try
        {
            IQueryable<User> query = _context.Users;

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(u =>
                    u.FullName.Contains(search) ||
                    u.PhoneNumber.Contains(search) ||
                    u.Email.Contains(search) ||
                    u.UserName.Contains(search) ||
                    u.Address.Contains(search) ||
                    u.ApartmentNumber.Contains(search));
            }

            if (!string.IsNullOrEmpty(birthday))
            {
                if (DateTime.TryParse(birthday, out DateTime parsedDate))
                {
                    query = query.Where(u => u.Birthday.HasValue && u.Birthday.Value.Date == parsedDate.Date);

                }
                else
                {
                    return new ApiResponse<List<User>>(System.Net.HttpStatusCode.BadRequest, "Ngày sinh không hợp lệ", null);
                }
            }

            var users = await query.ToListAsync();

            return new ApiResponse<List<User>>(System.Net.HttpStatusCode.OK, "Lấy danh sách thành công", users);
        }
        catch (Exception e)
        {
            return new ApiResponse<List<User>>(System.Net.HttpStatusCode.BadRequest, e.Message, null);
        }
    }


    [HttpPost("UpLoadImage/{userId}")]
    public async Task<ApiResponse<User>> UpLoadImage(int userId, IFormFile file)
    {
        try
        {

            var existsUser = _context.Users.Where(x => x.Id == userId).FirstOrDefault();

            if (existsUser == null)
            {
                return new ApiResponse<User>(System.Net.HttpStatusCode.NotFound, $"user {userId}", null);
            }
            string restaurantPath = @"images/user-" + userId;
            string imageUrl = _imageHelper.UploadImage(restaurantPath, file);

            if (!string.IsNullOrEmpty(imageUrl))
            {
                existsUser.Avatar = imageUrl;
                _context.Users.Update(existsUser);
                _context.SaveChanges();

                return new ApiResponse<User>(System.Net.HttpStatusCode.OK, "Thêm hình thành công", existsUser);
            }


        }
        catch (Exception ex)
        {
            //_logger.LogError(ex.Message);
            return new ApiResponse<User>(System.Net.HttpStatusCode.BadRequest, ex.Message, null);
        }
        return new ApiResponse<User>(System.Net.HttpStatusCode.BadRequest, "Thêm hình thất bại", null);
    }




}