

using DataAccess.Model;

namespace DataAccess.Repository.IRepository
{
    public interface ITokenRepository
    {
        Task<string> CreateToken(User user);
    }
}