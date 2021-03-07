using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Model
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public IEnumerable<UserDetails> GetUsers()
        {
            return new List<UserDetails>()
                { 
                    new UserDetails
                        {
                            UserId = 2,
                            Name = "Testing2",
                            UserName = "Testing2",
                            Age = 30,
                            Address = "Flat no. - 100, 18th floor, Ghaziabad",
                            EmailAddress = "testing2@gmail.com",
                            Role = "User",
                            Password = "TestUser2"
                        }
                };
        }

    }



    public class NullUserDetails : UserDetails
    {
        public NullUserDetails()
        {
            UserId = 0;
            Name = string.Empty;
            UserName = string.Empty;
            Age = 0;
            Address = string.Empty;
            EmailAddress = string.Empty;
            Role = string.Empty;
            Password = string.Empty;
        }
    }
}
