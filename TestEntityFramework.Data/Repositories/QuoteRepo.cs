using TestEntityFramework.Data.Entities;

namespace TestEntityFramework.Data.Repositories
{
    public class QuoteRepo : IQuoteRepo
    {
        private DatabaseContext _context;

        public QuoteRepo()
        {
            _context = new DatabaseContext();
        }

        public void AddQuote(string text, int samuraiId)
        {
            Quote quote = new Quote(text, samuraiId);

            _context.Quotes.Add(quote);
            _context.SaveChanges();
        }
    }
}