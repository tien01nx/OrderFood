using DataAccess.Repository.IRepository;
using System.Linq.Expressions;
using API.Entities;
using DataAccess.Model;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public bool ExistsBy(Expression<Func<OrderDetail, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}