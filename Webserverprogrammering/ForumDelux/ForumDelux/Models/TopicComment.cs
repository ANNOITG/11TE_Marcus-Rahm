using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumDelux.Models
{
    public class TopicComment
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public virtual Topic Topic { get; set; }
    }
}