using webapi.banco.digital.Domains;

namespace webapi.banco.digital.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Realiza o cadastro de um novo usuário
        /// </summary>
        /// <param name="novoUsuario">Objeto do tipo Usuario</param>
        User Register(User novoUsuario);

        /// <summary>
        /// Remove um Usuario (somente um Admin pode e haverá verificações antes de ser concluido)
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid idAccount);
    }
}