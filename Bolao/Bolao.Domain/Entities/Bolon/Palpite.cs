using Bolao.Domain.Entities.Championship;
using Bolao.Domain.Entities.User;

namespace Bolao.Domain.Entities.Bolon
{
    public class Palpite
    {
        public int GolsMandante { get; private set; }

        public int GolsVisitante { get; private set; }

        public virtual Bolao Bolao { get; private set; }

        public virtual Jogo Jogo { get; private set; }
        
        public virtual Usuario Usuario { get; private set; }
    }
}