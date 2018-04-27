using System;

namespace Bolao.Domain.Entities.User
{
    public class Usuario: Entity
    {
        public Usuario(string nome, string email, string cpf, string senha, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Cpf { get; private set; }

        public string Senha { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public bool Ativo { get; private set; }

        public Usuario AlterarSenha(string senha)
        {
            this.Senha = senha;
            return this;
        }

        public Usuario Desativar()
        {
            this.Ativo = false;
            return this;
        }

        public Usuario Ativar()
        {
            this.Ativo = true;
            return this;
        }

    }
}