using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_WEB.Models.Users
{
    public abstract class User
    {
        [Key] public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Cp { get; set; }
        public string City { get; set; }


        public User(string LastName, string FirstName, string Email, string Password, string PhoneNumber, string Address, string Cp, string City)
        {
            Id =  Guid.NewGuid();
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Email = Email;
            this.Password = Password;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Cp = Cp;
            this.City = City;

        }
    }
}
