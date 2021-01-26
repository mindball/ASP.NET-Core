﻿namespace MoiteRecepti2.Data.Models
{
    using System;

    using MoiteRecepti2.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public string Extension { get; set; }

        //The contents of the image is in the file system
        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
