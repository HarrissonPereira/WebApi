using AplicacaoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AplicacaoWeb.Controllers
{
    public class ServicoController : ApiController
    {
        //Aplicação não linkada a algum BD, utilizar a List<> para inserir e buscar resultados
        private static List<Servicos> servico = new List<Servicos>();        

        //Retorna serviços ativos ou inativos, dependendo do valor do parâmetro
        public IHttpActionResult Get(bool valor)
        {            
            if (valor)
            {
                return Ok(servico.Where(s => s.IsActive.Equals(true)));
            }
            else
            {
                return Ok(servico.Where(s => s.IsActive.Equals(false)));
            }            
        }

        //Retorna uma list<> ordenada pela quantidade selecionada de serviços de maneira decrescente
        public IHttpActionResult Get()
        {
            return Ok(servico.OrderByDescending(c => c.QuantidadeSelecionada).ToList());
        }

        //Retorna um serviço buscado pelo ID. Como ID é único, a primeira ocorrência sempre será única.
        public IHttpActionResult Get(int id)
        {
            return Ok(servico.First(x => x.ID.Equals(id)));
        }

        public void Post(int id, string nome, decimal valorFinal, int quantidadeSelecionada, bool active)
        {
            if (!servico.Any(s => s.ID == id))
                servico.Add(new Servicos(id, nome, valorFinal,quantidadeSelecionada,active));
        }


    }
}
