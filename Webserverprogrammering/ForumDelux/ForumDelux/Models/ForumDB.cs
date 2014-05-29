using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ForumDelux.Models
{
    public class ForumDB : DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicComment> TopicComments { get; set; }
    }
}