using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BP00.Scaffolding.Data;
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
                        Country = person.Country
                    });
                }  
            }
            return View(model);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
