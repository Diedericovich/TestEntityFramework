using System.ComponentModel.DataAnnotations;

namespace TestEntityFramework.Data.Entities
{
    public class Quote
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Text { get; set; }

        public Samurai Samurai { get; set; }

        // '[foreign key]'
        public int SamuraiId { get; set; }

        public Quote(string text, int samuraiId)
        {
            Text = text;
            SamuraiId = samuraiId;
        }
    }
}