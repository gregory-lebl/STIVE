using System;

namespace STIVE_WEB.Models.Users
{
    public class Customer
    {

        public string Id { get; set; }
        public string CustomerReference { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordVerify { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Cp { get; set; }
        public string City { get; set; }

        public Customer()
        {
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
