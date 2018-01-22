using AplicacaoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AplicacaoWeb.Controllers
{
    public class OSController : ApiController
    {
        //Aplicação não linkada a algum BD, utilizar a List<> para inserir e buscar resultados
        private static List<OrdemServico> os = new List<OrdemServico>();

        //Retornando todas as Ordens de Serviço
        public IHttpActionResult Get()
        {
            return Ok(os);
        }

        //Retorna a 1ª Ordem de Serviço na lista correspondente ao ID.
        //Como o ID é único, o retorno sempre será o desejado.
        public IHttpActionResult Get(int id)
        {
            return Ok(os.First(x => x.ID.Equals(id)));
        }
        
        //Faz verificação de ID antes de postar. Não posta se ID já estiver inserido.
        public void Post(int id, int idCliente, DateTime dataCriacao, DateTime dataExecucao, int qtdeServicos)
        {
            if(!os.Any(os => os.ID == id))
                os.Add(new OrdemServico(id,idCliente,dataCriacao,dataExecucao,qtdeServicos));
        }
    }
}
