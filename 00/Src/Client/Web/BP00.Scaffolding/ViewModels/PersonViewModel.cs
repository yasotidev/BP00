using System;
using System.ComponentModel.DataAnnotations;
using BP00.Scaffolding.Domain;

namespace BP00.Scaffolding.ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Sex")]
         public Gender Gender { get; set; }
        [DataType(DataType.ImageUrl)]
        public string AvatarUrl { get; set; }  
      
        [Display(Name = "Nom")]
        public string FirstName { get; set; }

        [Display(Name = "Prénom")]
        public string LastName { get; set; }

        [Display(Name = "Date de naissance")]
        public DateTime DayOfBirth { get; set; }

       
        [Display(Name = "N° téléphone")]
        public string PhoneNumber { get; set; }

   

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
        
        [Display(Name = "Complement")]
        public string Option { get; set; }

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