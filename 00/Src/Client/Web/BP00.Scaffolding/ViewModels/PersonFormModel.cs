using System;
using System.ComponentModel.DataAnnotations;
using BP00.Scaffolding.Domain;

namespace BP00.Scaffolding.ViewModels
{
    public class PersonFormModel
    {

        public int Id { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.ImageUrl)]
        public string AvatarUrl { get; set; }

        [Display(Name = "Sex" )]
        [Required]
        public Gender Gender { get; set; }

        [Display(Name = "Nom")]
        [Required]
        [StringLength(60)]
        public string FirstName { get; set; }

        [Display(Name = "Prénom")]
        [Required]
        [StringLength(60)]
        public string LastName { get; set; }


        [Display(Name = "Nom & prénom")]
        public string FullName
        {
            get { return String.Format("{0}{1}{2}", FirstName, " ", LastName); }
        }


        public string DisplayName
        {
            get { return String.Format("{0}{1}.", FirstName, LastName.Substring(0, 1)); }
        }


        [Display(Name = "Date de naissance")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DayOfBirth { get; set; }

        [Display(Name = "Email")]
        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Display(Name = "Rue")]
        [Required]
        [StringLength(100)]

        public string Street { get; set; }

        [Display(Name = "Complement")]
       [StringLength(100)]
        public string Option { get; set; }


        [Display(Name = "Code postal")]
        [Required]
        [StringLength(30)]
        public string ZipCode { get; set; }

        [Display(Name = "Ville")]
        [Required]
        [StringLength(60)]
        public string City { get; set; }


        [Display(Name = "Région")]
        [Required]
        [StringLength(60)]
        public string State { get; set; }


        [Display(Name = "Pays")]
        [Required]
        [StringLength(60)]
        public string Country { get; set; }

        [Display(Name = "N° téléphone")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
      
    }
}