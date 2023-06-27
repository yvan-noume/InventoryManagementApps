using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryManagementDomainLayer
{
    public class Admin: Person
    {
        public Admin(string firstName, string lastName, string email, int phoneNumber, string address, string username, string password) 
            : base(firstName, lastName, email, phoneNumber, address)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public bool CreateAdmin()
        {
            return false;
        }

        public bool DeleteAdmin()
        {
            return false;
        }

        public bool UpdateAdmin()
        {
            return false;
        }

        public bool GetAdmin()
        {
            return false;
        }

        public  bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);

            return match.Success;
        }
    }
}
