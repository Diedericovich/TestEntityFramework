using System.ComponentModel.DataAnnotations;

namespace TestEntityFramework.Data.Entities
{
    public class Samurai
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Dynasty { get; set; }

        public Samurai(string name)
        {
            Name = name;
        }
    }
}