using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicProfiler.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }

        //Relationship properties
        //Blog
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
