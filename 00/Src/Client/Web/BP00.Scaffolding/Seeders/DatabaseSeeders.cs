using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using BP00.Scaffolding.Data;
using BP00.Scaffolding.Domain;

namespace BP00.Scaffolding.Migrations
{
    public class DatabaseSeeders
    {
        public static void Seed(DefaultContext context)
        {
            new List<Person>()
            {
                
              new Person()
              {
                  Id = 1,
                  Gender = Gender.Male,
                  FirstName = "Git",
                  LastName = "Hub",
                  DayOfBirth = DateTime.Now,
                  Email = "github@github.com",
                  Street = "123 VS Street",
                  Option = "2nd Floor Apprt 08" ,
                  ZipCode = "11 777",
                  City = "Azure",
                  State = "Microsoft",
                  Country = "Code for fun"

              }  ,
               new Person()
              {
                  Id = 2,
                  Gender = Gender.Male,
                  FirstName = "Toto",
                  LastName = "Fofo",
                  DayOfBirth = DateTime.Now,
                  Email = "Totofofo@github.com",
                  Street = "123 VS Crazy",
                  Option = "2nd Floor Apprt 08" ,
                  ZipCode = "22 777",
                  City = "Share point",
                  State = "Plateform",
                  Country = "Code for fun"

              }


            }.ForEach(o => context.Persons.AddOrUpdate(o));
        }
    }
}