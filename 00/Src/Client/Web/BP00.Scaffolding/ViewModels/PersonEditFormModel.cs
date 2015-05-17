using System;
using BP00.Scaffolding.Domain;

namespace BP00.Scaffolding.ViewModels
{
    public class PersonEditFormModel
    {
        public string AvatarUrl { get; set; }


        public Gender Gender { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }



        public string FullName
        {
            get { return String.Format("{0}{1}{2}", FirstName, " ", LastName); }
        }


        public string DisplayName
        {
            get { return String.Format("{0}{1}.", FirstName, LastName.Substring(0, 1)); }
        }



        public DateTime DayOfBirth { get; set; }


        public string Email { get; set; }


        public string Street { get; set; }


        public string Option { get; set; }



        public string ZipCode { get; set; }


        public string City { get; set; }


        public string State { get; set; }


        public string Country { get; set; }
    }
}