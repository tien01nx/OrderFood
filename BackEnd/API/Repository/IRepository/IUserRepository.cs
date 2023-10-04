
using DataAccess.Model;
using System.Linq.Expressions;


namespace DataAccess.Repository.IRepository
{
    public interface IUserRepository : IRepository<User>
    {

        void Update(User obj);

        bool ExistsBy(Expression<Func<User, bool>> filter);

    }
}
