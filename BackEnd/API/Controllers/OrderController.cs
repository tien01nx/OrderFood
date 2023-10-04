using API.DTO;
using API.Entities;
using AutoMapper;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;

namespace API.Controllers
{
    public class OrderController : BaseController<Order>
    {
        private readonly IUnitOfWork _unitOfWork;


        private readonly IMapper _mapper;
        public OrderController(ApplicationDbContext context, ILogger<BaseController<Order>> logger, IUnitOfWork unitOfWork, IMapper mapper) : base(context, logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("GetAllRestaurant")]
        public async Task<ApiResponse<List<OrderDto>>> GetAll()
        {

            try
            {
                //var order = _unitOfWork.Order.GetAll(includeProperties: "Restaurant").ToList();
                var orders = _unitOfWork.Order.GetAll(includeProperties: "Restaurant").ToList();
                var orderDtos = _mapper.Map<List<OrderDto>>(orders);
                if (orderDtos != null)
                {
                    return new ApiResponse<List<OrderDto>>(System.Net.HttpStatusCode.OK, "lay thanh cong", orderDtos);
                }
                return new ApiResponse<List<OrderDto>>(System.Net.HttpStatusCode.NoContent, "Khong co du lieu", null);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<OrderDto>>(System.Net.HttpStatusCode.NoContent, ex.Message, null);

            }



        }
        [HttpGet("UserAllOrders")]
        public async Task<ApiResponse<List<UserInfoDTO>>> UserAllOrders(string date,string UserName,string Title)
        {

            var details = _context.GetUserCartDetails(date, UserName, Title).ToList();

            return new ApiResponse<List<UserInfoDTO>>(System.Net.HttpStatusCode.OK, "", details);

        }

        [HttpGet("UserOrders")]
        public async Task<ApiResponse<List<UserInfoDTO>>> UserOrders(string userId,string date)
        {

            var details = _context.GetUserCartDetailsByDateAndUserId(userId,date).ToList();

            return new ApiResponse<List<UserInfoDTO>>(System.Net.HttpStatusCode.OK, "", details);

        }


    }
}
