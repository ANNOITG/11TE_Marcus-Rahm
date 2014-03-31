using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Topic
    {
        public int id { get; set; }
        public Category category { get; set; }
        public string topicName { get; set; }
        public string content { get; set; }
        public List<TopicComment> comment { get; set; }
        public int views { get; set; }

    }
}