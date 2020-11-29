using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicProfiler.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogUrl { get; set; }
        public string BlogDescription { get; set; }
        
        //Relationship properties
        //Post
        public List<Post> Posts { get; set; }
        //Author
        public int AuthorId { get; set; }
        public Author Author { get; set; } //blog with single reference to the author


    }
}
