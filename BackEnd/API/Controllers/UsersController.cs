using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
// [Authorize]
public class UsersController : BaseController<User>
{
    public UsersController(ApplicationDbContext context, ILogger<BaseController<User>> logger) : base(context, logger)
    {

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





}