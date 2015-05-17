using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BP00.Scaffolding.Data;
using BP00.Scaffolding.Domain;
using BP00.Scaffolding.ViewModels;

namespace BP00.Scaffolding.Controllers
{
    public class PersonController : Controller
    {

        private readonly DefaultContext _dataContext = new DefaultContext();
        // GET: Person
        public ActionResult Index()
        {

            var persons = _dataContext.Persons.ToList();
            var model = new List<PersonHomeModel>();

            if (persons.Any())
            {
                foreach (var person in persons)
                {
                    model.Add(new PersonHomeModel()
                    {
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        Email = person.Email,
                        Street = person.Street,
                        ZipCode = person.ZipCode,
                        City = person.City,
                        State = person.State,
                        Country = person.Country
                    });
                }  
            }
            return View(model);
        }

        // GET: Person/Details/5
        public ActionResult Details(int? id)
        {
            var person = _dataContext.Persons.SingleOrDefault(o => o.Id == id);
            var model = new PersonDetailsFormModel();

            if (person != null)
            {
                person.Id = model.Id;
                person.Gender = model.Gender;
                person.FirstName = model.FirstName;
                person.LastName = model.LastName;
                person.DayOfBirth = model.DayOfBirth;
               

                person.Email = model.Email;

                person.Street = model.Street;
                person.Option = model.Option;
                person.ZipCode = model.ZipCode;
                person.City = model.City;
                person.State = model.State;
                person.Country = model.Country;
            }

            return View(model);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonEditFormModel model)
        {
            try
            {
                // TODO: Add insert logic here
                var person = new Person();
                if (model != null)
                {
                    
                    model.Gender = person.Gender;
                    model.FirstName = person.FirstName;
                    model.LastName = person.LastName;
                    model.DayOfBirth = person.DayOfBirth;


                    model.Email = person.Email;

                    model.Street = person.Street;
                    model.Option = person.Option;
                    model.ZipCode = person.ZipCode;
                    model.City = person.City;
                    model.State = person.State;
                    model.Country = person.Country;
                    model.Gender = person.Gender;
                    model.FirstName = person.FirstName;
                    model.LastName = person.LastName;
                    model.DayOfBirth = person.DayOfBirth;


                    model.Email = person.Email;

                    model.Street = person.Street;
                    model.Option = person.Option;
                    model.ZipCode = person.ZipCode;
                    model.City = person.City;
                    model.State = person.State;
                    model.Country = person.Country;
                }
                _dataContext.Persons.Add(person);
                person.Created = DateTime.UtcNow;
                _dataContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
