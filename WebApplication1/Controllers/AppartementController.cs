using Data;
using Domain.entity;
using GUI.Helpers;
using GUI.Models;
using Service;
using ServicePIdev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class AppartementController : Controller
    {


        RoomateContext db = new RoomateContext();
        AppartementModels db1 = new AppartementModels();
         
        IAppartementService service = null;
        public AppartementController()
        {
            service = new  AppartementService();


        }
        public ActionResult ajoutcordonnee(string lat)
        {
            Appartement app = new Appartement();

            app.lattitude = float.Parse(lat);



            return RedirectToAction("Index");
        }
        // GET: Appartement



        public ActionResult Index()
        {

            var film = service.GetAllAppartements();
            List<AppartementModels> fVM = new List<AppartementModels>();
            foreach (var item in film)
            {
                fVM.Add(
                    new AppartementModels
                    {
                        Description = item.Description
            });
        }
            return View(fVM);
        }
    

    

        // GET: Appartement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Appartement/Create
        public ActionResult Create()
        {
            var coll = new AppartementModels();
            List<string> lieux = new List<string> { "Single","Collocation" };



            coll.rentaltypes = lieux.ToSelectListItems2();


            return View(coll);
        }
        public ActionResult map()
        {
            return View();
        }

        // POST: Appartement/Create
        [HttpPost]
        public ActionResult Create(AppartementModels c1)
        {

            Appartement n = new Appartement()
            {
                RoomNumber = c1.RoomNumber,
                Islocated = false,
                rentaltype = c1.rentaltype,
                //date_publication = DateTime.Now,                
            adresseAppartement = new Adress
                {
                    CodePostal = c1.CodePostal,
                    Rue = c1.Rue,
                    Ville = c1.Ville
                },
                Description = c1.Description,
                Price = c1.Price,
            };
            co.Add(n);
            co.Commit();
            return RedirectToAction("Index");

        }

        // GET: Appartement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Appartement/Edit/5
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

        // GET: Appartement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Appartement/Delete/5
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
