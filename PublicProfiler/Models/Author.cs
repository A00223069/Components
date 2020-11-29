using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace PublicProfiler.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        //Relationship propeties
        //this author is allowed to write multiple blogs
        //Blog
        [JsonIgnore]
        public ICollection<Blog> Blogs { get; set; }


    }
}
