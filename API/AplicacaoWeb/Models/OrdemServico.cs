using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacaoWeb.Models
{
    public class OrdemServico
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime DataExecucao { get; set; }
        public int QuantidadeServicos { get; set; }

        public OrdemServico(int id, int idCliente, DateTime dataContratacao, DateTime dataExecucao, int qtdeServicos)
        {
            this.ID = id;
            this.IDCliente = idCliente;
            this.DataContratacao = dataContratacao;
            this.DataExecucao = dataExecucao;
            this.QuantidadeServicos = qtdeServicos;
        }
    }
}