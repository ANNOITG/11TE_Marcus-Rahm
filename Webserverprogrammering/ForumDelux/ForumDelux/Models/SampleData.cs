using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ForumDelux.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ForumDB>
    {
        protected override void Seed(ForumDB context)
        {
            
           /* var TopicComments = new List<TopicComment>{
                new TopicComment{content = "Bla Bla Bla" }
            };

            var Topics = new List<Topic>
            {
                new Topic{topicName = "is it the end", content = "OMG its totaly is", views = 6, comment = TopicComments}
            };

            var Categorys = new List<Category>
            {
                new Category{name = "Action Games", Topic = Topics},
                new Category{name = "point and click"}

            };*/
        }
    }
}