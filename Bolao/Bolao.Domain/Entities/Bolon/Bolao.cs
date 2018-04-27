using System;
using Bolao.Domain.Entities.Championship;
using Bolao.Domain.Entities.User;

namespace Bolao.Domain.Entities.Bolon
{
    public class Bolao
    {
        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public DateTime DataInicio { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Campeonato Campeonato { get; private set; }
    }
}