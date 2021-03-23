namespace TestEntityFramework.Data.Repositories
{
    public interface ISamuraiRepo
    {
        void AddSamurai(string name, string dynasty = "Edo");
    }
}