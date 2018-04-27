using System;

namespace Bolao.Domain.Entities.Championship
{
    public class Jogo
    {
        public int? GolsMandante { get; private set; }

        public int? GolsVisitante { get; private set; }

        public DateTime DataHoraPartida { get; private set; }

        public bool PartidaFinalizada { get; private set; }

        public virtual Campeonato Campeonato { get; private set; }

        public virtual Time Mandante { get; private set; }

        public virtual Time Visitante { get; private set; }
    }
}