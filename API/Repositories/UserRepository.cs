using API.DataContext;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories
{
    public class UserRepository
    {
        private readonly dbContext _context;

        public UserRepository(dbContext context) => _context = context;

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(user => user.Username.Equals(username));
        }

        public User GetUser(int UserId)
        {
            return _context.Users.FirstOrDefault(user => user.Id.Equals(UserId));
        }
        public void InsertUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            var UserForUpdate = GetUser(user.Id);
            if (UserForUpdate is not null)
            {
                if (!string.IsNullOrEmpty(user.Firstname))
                {
                    UserForUpdate.Firstname = user.Firstname;
                }
                if (!string.IsNullOrEmpty(user.Lastname))
                {
                    UserForUpdate.Lastname = user.Lastname;
                }
                if (!string.IsNullOrEmpty(user.Username))
                {
                    UserForUpdate.Username = user.Username;
                }
                if (!string.IsNullOrEmpty(user.Email))
                {
                    UserForUpdate.Email = user.Email;
                }
                if (!string.IsNullOrEmpty(user.Password))
                {
                    UserForUpdate.Password = user.Password;
                }
                if (!string.IsNullOrEmpty(user.Role))
                {
                    UserForUpdate.Role = user.Role;
                }
                _context.SaveChanges();
            }
        }
        public void DeleteUser(int UserId)
        {
            var UserForDeletion = GetUser(UserId);
            if (UserForDeletion is not null)
            {
                _context.Users.Remove(UserForDeletion);
                _context.SaveChanges();
            }
        }
    }
}
