using System;
using System.ComponentModel.DataAnnotations;

namespace TestEntityFramework.Data.Entities
{
    public class Horse
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Range(0, 35)]
        public int Age { get; set; }

        public char Gender { get; set; }

        public Samurai Samurai { get; set; }

        public int SamuraiId { get; set; }
        // this is foreign key. When writen correctly, VS recognizes class and table automatically

        public Horse(string name, int samuraiId)
        {
            Name = name;
            SamuraiId = samuraiId;
        }
    }
}