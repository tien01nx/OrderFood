using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.DTO;
using API.Entities;
using AutoMapper;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.IRepository;

namespace API.Controllers
{

    public class ProductController : BaseController<Product>
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public ProductController(ApplicationDbContext context, ILogger<BaseController<Product>> logger, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper mapper) : base(context, logger)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }

        [HttpGet("Restaurant/{restaurantId}")]

        public async Task<ApiResponse<List<ProductDto>>> GetProductRestaurant(int restaurantId)
        {

            List<Product> products = _unitOfWork.Product.GetAll(u => u.RestaurantId == restaurantId, includeProperties: "Restaurant,ProductImages").ToList();

            // Sử dụng AutoMapper để map dữ liệu
            List<ProductDto> productDtos = _mapper.Map<List<ProductDto>>(products);

            return new ApiResponse<List<ProductDto>>(System.Net.HttpStatusCode.OK, "Lấy dữ dữ liệu", productDtos);

        }


        [HttpGet("User")]
        public async Task<ApiResponse<List<User>>> GetUser()
        {

            List<User> products = _unitOfWork.User.GetAll().ToList();

            
            return new ApiResponse<List<User>>(System.Net.HttpStatusCode.OK, "Lấy dữ dữ liệu", products);

        }



        //[HttpPost("Upsert")]
        //public async Task<ApiResponse<Product>> Upsert(Product product, List<IFormFile>? files)
        //{
        //    try
        //    {
        //        if (product.Id == 0)
        //        {
        //            _unitOfWork.Product.Add(product);
        //        }
        //        else
        //        {
        //            _unitOfWork.Product.Update(product);
        //        }


        //        _unitOfWork.Save();

        //        string wwwRootPath = _webHostEnvironment.WebRootPath;
        //        if (files != null)
        //        {
        //            foreach (IFormFile file in files)
        //            {
        //                string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        //                string productPath = @"images\products\product-" + product.Id;
        //                string finalPath = Path.Combine(wwwRootPath, productPath);
        //                if (!Directory.Exists(finalPath))
        //                {
        //                    Directory.CreateDirectory(finalPath);
        //                }

        //                using (var fileStream = new FileStream(Path.Combine(finalPath, filename), FileMode.Create))
        //                {
        //                    file.CopyTo(fileStream);
        //                }

        //                ProductImage productImageDto = new ProductImage()
        //                {
        //                    ImageUrl = @"\" + productPath + @"\" + filename,
        //                    ProductId = product.Id
        //                };

        //                if (product.ProductImages == null)
        //                {
        //                    product.ProductImages = new List<ProductImage>();
        //                }

        //                product.ProductImages.Add(productImageDto);
        //            }

        //            _unitOfWork.Product.Update(product);
        //            _unitOfWork.Save();
        //        }


        //        // TempData["success"] = "Product created/update successfully";
        //        return new ApiResponse<Product>(System.Net.HttpStatusCode.OK, "", product);

        //    }catch (Exception ex)
        //    {
        //        return new ApiResponse<Product>(System.Net.HttpStatusCode.OK, ex.ToString(), null);
        //    }



        //}


    }
}