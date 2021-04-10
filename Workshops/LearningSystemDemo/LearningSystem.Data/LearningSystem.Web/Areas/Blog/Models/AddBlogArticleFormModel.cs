using System.ComponentModel.DataAnnotations;
using static LearningSystem.Data.DataConstants;

namespace LearningSystem.Web.Areas.Blog.Models
{
    public class AddBlogArticleFormModel
    {
        [Required]
        [MinLength(ArticleTitleMinLength)]
        [MaxLength(ArticleTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
