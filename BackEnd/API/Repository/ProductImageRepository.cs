

using DataAccess.Repository.IRepository;

using System.Linq.Expressions;
using API.Entities;
using DataAccess.Model;

namespace DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext _db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public bool ExistsBy(Expression<Func<ProductImage, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
