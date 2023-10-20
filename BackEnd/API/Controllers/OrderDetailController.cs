using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using System.Net;

namespace API.Controllers
{
    public class OrderDetailController : BaseController<OrderDetail>
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderDetailController(ApplicationDbContext context, ILogger<BaseController<OrderDetail>> logger, IUnitOfWork unitOfWork) : base(context, logger)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpPost("CREATE/LIST")]
        public async Task<ApiResponse<List<OrderDetail>>> CreateOrderDetails(List<OrderDetail> orderDetails)
        {
            ApiResponse<List<OrderDetail>> result;
            // kiểm tra xem Order theo ngày hiện tai đã có chưa nếu chưa có thì tạo mới


            int lastNumber = 0;

            foreach (var orderdetail in orderDetails)
            {

                // Kiểm tra xem có một đơn đặt hàng nào thỏa mãn điều kiện hay không
                //var order = _context.Set<Order>()
                //    .FirstOrDefault(x => x.CreateDate == DateTime.Now.Date && x.RestaurantId == orderDetail.RestaurantId);
                var order = _unitOfWork.Order.Get(u => u.CreateDate == DateTime.Now.Date && u.RestaurantId == orderdetail.RestaurantId);

                // order = null thì chưa có thì thục hiện tạo mới một order và thêm orderdetail vào

                if (order == null)
                {
                    // Nếu không có đơn đặt hàng nào, tạo đơn đặt hàng mới
                    order = new Order()
                    {
                        RestaurantId = orderdetail.RestaurantId,
                        CreateDate = DateTime.Now.Date,
                        UserId = orderdetail.UserId,
                        OrderDate = DateTime.Now,
                        OrderTotal = 0,
                        OrderStatus = "Đang chờ xử lý",
                        PaymentStatus = "Chưa thanh toán",
                        Id = GenerateId<Order>("OD")

                    };
                    _unitOfWork.Order.Add(order);
                    _unitOfWork.Save();
                }
                if (orderdetail.Count == 0)
                {
                    _unitOfWork.OrderDetail.Remove(orderdetail);
                }
                else
                {
                    // tạo ID
                    if (lastNumber == 0)
                    {
                        var lastId = GenerateId<OrderDetail>("ODER");
                        lastNumber = int.Parse(new string(lastId.Where(char.IsDigit).ToArray()));
                    }
                    else
                    {
                        lastNumber++;
                    }
                    if (orderdetail.Id.Equals("0"))
                    {
                        orderdetail.Id = "ODER" + lastNumber.ToString("D2");
                        orderdetail.OrderId = order.Id;

                        _unitOfWork.OrderDetail.Add(orderdetail);
                        _unitOfWork.Save();
                    }

                    // thực hiện cập nhật or thêm mới orderdetail
                    else
                    {
                        var exist = _unitOfWork.OrderDetail.Get(u => u.Id.Equals(orderdetail.Id));
                        if (exist != null)
                        {
                            _unitOfWork.OrderDetail.Update(orderdetail);
                            _unitOfWork.Save();

                        }
                        else
                        {
                            _unitOfWork.OrderDetail.Add(orderdetail);
                            _unitOfWork.Save();

                        }
                    }

                }
              
            }




            return result = new ApiResponse<List<OrderDetail>>(System.Net.HttpStatusCode.OK, "", null);
        }
    }

}