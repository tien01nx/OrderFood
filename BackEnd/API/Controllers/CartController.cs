using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CartController : BaseController<Cart>
    {
        public CartController(ApplicationDbContext context, ILogger<BaseController<Cart>> logger) : base(context, logger)
        {

        }

        // xóa userId và OrderId trong bảng cart
        [HttpDelete("DeleteCart")]
        public async Task<ApiResponse<Cart>> DeleteUserCart(Cart cart)
        {
            var exists = _context.Carts.Where(x => x.UserId == cart.UserId && x.OrderId == cart.OrderId).ToList();
            if (cart != null)
            {
                foreach (var item in exists)
                {
                    _context.Carts.Remove(item);
                }
                _context.SaveChanges();
                return new ApiResponse<Cart>(System.Net.HttpStatusCode.OK, "Xoa thanh cong", null);

            }
            return new ApiResponse<Cart>(System.Net.HttpStatusCode.NotFound, "", null);
        }

       

    }


}
