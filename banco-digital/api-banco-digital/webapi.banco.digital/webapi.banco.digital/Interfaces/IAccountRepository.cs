using webapi.banco.digital.Domains;

namespace webapi.banco.digital.Interfaces
{
    public interface IAccountRepository
    {
        void Register(Account newAccount);
        void Delete(Guid idAccount);
    }
}
