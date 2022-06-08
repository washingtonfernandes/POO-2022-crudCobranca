
using System.Collections.Generic;
using System.Linq;
using Aula11CrudClient.Models.Domains;

namespace Aula11CrudClient.Models.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private DataContext context;
        public ClientRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Client client)
        {
            context.Add(client);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Client.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Client> GetAll()
        {
            return context.Client.ToList();
        }

        public Client GetById(int id)
        {
            return context.Client.SingleOrDefault(i=>i.Id == id);
        }

        public void Update(Client client)
        {
           context.Client.Update(client);
           context.SaveChanges();
        }
    }
}