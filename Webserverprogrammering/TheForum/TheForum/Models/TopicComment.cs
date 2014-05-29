using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheForum.Models
{
    public class TopicComment
    {
        public int id { get; set; }
        public string content { get; set; }
        public Topic topic { get; set; }
    }
}