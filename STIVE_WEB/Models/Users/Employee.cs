using System;

namespace STIVE_WEB.Models.Users
{
    public class Employee : User
    {

        public string EmployeNumber { get; set; }
        //public byte[]? Picture { get; set; }

        public Employee( string LastName, string FirstName, string Email, string Password, string PhoneNumber, string Address, string Cp, string City) : base (LastName, FirstName, Email, Password, PhoneNumber, Address, Cp, City)
        {

            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var Charsarr = new char[10];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }
            var employeNumber = new String(Charsarr);

            EmployeNumber = employeNumber;
        }

    }
}
