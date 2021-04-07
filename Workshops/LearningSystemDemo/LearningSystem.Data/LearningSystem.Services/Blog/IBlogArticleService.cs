﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Services.Blog
{
    public interface IBlogArticleService
    {
        Task CreateAsync(string title, string content, string authorId);
    }
}
