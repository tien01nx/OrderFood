//using API.Entities;
//using Microsoft.AspNetCore.Mvc;
//using Repository.IRepository;
//using System.Net;

//namespace API.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ProductImageController : Controller
//    {

//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IWebHostEnvironment _webHostEnvironment;
//        private readonly ILogger<ProductImageController> _logger;

//        public ProductImageController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, ILogger<ProductImageController> logger)
//        {
//            _unitOfWork = unitOfWork;
//            _webHostEnvironment = webHostEnvironment;
//            _logger = logger;
//        }



//        [HttpPost("UpLoadImage/{productId}")]
//        public async Task<ApiResponse<ProductImage>> UpLoadImage(int productId, List<IFormFile> files)
//        {
//            try
//            {

//                var product = _unitOfWork.Product.Get(u => u.Id == productId);
//                if (product == null)
//                {
//                    return new ApiResponse<ProductImage>(HttpStatusCode.NotFound, $"Product {productId}", null);
//                }

//                string wwwRootPath = _webHostEnvironment.WebRootPath;

//                if (files != null)
//                {
//                    foreach (IFormFile file in files)
//                    {
//                        string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
//                        string productPath = @"images\products\product-" + product.Id;
//                        string finalPath = Path.Combine(wwwRootPath, productPath);
//                        if (!Directory.Exists(finalPath))
//                        {
//                            Directory.CreateDirectory(finalPath);
//                        }

//                        using (var fileStream = new FileStream(Path.Combine(finalPath, filename), FileMode.Create))
//                        {
//                            file.CopyTo(fileStream);
//                        }

//                        ProductImage productImageDto = new ProductImage()
//                        {
//                            ImageUrl = @"\" + productPath + @"\" + filename,
//                            ProductId = product.Id
//                        };

//                        if (product.ProductImages == null)
//                        {
//                            product.ProductImages = new List<ProductImage>();
//                        }

//                        product.ProductImages.Add(productImageDto);
//                    }

//                    _unitOfWork.Product.Update(product);
//                    _unitOfWork.Save();
//                    return new ApiResponse<ProductImage>(HttpStatusCode.OK, "Thêm hình thành công", null);
//                }
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex.Message);
//                return new ApiResponse<ProductImage>(HttpStatusCode.BadRequest, ex.Message, null);
//            }
//            return new ApiResponse<ProductImage>(HttpStatusCode.BadRequest, "Thêm hình thất bại", null);
//        }

//        [HttpGet("GetProductImage/{productId}")]

//        public async Task<ApiResponse<List<ProductImage>>> GetProductImage(int productId)
//        {
//            try
//            {
//                List<ProductImage> Image = _unitOfWork.ProductImage.GetAll(u => u.ProductId == productId).ToList();
//                return new ApiResponse<List<ProductImage>>(HttpStatusCode.OK, "", Image);

//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex.Message);
//                return new ApiResponse<List<ProductImage>>(HttpStatusCode.BadRequest, ex.Message, null);
//            }
//        }
//        [HttpDelete("/{productId}")]
//        public async Task<ApiResponse<ProductImage>> Delete(int? productId)
//        {
//            try
//            {
//                var productToBeDeleted = _unitOfWork.Product.Get(u => u.Id == productId);
//                if (productToBeDeleted == null)
//                {
//                    return new ApiResponse<ProductImage>(HttpStatusCode.NoContent, "ProductId khong ton tai", null);
//                }

//                string productPath = @"images\products\product-" + productId;
//                string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, productPath);

//                if (Directory.Exists(finalPath))
//                {
//                    string[] filePaths = Directory.GetFiles(finalPath);
//                    foreach (string filePath in filePaths)
//                    {
//                        System.IO.File.Delete(filePath);
//                    }

//                    Directory.Delete(finalPath);
//                }


//                _unitOfWork.Product.Remove(productToBeDeleted);
//                _unitOfWork.Save();

//                return new ApiResponse<ProductImage>(HttpStatusCode.OK, "Xoa thanh cong", null);

//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex.Message);
//                return new ApiResponse<ProductImage>(HttpStatusCode.BadRequest, "Lỗi khi xóa", null);
//            }

//        }

//        [HttpDelete("DeleteImage/{imageId}")]
//        public async Task<ApiResponse<ProductImage>> DeleteImage(int imageId)
//        {
//            try
//            {
//                var imageToBeDeleted = _unitOfWork.ProductImage.Get(u => u.Id == imageId);
//                int productId = imageToBeDeleted.ProductId;
//                if (imageToBeDeleted != null)
//                {
//                    if (!string.IsNullOrEmpty(imageToBeDeleted.ImageUrl))
//                    {
//                        var oldImageUrl = Path.Combine(_webHostEnvironment.WebRootPath,
//                            imageToBeDeleted.ImageUrl.TrimStart('\\'));
//                        if (System.IO.File.Exists(oldImageUrl))
//                        {
//                            System.IO.File.Delete(oldImageUrl);
//                        }
//                    }

//                    _unitOfWork.ProductImage.Remove(imageToBeDeleted);
//                    _unitOfWork.Save();
//                    return new ApiResponse<ProductImage>(HttpStatusCode.OK, "Xóa ảnh thành công", null);

//                }
//                return new ApiResponse<ProductImage>(HttpStatusCode.NoContent, "ImageId khong ton tai", null);



//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex.Message);
//                return new ApiResponse<ProductImage>(HttpStatusCode.OK, "Xóa ảnh thành công", null);
//            }


//        }

//    }
//}
