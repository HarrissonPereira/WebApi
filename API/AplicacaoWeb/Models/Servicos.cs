using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacaoWeb.Models
{
    public class Servicos
    {
        public int ID { get; set; }
        public string NomeServico { get; set; }
        public decimal ValorFinal { get; set; }
        public int QuantidadeSelecionada { get; set; }
        public bool IsActive { get; set; }

        public Servicos(int id, string nome, decimal valorFinal, int qtdeSelecionada, bool active)
        {
            this.ID = id;
            this.NomeServico = nome;
            this.ValorFinal = valorFinal;
            this.QuantidadeSelecionada = qtdeSelecionada;
            this.IsActive = active;
        }
    }
}