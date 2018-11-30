using System;
using System.Text.RegularExpressions;

namespace TheWalkingDog.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }

        public string Email { get; protected set; }

        public string Password { get; protected set; }

        public string Salt { get; protected set; }

        public string UserName { get; protected set; }

        public string FullName { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        public DateTime UpdatedAt { get; protected set; }

        
        protected User()
        {
        }

        public User(string email, string userName, string password, string salt)
        {
            Id = Guid.NewGuid();
            SetEmail(email);
            SetUserName(userName);
            SetPassword(password);
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }

        private void UpdateTime()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetUserName(string userName)
        {
            if (!Regex.IsMatch(userName, @"^[A-Za-z0-9]+(?:[ _-][A-Za-z0-9]+)*"))
            {
                throw new Exception("Username is invalid.");
            }

            UserName = userName;
            UpdateTime();
        }

        public void SetEmail(string email)
        {
            if (Email == email)
            {
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Email is required!.");
            }
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+\@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+"))
            {
                throw new Exception("Email can not be empty.");
            }

            Email = email.ToLowerInvariant();
            UpdateTime();
        }

        public void SetPassword(string password)
        {
            if (Password == password)
            {
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password is required.");
            }
            if (password.Length < 6)
            {
                throw new Exception("Password must contain at least 6 characters.");
            }

            Password = password;
            UpdateTime();
        }
    }
}