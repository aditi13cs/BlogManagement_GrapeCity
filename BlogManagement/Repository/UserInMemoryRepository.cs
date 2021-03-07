using BlogManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Repository
{
    public class UserInMemoryRepository : IUserRepository
    {
        private static IDictionary<int, UserDetails> InMemoryBlogs;
        public UserInMemoryRepository()
        {
            InMemoryBlogs = new Dictionary<int, UserDetails>()
            {
                { 1, new UserDetails()
                    {
                        UserId = 1,
                        Name = "Testing1",
                        Age = 30,
                        Address = "Flat no. - 100, 18th floor, Ghaziabad",
                        EmailAddress = "testing1@gmail.com",
                        Role = "Admin",
                        Password = "TestUser1"
                    }
                }
            };
        }
        public void Add(UserDetails entity)
        {
            if (entity != null && InMemoryBlogs.Keys.Contains(entity.UserId) == false)
            {
                InMemoryBlogs.Add(entity.UserId, entity);
            }
        }

        public List<UserDetails> Get()
        {
            return InMemoryBlogs.Values.ToList();
        }

        public UserDetails GetById(int id)
        {
            if (InMemoryBlogs.Keys.Contains(id))
            {
                return InMemoryBlogs[id];
            }
            else
            {
                return new NullUserDetails();
            }
        }

        public void Update(UserDetails entity)
        {
            if (entity != null && InMemoryBlogs.Keys.Contains(entity.UserId))
            {
                InMemoryBlogs[entity.UserId] = entity;
            }
        }

        public void Delete(UserDetails entity)
        {
            if (entity != null && InMemoryBlogs.Keys.Contains(entity.UserId))
            {
                InMemoryBlogs.Remove(entity.UserId);
            }
        }
    }
}
