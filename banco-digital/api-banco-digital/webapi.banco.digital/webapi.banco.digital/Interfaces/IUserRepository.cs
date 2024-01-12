using webapi.banco.digital.Domains;

namespace webapi.banco.digital.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Realiza o cadastro de um novo usuário
        /// </summary>
        /// <param name="newUser">Objeto do tipo Usuario</param>
        User Register(User newUser);

        /// <summary>
        /// Remove um Usuario (somente um Admin pode e haverá verificações antes de ser concluido)
        /// </summary>
        /// <param name="accountNumber"></param>
        void Delete(Guid accountNumber);
    }
}