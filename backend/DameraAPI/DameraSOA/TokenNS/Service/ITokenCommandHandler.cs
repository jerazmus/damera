using System.Threading.Tasks;
using DameraAPI.DameraSOA.TokenNS.Model;
using DameraAPI.DameraSOA.UserNS.Model;

namespace DameraAPI.DameraSOA.TokenNS.Service
{
    public interface ITokenCommandHandler
    {
        Task<Token> Create(Token token);
        Task<Token> Login(User user);
        Task Delete(int userID);
    }
}
