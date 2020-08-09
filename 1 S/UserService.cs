using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace SOLID_Principles
{
    public class UserService
    {

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);

            SendEmail(user);
        }

        public void Login(string email, string password)
        {
            Console.WriteLine("Login");
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(User message) => Console.WriteLine("send message");

        
    }
}
