using System.Data.Entity;

namespace Contrucks.Repository
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("ConTruckConnectionString")
        {
        }
        public DbSet<Person> Persons { get; set; }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
