using webapi.banco.digital.Domains;
using webapi.banco.digital.Infra;

namespace webapi.banco.digital.Repositories
{
    public class AccountRepository
    {
        private Context _context;

        public AccountRepository()
        {
            _context = new();
        }


        public void Register(Account newAccount)
        {

        }
    }
}
