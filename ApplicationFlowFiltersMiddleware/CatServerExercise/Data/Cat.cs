﻿namespace CatServerExercise.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Cat
    {
        private const int MaxLen = 50;

        public Cat()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        
        public string Id { get; set; }

        [Required]
        [MaxLength(MaxLen)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxLen)]
        public string Breed { get; set; }

        [Range(0, 30)]
        public int Age { get; set; }

        [Required]
        [MaxLength(2000)]
        public string ImageUrl { get; set; }

    }
}
