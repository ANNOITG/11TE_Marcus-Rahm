using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheForum.Models;

namespace TheForum.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ForumDbContext>
    {
        protected override void Seed(ForumDbContext context)
        {
            var categorys = new List<Category>
            {
                new Category{name = "Action Games"},
                new Category{name = "point and click"}

            };

            var topics = new List<Topic>
            {
                new Topic{topicName = "is it the end", category = categorys.Single(c => c.name == "Action Games"), content = "OMG its totaly is"}
            };
        }

    }
}
