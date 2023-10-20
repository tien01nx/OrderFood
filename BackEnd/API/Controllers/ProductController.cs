using API.DTO;
using API.Entities;
using AutoMapper;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using System.Net;
using System.Reflection;
using System.Text;

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

        // lấy danh sách product
        [HttpGet("GetListProduct")]
        public async Task<ApiResponse<List<ProductDto>>> GetListProduct(string restaurantName, string categoryName, string productName)
        {
            try
            {

                List<ProductDto> products = _context.GetProducts(restaurantName, categoryName, productName);

                return new ApiResponse<List<ProductDto>>(System.Net.HttpStatusCode.OK, "Lấy dữ dữ liệu", products);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex.Message);
                return new ApiResponse<List<ProductDto>>(HttpStatusCode.BadRequest, ex.Message, null);
            }

        }

        [HttpGet("FileExecel")]
        public IActionResult ExportToCSV()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Id,RestaurantID,CategoryID,ProductName,Description,Price,Images,CreateBy,UpdateBy,CreateDate,UpdateDate");
            foreach (var product in _unitOfWork.Product.GetAll())
            {
                builder.AppendLine($"{product.Id},{product.RestaurantId},{product.CategoryId},\"{product.ProductName}\",\"{product.Description}\",{product.Price},{product.Images},{product.CreateBy},{product.UpdateBy},{product.CreateDate},{product.UpdateDate}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "Product.csv");

        }

        // xuất  dữ liệu User ra file excel



        public IActionResult ExportToCSV<T>(IEnumerable<T> data, string filename)
        {
            var builder = new StringBuilder();

            // Lọc ra thuộc tính không được đánh dấu bằng ExcludeFromCSV
            var properties = typeof(T).GetProperties()
                .Where(p => p.GetCustomAttribute<ExcludeFromCSVAttribute>() == null
                        && !p.PropertyType.Namespace.StartsWith("System.Collections")
                        && p.PropertyType.Name != "ICollection`1");

            // Tạo tên cột
            var header = string.Join(',', properties.Select(p => $"\"{p.Name}\""));
            builder.AppendLine(header);

            
            foreach (var item in data)
            {
                var values = properties.Select(p =>
                {
                    var value = p.GetValue(item);
                    return $"\"{value?.ToString().Replace("\"", "\"\"")}\"";
                });
                builder.AppendLine(string.Join(',', values));
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", filename);
        }

        
        [HttpGet("ExportProducts")]
        public IActionResult GetProductsCSV()
        {
            var data = _unitOfWork.Product.GetAll().ToList();
            return ExportToCSV(data, "Product.csv");
        }

        [HttpGet("ExportUsers")]
        public IActionResult GetUsersVSC()
        {
            var data = _unitOfWork.User.GetAll().ToList();
            return ExportToCSV(data, "User.csv");
        }   

    }
}