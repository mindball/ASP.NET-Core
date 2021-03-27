﻿namespace Messages.Data
{
    using System;

    public class Message
    {
        public Message()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual User  User { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}