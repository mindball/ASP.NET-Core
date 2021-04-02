﻿using System;
using System.ComponentModel.DataAnnotations;

using static LearningSystem.Data.DataConstants;

namespace LearningSystem.Data.Models
{
    public class Article
    {
        public Article()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MinLength(ArticleTitleMinLength)]
        [MaxLength(ArticleTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author  { get; set; }
    }
}
