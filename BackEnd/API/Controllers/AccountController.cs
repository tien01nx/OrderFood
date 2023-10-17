using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.DTO;
using API.Entities;
using AutoMapper;
using DataAccess.Model;
using DataAccess.Repository.IRepository;
using DataAccess.Utilis;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITokenRepository _tokenRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public AccountController(ApplicationDbContext context, ITokenRepository tokenRepository, UserManager<User> userManager, IMapper mapper)
        {
            _context = context;
            _tokenRepository = tokenRepository;
            _userManager = userManager;
            _mapper = mapper;
             
        }



        [HttpPost("register")]

        public async Task<ApiResponse<User>> Register(RegisterDto registerDto)
        {
            User user = new User
            {
                UserName = registerDto.UserName,
                FullName = registerDto.FullName,
            };


            user.UserName = registerDto.UserName.ToLower();


            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded) return new ApiResponse<User>(System.Net.HttpStatusCode.NoContent, "Username tồn tại", null);

            var roleResult = await _userManager.AddToRoleAsync(user, SD.Role_User);

            if (!roleResult.Succeeded) return new ApiResponse<User>(System.Net.HttpStatusCode.NoContent, "Bạn không có quyền", null);

            return new ApiResponse<User>(System.Net.HttpStatusCode.OK, "đăng ký thành công", null);

        }

        [HttpPost("login")]
        public async Task<ApiResponse<Login>> Login(LoginDto loginDto)
        {
            var user = await _userManager.Users
                  
                      .SingleOrDefaultAsync(x => x.UserName == loginDto.UserName);

            if (user == null) return new ApiResponse<Login>(System.Net.HttpStatusCode.Unauthorized, "Invalid username", null);

            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);

            if (!result) return new ApiResponse<Login>(System.Net.HttpStatusCode.Unauthorized, "Invalid Password", null);

            Login login = new Login()
            {
                user = user,
                Token = await _tokenRepository.CreateToken(user),
                expiresIn = DateTime.Now.AddDays(7).ToString()
            };
            return new ApiResponse<Login>(System.Net.HttpStatusCode.OK, "login successfully", login);

        }

        private async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username.ToLower());
        }

    }
}