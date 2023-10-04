
using API.Entities;
using DataAccess.Model;
using System.Linq.Expressions;

namespace DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);

        bool ExistsBy(Expression<Func<Category, bool>> filter);
    }
}