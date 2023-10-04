﻿using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T> : Controller where T : class
    {
        protected readonly ApplicationDbContext _context;
        private readonly ILogger<BaseController<T>> _logger;
        internal DbSet<T> dbSet;


        public BaseController(ApplicationDbContext context, ILogger<BaseController<T>> logger)
        {
            _context = context;
            _logger = logger;
            this.dbSet = _context.Set<T>();


        }
        [HttpGet("GetAll")]
        public async Task<ApiResponse<List<T>>> GetAll()
        {

            ApiResponse<List<T>> result;

            //var currentDate = DateTime.Now.Date;

            //// Truy vấn cho những người dùng có đơn hàng
            //var usersWithOrders = (
            //    from user in _context.Users
            //    join order in _context.Orders on user.Id equals order.UserId
            //    join orderDetail in _context.OrderDetails on order.Id equals orderDetail.OrderId
            //    where orderDetail.CreateDate.Date == currentDate
            //    join product in _context.Products on orderDetail.ProductId equals product.Id
            //    group new { orderDetail, product } by new { user.UserName, product.Title, product.Description } into g
            //    select new
            //    {
            //        UserName = g.Key.UserName,
            //        Title = g.Key.Title,
            //        Description = g.Key.Description,
            //        TotalQuantity = (int?)g.Sum(x => x.orderDetail.Count) ?? 0,
            //        TotalPrice = (decimal?)g.Sum(x => x.orderDetail.Count * x.product.Price) ?? 0m
            //    }).ToList();

            //// Truy vấn cho những người dùng không có đơn hàng
            //var usersWithoutOrders = (
            //    from user in _context.Users
            //    where !_context.Orders.Any(o => o.UserId == user.Id && _context.OrderDetails.Any(od => od.OrderId == o.Id && od.CreateDate.Date == currentDate))
            //    select new
            //    {
            //        UserName = user.UserName,
            //        Title = "",
            //        Description = "",
            //        TotalQuantity = 0, // Đã đổi sang int
            //        TotalPrice = 0m // Giả sử giá tiền là kiểu decimal
            //    }).ToList();

            //// Kết hợp hai danh sách
            //var combinedResults = usersWithOrders.Concat(usersWithoutOrders).ToList();
            try


            {
                var entities = await _context.Set<T>().ToListAsync();
                if (entities != null && entities.Count > 0)
                {
                    result = new ApiResponse<List<T>>(System.Net.HttpStatusCode.OK, "", entities);
                }
                else
                    result = new ApiResponse<List<T>>(System.Net.HttpStatusCode.NotFound, "", null);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
                //ghi log
                result = new ApiResponse<List<T>>(System.Net.HttpStatusCode.ExpectationFailed, "", null);
            }
            return result;
        }


        [HttpGet("{id}")]
        public async Task<ApiResponse<T>> GetById(int id)
        {
            try
            {

                var entity = await _context.Set<T>().FindAsync(id);
                if (entity != null)
                {
                    return new ApiResponse<T>(System.Net.HttpStatusCode.OK, "Lấy thành công", entity);
                }
                return new ApiResponse<T>(System.Net.HttpStatusCode.NoContent, "Không có trong hệ cơ sở dữ liệu", null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred in GetById method.");
                return new ApiResponse<T>(System.Net.HttpStatusCode.InternalServerError, "Lỗi khi truy xuất dữ liệu", null);
            }
        }


        [HttpPost("Create")]
        public async Task<ActionResult<ApiResponse<T>>> Create(T entity)
        {
            try
            {
                if (entity is BaseModel baseModel)
                {
                    baseModel.onCreate();
                }

                if (typeof(T) == typeof(Bank))
                {
                    var bankEntity = entity as Bank;
                    if (_context.Set<Bank>().Any(x => x.BankName == bankEntity.BankName))
                    {
                        return new ApiResponse<T>(HttpStatusCode.BadRequest, "BankName đã tồn tại", null);
                    }
                }

                if (typeof(T) == typeof(Order))
                {
                    var orderEntity = entity as Order;
                    // Assuming you have logic to add OrderDetails, you might perform it here.
                    // Make sure to properly set OrderId on each OrderDetail after saving Order entity.
                    _context.Set<Order>().Add(orderEntity);
                    await _context.SaveChangesAsync();

                    OrderDetail orderDetail = new OrderDetail()
                    {
                        OrderId = orderEntity.Id
                    };

                    _context.Set<OrderDetail>().Add(orderDetail);

                    await _context.SaveChangesAsync();

                    return new ApiResponse<T>(HttpStatusCode.OK, "Tạo thành công", entity);
                }

                _context.Set<T>().Add(entity);
                await _context.SaveChangesAsync();
                return new ApiResponse<T>(HttpStatusCode.OK, "Tạo thành công", entity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred in Create method.");
                return new ApiResponse<T>(HttpStatusCode.BadRequest, ex.Message, null);
            }
        }

        [HttpPost("CreateList")]
        public async Task<ActionResult<ApiResponse<List<T>>>> Create(List<T> entities)
        {
            try
            {
                _context.Set<T>().AddRange(entities);
                await _context.SaveChangesAsync();
                return new ApiResponse<List<T>>(HttpStatusCode.Created, "Tạo thành công", entities);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error occurred in Create method.");
                return new ApiResponse<List<T>>(HttpStatusCode.BadRequest, "Lỗi khi tạo" + ex, null);
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<T>>> Update(int id, T entity)
        {
            try
            {
                if (id <= 0)
                {
                    return new ApiResponse<T>(HttpStatusCode.BadRequest, "Id không hợp lệ", null);
                }

                var existingEntity = await _context.Set<T>().FindAsync(id);

                if (existingEntity == null)
                {
                    return new ApiResponse<T>(HttpStatusCode.NotFound, "Không tìm thấy đối tượng", null);
                }

                if (entity is Bank bankEntity)
                {

                    var existingBank = existingEntity as Bank;
                    // Kiểm tra xem BankName đã tồn tại trong bảng Bank (loại trừ bản ghi hiện tại)
                    if (_context.Set<Bank>().Any(x => x.Id != id && x.BankName == bankEntity.BankName))
                    {
                        return new ApiResponse<T>(HttpStatusCode.BadRequest, "BankName đã tồn tại", null);
                    }

                    existingBank.ImageUrl = bankEntity.ImageUrl;


                }

                _context.Entry(existingEntity).CurrentValues.SetValues(entity);


                await _context.SaveChangesAsync();
                return new ApiResponse<T>(HttpStatusCode.OK, "Cập nhật thành công", entity);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error occurred in Update method.");
                // Ghi log nếu cần
                return new ApiResponse<T>(HttpStatusCode.BadRequest, "Lỗi khi cập nhật", null);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<T>>> Delete(int id)
        {
            try
            {

                if (id <= 0)
                {
                    return new ApiResponse<T>(HttpStatusCode.BadRequest, "Id không hợp lệ", null);
                }

                var entity = await _context.Set<T>().FindAsync(id);
                if (entity == null)
                {
                    return new ApiResponse<T>(HttpStatusCode.NotFound, "Không tìm thấy đối tượng", null);
                }

                _context.Set<T>().Remove(entity);


                await _context.SaveChangesAsync();
                return new ApiResponse<T>(HttpStatusCode.OK, "Xóa thành công", entity);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error occurred in Delete method.");
                return new ApiResponse<T>(HttpStatusCode.BadRequest, "Lỗi khi xóa", null);
            }
        }

    }
}