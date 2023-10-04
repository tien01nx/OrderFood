using DataAccess.Repository.IRepository;
using System.Linq.Expressions;
using API.Entities;
using DataAccess.Model;

namespace DataAccess.Repository
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        private ApplicationDbContext _db;
        public RestaurantRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public bool ExistsBy(Expression<Func<Restaurant, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public void Update(Restaurant obj)
        {
            _db.Restaurants.Update(obj);
        }
    }
}
