using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BP00.Scaffolding.Domain;

namespace BP00.Scaffolding.ViewModels
{
    public class PersonHomeModel
    {
        public string AvatarUrl { get; set; }  
      
        
        public string FirstName { get; set; }


        public string LastName { get; set; }


        [Display(Name = "Nom et prénom")]
        public string FullName
        {
            get { return String.Format("{0}{1}{2}", FirstName, " ", LastName); }
        }  


        [DataType(DataType.EmailAddress)]
        [Display(Name = "Courrier éléctronique")]
        public string Email { get; set; }

        [Display(Name = "Rue")]
        public string Street { get; set; }

        [Display(Name = "Code postal")]
        [DataType(DataType.PostalCode)]

        public string ZipCode { get; set; }

        [Display(Name = "Ville")]
        public string City { get; set; }

        [Display(Name = "Adresse")]
        public string Address
        {
            get
            {
                return String.Format("{0}{1}{2}{3}{4}", Street, " ", ZipCode, " ", City);
                
            }
        }

        [Display(Name = "Région")]
        public string State { get; set; }

        [Display(Name = "Pays")]
        public string Country { get; set; }
    }
}