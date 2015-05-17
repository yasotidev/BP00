using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BP00.Scaffolding.Domain
{
    public abstract class DomainObject : IValidatableObject
    {
        public int Id { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (false)
#pragma warning disable 162
            {
                yield return new ValidationResult("Oups, Ce-ci ne devrait pas se produire...!");
            }
#pragma warning restore 162
        }
    }
}