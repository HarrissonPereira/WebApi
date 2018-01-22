using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacaoWeb.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public long TelefoneCelular { get; set; }
        public long TelefoneResidencial { get; set; }

        public Cliente(int id, string nome, string email, DateTime dataNascimento, long telCelular, long telResidencial)
        {
            this.ID = id;
            this.Nome = nome;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.TelefoneCelular = telCelular;
            this.TelefoneResidencial = telResidencial;
        }
    }
}