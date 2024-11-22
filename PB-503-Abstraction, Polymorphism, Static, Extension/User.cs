using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_Abstraction__Polymorphism__Static__Extension
{
    public class User : IAccount
    {
        string _password;
        public readonly int Id;
        public string Email { get; set; }
        public string Fullname { get; set; }

        public string Password
        { 
            get => _password;

            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }else Console.WriteLine("Write valid password!!!");
            }
        }

        public User(string email,string password)
        {
            Email = email;
            Password = password;
            Id++;
        }

        public bool PasswordChecker(string password)
        {
            bool result = false;
            bool Upper=false, Lower=false,Digit=false;
            if (password.Length > 7)
            {
                foreach (char c in password)
                {
                    if (char.IsLower(c))
                    {
                        Lower = true;
                    }
                    else if (char.IsUpper(c))
                    {
                        Upper = true;
                    }
                    else if (char.IsDigit(c))
                    {
                        Digit = true;
                    }
                }
                if (Upper && Lower && Digit)
                {
                    result = true;
                }
            }
            return result;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} \nEmail:{Email} \nFullname:{Fullname} ");
        }
    }
}