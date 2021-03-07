using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Model
{
    public class BlogDetails
    {
        public int BlogId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string BlogSummary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }


    public class NullBlogDetails : BlogDetails
    {
        public NullBlogDetails()
        {
            BlogId = 0;
            UserId = 0;
            Title = string.Empty;
            BlogSummary = string.Empty;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
