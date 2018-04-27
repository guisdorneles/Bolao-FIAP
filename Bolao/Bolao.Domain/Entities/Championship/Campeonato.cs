using System;

namespace Bolao.Domain.Entities.Championship
{
    public class Campeonato
    {
        public string Nome { get; private set; }

        public DateTime DataInicio { get; private set; }

        public DateTime DataFinal { get; private set; }

        public bool Ativo { get; private set; }
    }
}