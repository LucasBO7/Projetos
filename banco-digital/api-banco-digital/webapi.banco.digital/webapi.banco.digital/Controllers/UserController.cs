using Microsoft.AspNetCore.Mvc;
using webapi.banco.digital.Domains;
using webapi.banco.digital.Interfaces;
using webapi.banco.digital.Repositories;

namespace webapi.banco.digital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        /// <summary>
        /// Cadastra um usuário no banco
        /// </summary>
        /// <param name="user">Objeto do tipo User</param>
        /// <returns>ActionResult</returns>
        [HttpPost]
        public IActionResult Post(User user)
        {
            try
            {
                // Se NÃO houver dados em "User"
                if (user == null)
                    return BadRequest();

                _userRepository.Register(user);
                return Ok(user);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        /// <summary>
        /// Deleta um usuário pel
        /// </summary>
        /// <param name="accountNumber">Número da conta</param>
        /// <returns>ActionResult</returns>
        [HttpDelete]
        public IActionResult DeleteByAccountId(Guid accountNumber)
        {
            try
            {
                if (accountNumber == null)
                    return BadRequest();

                _userRepository.Delete(accountNumber);
                return Ok("Usuário e conta relacionada deletada com sucesso!");
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

    }
}
