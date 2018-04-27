using System;

namespace Bolao.Domain.Entities
{
    public class Entity
    {
        public Entity()
        {
            this.Id = Guid.NewGuid();
            this.DataCadastro = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public DateTime DataCadastro { get; private set; }
    }
}