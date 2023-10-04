
using DataAccess.Model;
using System.Linq.Expressions;


namespace DataAccess.Repository.IRepository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);

        bool ExistsBy(Expression<Func<OrderDetail, bool>> filter);
    }
}