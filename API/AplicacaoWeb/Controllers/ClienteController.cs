using AplicacaoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AplicacaoWeb.Controllers
{
    public class ClienteController : ApiController
    {
        //Aplicação não linkada a algum BD, utilizar a List<> para inserir e buscar resultados
        private static List<Cliente> clientes = new List<Cliente>();        
        
        //Retorna uma List<> ordenada de A-Z
        public IHttpActionResult Get()
        {                       
            return Ok(clientes.OrderBy(c => c.Nome).ToList());
        }

        //Retorna um Cliente buscado pelo ID. Como ID é único, a primeira ocorrência sempre será única.
        public IHttpActionResult Get(int id)
        {
            return Ok(clientes.First(x => x.ID.Equals(id)));
        }
        
        //Postagem verificando se há um email existente na list<>. Caso exista, não posta.        
        public void Post(int id, string nome, string email, DateTime dataNascimento, long telCelular, long telResidencial)
        {
            if (!clientes.Any(c => c.Email == email))
                clientes.Add(new Cliente(id, nome, email, dataNascimento, telCelular, telResidencial));             
        }
    }
}
