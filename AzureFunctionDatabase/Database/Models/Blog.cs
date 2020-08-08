using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunctionDatabase.Database.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
