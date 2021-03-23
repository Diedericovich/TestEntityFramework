namespace TestEntityFramework.Data.Repositories
{
    public interface IQuoteRepo
    {
        void AddQuote(string text, int samuraiId);
    }
}