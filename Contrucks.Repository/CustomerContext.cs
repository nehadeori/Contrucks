using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("name=MyConnectionString")
        {
        }
        public DbSet<Person> Persons { get; set; }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
