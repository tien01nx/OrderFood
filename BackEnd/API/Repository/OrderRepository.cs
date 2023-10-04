using DataAccess.Repository.IRepository;
using System.Linq.Expressions;
using API.Entities;
using DataAccess.Model;

namespace DataAccess.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private ApplicationDbContext _db;

        public OrderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public bool ExistsBy(Expression<Func<Order, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public void Update(Order obj)
        {
            _db.Orders.Update(obj);
        }
    }
}