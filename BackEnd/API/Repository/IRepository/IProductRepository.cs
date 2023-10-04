
using DataAccess.Model;
using System.Linq.Expressions;

namespace DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);

        bool ExistsBy(Expression<Func<Product, bool>> filter);
    }
}