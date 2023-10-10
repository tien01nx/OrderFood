using API.DTO;
using API.Entities;
using AutoMapper;
using DataAccess.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using System.Net;

namespace API.Controllers
{

    public class ProductController : BaseController<Product>
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        private readonly ImageHelper _imageHelper;

        public ProductController(ApplicationDbContext context, ILogger<BaseController<Product>> logger, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper mapper) : base(context, logger)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
            _imageHelper = new ImageHelper(_webHostEnvironment);
        }

        [HttpGet("Restaurant/{restaurantId}")]
        
        public async Task<ApiResponse<List<Product>>> GetProductRestaurant(string restaurantId)
        {

            List<Product> products = _unitOfWork.Product.GetAll(u => u.RestaurantId.Equals(restaurantId)).ToList();

            return new ApiResponse<List<Product>>(System.Net.HttpStatusCode.OK, "Lấy dữ dữ liệu", products);

        }

        [HttpPost("UpLoadImage/{productId}")]
        public async Task<ApiResponse<Product>> UpLoadImage(string productId, IFormFile file)
        {
            try
            {

                var product = _unitOfWork.Product.Get(u => u.Id.Equals(productId));
                if (product == null)
                {
                    return new ApiResponse<Product>(HttpStatusCode.NotFound, $"Product {productId}", null);
                }
                string restaurantPath = @"images/product-" + product.Id;
                string imageUrl = _imageHelper.UploadImage(restaurantPath, file);

                if (!string.IsNullOrEmpty(imageUrl))
                {
                    product.Images = imageUrl;
                    _unitOfWork.Product.Update(product);
                    _unitOfWork.Save();
                    return new ApiResponse<Product>(HttpStatusCode.OK, "Thêm hình thành công", null);
                }


            }
            catch (Exception ex)
            {
                //_logger.LogError(ex.Message);
                return new ApiResponse<Product>(HttpStatusCode.BadRequest, ex.Message, null);
            }
            return new ApiResponse<Product>(HttpStatusCode.BadRequest, "Thêm hình thất bại", null);
        }

        //[HttpGet("User")]
        //public async Task<ApiResponse<List<User>>> GetUser()
        //{

        //    List<User> products = _unitOfWork.User.GetAll().ToList();


        //    return new ApiResponse<List<User>>(System.Net.HttpStatusCode.OK, "Lấy dữ dữ liệu", products);

        //}


    }
}