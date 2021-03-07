using BlogManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Repository
{
    public class BlogInMemoryRepository : IBlogRepository
    {
        private static IDictionary<int, BlogDetails> InMemoryBlogs;
        public BlogInMemoryRepository()
        {
            InMemoryBlogs = new Dictionary<int, BlogDetails>() { { 1, new BlogDetails() { BlogId = 1, UserId = 1, Title = "Visiting Netaji Bhawan – Decoding Subhash Chandra Bose’s disappearance",
                BlogSummary = "A typical Bengali household located on Elgin Road in Kolkata was once the residence of India’s most renowned freedom fighter – " +
                "Netaji Subhash Chandra Bose. Chances are you have crossed this modest building numerous times, but you haven’t stopped to look around. The ancestral home" +
                " of Subhash Chandra Bose was built in 1909 by his father Janakinath Bose. From the outside, the house looks like just another building in Kolkata, but " +
                "the walls of his house have held secrets that haven’t seen the sun outside. For the longest time, Bose’s residence was, in fact, the nerve center of all " +
                "political activity in Calcutta.",
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now} } };
        }
        public void Add(BlogDetails entity)
        {
            if (entity != null && InMemoryBlogs.Keys.Contains(entity.BlogId) == false)
            {
                InMemoryBlogs.Add(entity.BlogId, entity);
            }
        }

        public List<BlogDetails> Get()
        {
            return InMemoryBlogs.Values.ToList();
        }

        public BlogDetails GetById(int id)
        {
            if (InMemoryBlogs.Keys.Contains(id))
            {
                return InMemoryBlogs[id];
            }
            else
            {
                return new NullBlogDetails();
            }
        }

        public void Update(BlogDetails entity)
        {
            if (entity != null && InMemoryBlogs.Keys.Contains(entity.BlogId))
            {
                InMemoryBlogs[entity.BlogId] = entity;
            }
        }

        public void Delete(BlogDetails entity)
        {
            if (entity != null && InMemoryBlogs.Keys.Contains(entity.BlogId))
            {
                InMemoryBlogs.Remove(entity.BlogId);
            }
        }
    }
}
