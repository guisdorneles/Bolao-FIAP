using Bolao.Domain.Entities.User;
using Bolao.Domain.Interface.Repository.User;

namespace Bolao.Infraestrutura.EntityFramework.Repository.User
{
    public class UsuarioRepository: BaseRepository<Usuario>, IUsuarioRepository
    {  }
}