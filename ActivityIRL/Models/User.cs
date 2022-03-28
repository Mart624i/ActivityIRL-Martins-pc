
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityIRL.Models
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName;
        public string? Gender;
        public string? Birthdate;

        public string? EmailAddress;
        public string? Password;
        public int? PhoneNumber;

        public string? StreetName;
        public int? ApartmentNumber;
        public string? City;
        public int? ZipCode;
        public string? Country;

        public int? UserId; //Primary key

        public List<string>? preferences;

        

    }
}
