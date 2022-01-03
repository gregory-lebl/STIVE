using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Users
{
    public class Customer : User
    {
        public string CustomerReference { get; set; }

        public Customer(string LastName, string FirstName, string Email, string Password, string PhoneNumber, string Address, string Cp, string City) : base(LastName, FirstName, Email, Password, PhoneNumber, Address, Cp, City){
        var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var Charsarr = new char[12];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }
            var customerRef = new String(Charsarr);

            CustomerReference = customerRef;
        
        }

    }
}
