using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11CrudClient.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace Aula11CrudClient.Models.Repositories
{
    public class DebitRepository : IDebitRepository

    {
        private DataContext context;
        public DebitRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Debit debit)
        {
            if(debit.Client.Id>0)
                debit.Client = 
                context.Client.SingleOrDefault(x=>x.Id == debit.Client.Id);
            
            context.Add(debit);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Debit.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Debit> GetAll()
        {
            return context.Debit
            .Include(c=>c.Client)
            .ToList();
        }

        public Debit GetById(int id)
        {
            return context.Debit.Include(c=>c.Client).SingleOrDefault(i=>i.Id == id);
        }

        public void Update(Debit debit)
        {
           context.Debit.Update(debit);
           context.SaveChanges();
        }
    }
}
