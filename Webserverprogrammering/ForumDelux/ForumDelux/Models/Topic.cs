using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumDelux.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public List<TopicComment> Comment { get; set; }
        public DateTime Created { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}