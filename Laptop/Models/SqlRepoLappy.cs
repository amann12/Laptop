using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laptop.Models
{
    public class SqlRepoLappy : InterfaceLappy
    {
        private readonly AppDbContext context;
        public SqlRepoLappy(AppDbContext context)
        {
            this.context = context;
        }
        public Lappy Add(Lappy lappy)
        {
            context.Laptop.Add(lappy);
            context.SaveChanges();
            return lappy;

        }

        public Lappy Delete(int Id)
        {
            Lappy lappy = context.Laptop.Find(Id);
            if (lappy != null)
            {
                context.Laptop.Remove(lappy);
                context.SaveChanges();
            }
            return lappy;
        }

        public IEnumerable<Lappy> GetAllDetails()
        {
            return context.Laptop;
        }

        public Lappy GetLappy(int Id)
        {
            return context.Laptop.Find(Id);
        }

        public Lappy Update(Lappy lappyChange)
        {
            var lappy = context.Laptop.Attach(lappyChange);
            lappy.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return lappyChange;

        }
    }
}
