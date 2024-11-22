using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_Abstraction__Polymorphism__Static__Extension
{
    public interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
