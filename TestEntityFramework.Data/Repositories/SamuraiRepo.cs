using TestEntityFramework.Data.Entities;

namespace TestEntityFramework.Data.Repositories
{
    public class SamuraiRepo : ISamuraiRepo
    {
        private DatabaseContext _context;

        public SamuraiRepo()
        {
            _context = new DatabaseContext();
        }

        public void AddSamurai(string name, string dynasty = "Edo")
        {
            Samurai samurai = new Samurai(name)
            {
                Dynasty = dynasty
            };

            _context.Samurais.Add(samurai);
            _context.SaveChanges();
            // belangrijk om direct hetgeen je aanmaakt gepusht wordt naar je database
        }
    }
}