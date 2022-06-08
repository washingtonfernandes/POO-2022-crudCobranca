using System.Collections;
using System.Collections.Generic;
using Aula11CrudClient.Models.Domains;
using Aula11CrudClient.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula11CrudClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private IClientRepository repository;
       
        public ClientController(IClientRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IEnumerable<Client>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Client Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost()]
        public IActionResult Post([FromBody]Client client)
        {
            repository.Create(client);
            return Ok(new{
                message = "Cliente cadastrado com sucesso !!",
                httpCode=202,
                objectCreated = client
            });
            
        } 

        [HttpPut]
        public ActionResult UpdateClient([FromBody] Client client)
        {
            repository.Update(client);
            return Ok(new {
                message = "Cliente atualizado!",
                errorCode = 202,
                objectCreated = client});
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(new {
                message = "Gravado com sucesso!",
                errorCode = 202
                });
        } 
 
    }
}