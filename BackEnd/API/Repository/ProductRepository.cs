using DataAccess.Repository.IRepository;
using System.Linq.Expressions;
using API.Entities;
using DataAccess.Model;

namespace DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public bool ExistsBy(Expression<Func<Product, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
