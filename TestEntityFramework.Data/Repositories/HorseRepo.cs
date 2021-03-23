using TestEntityFramework.Data.Entities;

namespace TestEntityFramework.Data.Repositories
{
    public class HorseRepo : IHorseRepo
    {
        private DatabaseContext _context;

        public HorseRepo()
        {
            _context = new DatabaseContext();
        }

        public Horse CreateHorse(string name, int samuraiId)
        {
            Horse horse = new Horse(name, samuraiId);

            return horse;
        }


        public void AddHorse(Horse horse)
        {
            _context.Horses.Add(horse);
            _context.SaveChanges();


        }
    }
}