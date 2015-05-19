using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using BP00.Scaffolding.Data;
using BP00.Scaffolding.Domain;
using BP00.Scaffolding.ViewModels;

namespace BP00.Scaffolding.Controllers
{
    public class PersonController : Controller
    {

        readonly DefaultContext _dataContext = new DefaultContext();
        // GET: Person

        public ActionResult Index()
        {

            var persons = from person in _dataContext.Persons select person;

            var model = new List<PersonViewModel>();

            if (persons.Any())
            {
                foreach (var person in persons)
                {
                    model.Add(new PersonViewModel
                    {
                        Id = person.Id,
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        Gender = person.Gender,
                        PhoneNumber = person.PhoneNumber,
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


        public ActionResult Details(int id)
        {

            var person = _dataContext.Persons.FirstOrDefault(o => o.Id == id);

            var model = new PersonViewModel();
            if (person != null)
            {
                model.Id = person.Id;
                model.FirstName = person.FirstName;
                model.LastName = person.LastName;
                model.DayOfBirth = person.DayOfBirth;
                model.Gender = person.Gender;
                model.PhoneNumber = person.PhoneNumber;
                model.Email = person.Email;
                model.Street = person.Street;
                model.Option = person.Option;
                model.ZipCode = person.ZipCode;
                model.City = person.City;
                model.State = person.State;
                model.Country = person.Country;
            }

            return View(model);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonFormModel model)
        {
            //var newId = _dataContext.Persons.Max(o => o.Id) + 1;

            var person = new Person
            {

                Id = new int(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                Street = model.Street,
                Option = model.Option,
                ZipCode = model.ZipCode,
                City = model.City,
                State = model.Street,
                Country = model.Country
                

            };
            if (ModelState.IsValid)
            {
                _dataContext.Entry(person).State = EntityState.Added;
                person.Created = DateTime.Now;
                _dataContext.Persons.Add(person);
                _dataContext.SaveChanges();
                return RedirectToAction("Index");
            }



            return View(model);
        }

        public ActionResult Edit(int id)
        {

            var person = _dataContext.Persons.FirstOrDefault(o => o.Id == id);

            var model = new PersonFormModel();
            if (person != null)
            {
                model.Id = person.Id;
                model.FirstName = person.FirstName;
                model.LastName = person.LastName;
                model.Gender = person.Gender;
                model.PhoneNumber = person.PhoneNumber;
                model.Email = person.Email;
                model.Street = person.Street;
                model.Option = person.Option;
                model.ZipCode = person.ZipCode;
                model.City = person.City;
                model.State = person.State;
                model.Country = person.Country;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, PersonFormModel model)
        {


            var person = _dataContext.Persons.FirstOrDefault(o => o.Id == id);

            if (person != null)
            {
                person.Id = model.Id;
                person.FirstName = model.FirstName;
                person.LastName = model.LastName;
                person.PhoneNumber = model.PhoneNumber;
                person.Gender = model.Gender;
                person.Email = model.Email;
                person.Street = model.Street;
                person.Option = model.Option;
                person.ZipCode = model.ZipCode;
                person.City = model.City;
                person.State = model.State;
                person.Country = model.Country;

                _dataContext.Entry(person).State = EntityState.Modified;
                person.Updated = DateTime.Now;
                _dataContext.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(model);
        }
        public ActionResult Delete(int id)
        {

            var person = _dataContext.Persons.FirstOrDefault(o => o.Id == id);

            var model = new PersonViewModel();
            if (person != null)
            {
                model.Id = person.Id;
                model.FirstName = person.FirstName;
                model.LastName = person.LastName;
                model.Gender = person.Gender;
                model.PhoneNumber = person.PhoneNumber;
                model.Email = person.Email;
                model.Street = person.Street;
                model.Option = person.Option;
                model.ZipCode = person.ZipCode;
                model.City = person.City;
                model.State = person.State;
                model.Country = person.Country;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id, PersonViewModel model)
        {


            var ret = _dataContext.Persons.FirstOrDefault(o => o.Id == id);

            if (ret != null)
            {


                _dataContext.Entry(ret).State = EntityState.Deleted;
                _dataContext.Persons.Remove(ret);
                _dataContext.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(model);
        }
       
    }
}
