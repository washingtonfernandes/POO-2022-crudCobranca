
using Aula11CrudClient.Models.Domains;
using Aula11CrudClient.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula11CrudClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DebitController : ControllerBase
    {
         private IDebitRepository repository;
       
        public DebitController(IDebitRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IEnumerable<Debit>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Debit Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost()]
        public IActionResult Post([FromBody]Debit debit)
        {
            repository.Create(debit);
            return Ok(new{
                message = "Cobrança cadastrada com sucesso !!",
                httpCode=202,
                objectCreated = debit
            });
        }

        [HttpPut]
        public ActionResult UpdateDebit([FromBody] Debit debit)
        {
            repository.Update(debit);
            return Ok(new {
                message = "Cobrança atualizado!",
                errorCode = 202,
                objectCreated = debit});
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