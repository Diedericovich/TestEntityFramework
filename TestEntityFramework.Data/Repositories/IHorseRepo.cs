using TestEntityFramework.Data.Entities;

namespace TestEntityFramework.Data.Repositories
{
    public interface IHorseRepo
    {
        void AddHorse(Horse horse);
        Horse CreateHorse(string name, int samuraiId);
    }
}