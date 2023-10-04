
using DataAccess.Model;
using System.Linq.Expressions;

namespace DataAccess.Repository.IRepository
{
    public interface IBankRepository : IRepository<Bank>
    {
        void Update(Bank obj);

        bool ExistsBy(Expression<Func<Bank, bool>> filter);
    }
}