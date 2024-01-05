using Microsoft.AspNetCore.Http.HttpResults;
using webapi.banco.digital.Domains;
using webapi.banco.digital.Infra;
using webapi.banco.digital.Interfaces;

namespace webapi.banco.digital.Repositories
{
    public class UsuarioRepository : IUserRepository
    {
        private Context _context;

        /// <summary>
        /// Register a new User in the data bank
        /// </summary>
        /// <param name="newUser">Object of type User</param>
        /// <returns>Object of type User</returns>
        public User Register(User newUser)
        {
            try
            {
                if (newUser != null)
                {
                    _context.Users.Add(newUser);
                    _context.SaveChanges();
                    return newUser;
                }
                else
                    return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Remove um usuário existente do banco de dados
        /// </summary>
        /// <param name="idAccount">Id da conta do usuário a ser deletado</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Delete(Guid idAccount)
        {
            try
            {
                User userFound = _context.Users.FirstOrDefault(u => u.IdAccount == idAccount)!;
                if (userFound != null)
                {
                    _context.Users.Remove(userFound);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}