
using DataAccess.Model;
using System.Linq.Expressions;


namespace DataAccess.Repository.IRepository
{
    public interface IProductImageRepository : IRepository<ProductImage>
    {
        void Update(ProductImage obj);

        bool ExistsBy(Expression<Func<ProductImage, bool>> filter);
    }
}