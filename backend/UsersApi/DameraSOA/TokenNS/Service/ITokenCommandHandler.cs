using System.Threading.Tasks;
using UsersApi.DameraSOA.TokenNS.Model;
using UsersApi.DameraSOA.UserNS.Model;

namespace UsersApi.DameraSOA.TokenNS.Service
{
    public interface ITokenCommandHandler
    {
        Task<Token> Create(Token token);
        Task<Token> Login(User user);
        Task Delete(int userID);
    }
}
