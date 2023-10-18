namespace API.Entities
{
    public class ImageHelper
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ImageHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string UploadImage(string relativePath, IFormFile file)
        {
            try
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (file != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string finalPath = Path.Combine(wwwRootPath, relativePath);
                    if (!Directory.Exists(finalPath))
                    {
                        Directory.CreateDirectory(finalPath);
                    }

                    using (var fileStream = new FileStream(Path.Combine(finalPath, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    return @"/" + relativePath + @"/" + filename;
                }

                return null;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                throw ex;
            }
        }

        public bool DeleteImage(string imagePath)
        {
            try
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string fullPath = Path.Combine(wwwRootPath, imagePath);

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
