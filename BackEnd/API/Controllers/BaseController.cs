using API.Entities;
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
            try


            {

                // kiểm tra T có phải là order hay không
                // nếu phải thì lấy ra danh sách order theo ngày hiện tại


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
        public async Task<ApiResponse<T>> GetById(string id)
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

                // kiểm tra phải category hay không
                if (typeof(T) == typeof(Category))
                {

                    var existsCategory = entity as Category;
                    var category = _context.Set<Restaurant>().FirstOrDefault(x => x.Id.Equals(existsCategory.Id));
                    if (category != null)
                    {

                        _context.Entry(category).CurrentValues.SetValues(entity);
                        await _context.SaveChangesAsync();
                        return new ApiResponse<T>(HttpStatusCode.OK, "Cập nhật thành công", entity);
                    }
                }

                // kiểm tra T có phải là Restaurant không, nếu đúng ta thực hiện lấy id trong entity để tìm trong bảng Restaurant
                // nếu tồn tại thì update còn không tồn tại thì create
                if (typeof(T) == typeof(Restaurant))
                {

                    var restaurantEntity = entity as Restaurant;
                    var restaurant = _context.Set<Restaurant>().FirstOrDefault(x => x.Id.Equals(restaurantEntity.Id));
                    if (restaurant != null)
                    {

                        _context.Entry(restaurant).CurrentValues.SetValues(entity);
                        await _context.SaveChangesAsync();
                        return new ApiResponse<T>(HttpStatusCode.OK, "Cập nhật thành công", entity);
                    }
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


                if (typeof(T) == typeof(OrderDetail))
                {

                    // Tìm số tự động tăng cuối cùng bằng cách thực hiện truy vấn LINQ trên danh sách đã lấy
                    var lastOrderNumber = _context.Set<Order>()
                        .Where(o => o.Id.StartsWith("OD"))
                        .AsEnumerable() // Chuyển sang client evaluation
                        .Select(o => int.Parse(o.Id.Substring(2)))
                        .DefaultIfEmpty(0)
                        .Max();

                    string newOrderId = $"OD{(lastOrderNumber + 1).ToString("D4")}";

                    var orderDetail = entity as OrderDetail;
                    // kiểm tra Order theo ngày hiện tại đã có chưa, và theo điều kiện RestauranId
                    // nêu chưa có order và RestaurantId thì tạo mới order và orderDetail
                    var order = _context.Set<Order>().Where(x => x.CreateDate == DateTime.Now.Date && x.RestaurantId == orderDetail.RestaurantId).FirstOrDefault();
                    if (order == null)
                    {
                        Order newOrder = new Order()
                        {
                            RestaurantId = orderDetail.RestaurantId,
                            CreateDate = DateTime.Now.Date,
                            UserId = orderDetail.UserId,
                            OrderDate = DateTime.Now,
                            OrderTotal = 0,
                            OrderStatus = "Đang chờ xử lý",
                            PaymentStatus = "Chưa thanh toán",
                            Id = newOrderId
                        };
                        _context.Set<Order>().Add(newOrder);
                        await _context.SaveChangesAsync();
                        orderDetail.OrderId = newOrder.Id;
                        _context.Set<OrderDetail>().Add(orderDetail);
                        await _context.SaveChangesAsync();
                        return new ApiResponse<T>(HttpStatusCode.OK, "Tạo thành công", entity);
                    }
                    else
                    {
                        return new ApiResponse<T>(HttpStatusCode.OK, "Đã có", entity);
                    }

                }
                _context.Set<T>().Add(entity);
                await _context.SaveChangesAsync();
                return new ApiResponse<T>(HttpStatusCode.Created, "Tạo thành công", entity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred in Create method.");
                return new ApiResponse<T>(HttpStatusCode.BadRequest, ex.Message, null);
            }
        }

        //[HttpPost("CreateList")]
        //public async Task<ActionResult<ApiResponse<List<T>>>> Create(List<T> entities)
        //{
        //    try
        //    {
        //        _context.Set<T>().AddRange(entities);
        //        await _context.SaveChangesAsync();
        //        return new ApiResponse<List<T>>(HttpStatusCode.Created, "Tạo thành công", entities);
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        _logger.LogError(ex, "Error occurred in Create method.");
        //        return new ApiResponse<List<T>>(HttpStatusCode.BadRequest, "Lỗi khi tạo" + ex, null);
        //    }
        //}

        [HttpPost("CreateList")]
        public async Task<ActionResult<ApiResponse<List<T>>>> CreateList(List<T> entities)
        {
            try
            {
                if (typeof(T) == typeof(OrderDetail))
                {
                    var orderDetails = entities.Cast<OrderDetail>().ToList();
                    int lastNumber = 0;

                    foreach (var orderDetail in orderDetails)
                    {

                        // Kiểm tra xem có một đơn đặt hàng nào thỏa mãn điều kiện hay không
                        var order = _context.Set<Order>()
                            .FirstOrDefault(x => x.CreateDate == DateTime.Now.Date && x.RestaurantId == orderDetail.RestaurantId);

                        if (order == null)
                        {
                            // Nếu không có đơn đặt hàng nào, tạo đơn đặt hàng mới
                            order = new Order()
                            {
                                RestaurantId = orderDetail.RestaurantId,
                                CreateDate = DateTime.Now.Date,
                                UserId = orderDetail.UserId,
                                OrderDate = DateTime.Now,
                                OrderTotal = 0,
                                OrderStatus = "Đang chờ xử lý",
                                PaymentStatus = "Chưa thanh toán",
                                Id = GenerateId<Order>("OD")

                            };

                            _context.Set<Order>().Add(order);
                            await _context.SaveChangesAsync();
                        }

                        //var order = _context.Set<Order>()
                        //   .FirstOrDefault(x => x.CreateDate == DateTime.Now.Date && x.RestaurantId == orderDetail.RestaurantId);

                        var orderDetailExsts = _context.Set<OrderDetail>().Find(orderDetail.Id);

                        // cập nhật orderDetail đã có trong bảng OrderDetail
                        //if (orderDetailExsts != null)
                        //{
                        //    orderDetailExsts.Count += orderDetail.Count;
                        //    orderDetailExsts.Price += orderDetail.Price;
                        //    _context.Set<OrderDetail>().Update(orderDetailExsts);
                        //    await _context.SaveChangesAsync();
                        //    continue;
                        //}

                        if (lastNumber == 0)
                        {
                            var lastId = GenerateId<OrderDetail>("ODER");
                            lastNumber = int.Parse(new string(lastId.Where(char.IsDigit).ToArray()));
                        }
                        else
                        {
                            lastNumber++;
                        }
                        orderDetail.Id = "ODER" + lastNumber.ToString("D2");
                        orderDetail.OrderId = order.Id;

                        _context.Set<OrderDetail>().Add(orderDetail);

                    }
                }


                _context.Set<T>().AddRange(entities);
                await _context.SaveChangesAsync();

                return new ApiResponse<List<T>>(HttpStatusCode.OK, "Tạo thành công", entities);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error occurred in CreateList method.");
                return new ApiResponse<List<T>>(HttpStatusCode.BadRequest, "Lỗi khi tạo: " + ex.Message, null);
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
                    if (_context.Set<Bank>().Any(x => x.Id.Equals(bankEntity.Id) && x.BankName == bankEntity.BankName))
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
        public async Task<ActionResult<ApiResponse<T>>> Delete(string id)
        {
            try
            {

                if (id == null)
                {
                    return new ApiResponse<T>(HttpStatusCode.BadRequest, "Id không hợp lệ", null);
                }
                if (typeof(T) == typeof(OrderDetail))
                {
                    var orderDetailsToDelete = _context.Set<OrderDetail>()
                        .Where(od => od.UserId.Equals(id) && od.CreateDate.Date == DateTime.Now.Date)
                        .ToList();
                    if (orderDetailsToDelete.Count < 0)
                    {
                        return new ApiResponse<T>(HttpStatusCode.NotFound, "Không tìm thấy đối tượng", null);
                    }

                    _context.Set<OrderDetail>().RemoveRange(orderDetailsToDelete);
                    await _context.SaveChangesAsync();

                    return new ApiResponse<T>(HttpStatusCode.OK, "Xóa thành công", null);
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

        [HttpDelete("DeleteList")]
        public async Task<ActionResult<ApiResponse<List<T>>>> DeleteList(List<T> entities)
        {
            try
            {
                if (entities == null || entities.Count == 0)
                {
                    return new ApiResponse<List<T>>(HttpStatusCode.BadRequest, "Danh sách đối tượng để xóa không hợp lệ", null);
                }
                if (typeof(T) == typeof(OrderDetail))
                {

                    var orderDetails = entities.Cast<OrderDetail>().ToList();
                    // duyệt  danh sách orderDetail để xóa theo Id trong list entities
                    foreach (var item in orderDetails)
                    {
                        // tìm kiếm orderDetail theo Id trong bảng OrderDetail nếu ra giá trị thì xóa
                        var orderDetail = _context.Set<OrderDetail>().FirstOrDefault(x => x.Id.Equals(item.Id));
                        if (orderDetail != null)
                            _context.Set<OrderDetail>().Remove(orderDetail);
                    }

                }

                _context.Set<T>().RemoveRange(entities);

                await _context.SaveChangesAsync();
                return new ApiResponse<List<T>>(HttpStatusCode.OK, "Xóa danh sách thành công", entities);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error occurred in DeleteList method.");
                return new ApiResponse<List<T>>(HttpStatusCode.BadRequest, "Lỗi khi xóa danh sách", null);
            }
        }




        private string GenerateId<T>(string prefix) where T : class
        {
            var lastId = _context.Set<T>().OrderByDescending(e => EF.Property<string>(e, "Id"))
                          .Where(t => EF.Property<string>(t, "Id").StartsWith(prefix.ToUpper()))
                          .Select(t => EF.Property<string>(t, "Id"))
                          .FirstOrDefault();

            if (lastId == null)
            {
                return prefix.ToLower() + "01";
            }

            // Tách và lấy chỉ phần số nguyên
            var numberString = new string(lastId.Where(char.IsDigit).ToArray());

            int numberPart;
            if (!int.TryParse(numberString, out numberPart))
            {
                throw new InvalidOperationException("Failed to parse the numeric part of the ID.");
            }

            numberPart++;

            return prefix.ToLower() + numberPart.ToString("D2"); // Định dạng số với ít nhất 2 chữ số
        }





    }
}