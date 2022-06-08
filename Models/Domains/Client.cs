using System.Security.AccessControl;
using Aula11CrudClient.Models.Domains;

namespace Aula11CrudClient.Models.Domains
{
    public class Client
    {
        public Client(){}
        public Client(int id, string nome, string fone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Fone = fone;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
    }
}