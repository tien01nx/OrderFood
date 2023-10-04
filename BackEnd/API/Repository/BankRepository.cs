using System.Linq.Expressions;
using API.Entities;
using DataAccess.Model;
using DataAccess.Repository.IRepository;


namespace DataAccess.Repository
{

    public class BankRepository : Repository<Bank>, IBankRepository
    {
        private ApplicationDbContext _db;

        public BankRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public bool ExistsBy(Expression<Func<Bank, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public void Update(Bank obj)
        {
            _db.Banks.Update(obj);
        }
    }
}