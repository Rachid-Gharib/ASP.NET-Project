using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projet_Web_MVC_avec_fichier___CRUD.Models;

namespace Projet_Web_MVC_avec_fichier___CRUD.Controllers
{
    public class MembresController : Controller
    {
        // GET: Membres
        public ActionResult Index()
        {
            return View();
        }

        // GET: Membres/Details/5
        public ActionResult Listes(int id)
        {
            return View();
        }

        // GET: Membres/Details/5
        public ActionResult ListerTout() {

            string ligne;

            string[] attributs; 
            char delimiteur = ';';

            var listeMembres = new List<Membre>();
            if(System.IO.File.Exists(Server.MapPath(@"~/Content/donnees/membres.txt"))) {

                //Lecture ligne par ligne
                System.IO.StreamReader fichMembres = new System.IO.StreamReader(Server.MapPath(@"~/Content/donnees/membres.txt"));
                while((ligne = fichMembres.ReadLine()) != null) {
                    attributs = ligne.Split(delimiteur);
                    Membre UnMembre = new Membre() { Prenom = attributs[0],Nom = attributs[1],Courriel = attributs[2],Commentaire = attributs[3] };
                    listeMembres.Add(UnMembre);
                }

                fichMembres.Close(); // we have to close the file with method Close() cuz we are not using the keyword "using"
            }



            return View(listeMembres);
        }

        // GET: Membres/Create
        public ActionResult Ajouter()
        {
            return View();
        }

        // POST: Membres/Create
        [HttpPost]
        public ActionResult Enregistrer(FormCollection collection)
        {
            int taille = collection.Count;
            string ligne = "";
            try
            {
                using (StreamWriter fichMembres = // the keyword ussing deconstruct the buffer automatically when the program is out of its scope
                new StreamWriter(Server.MapPath(@"~/Content/donnees/membres.txt"),true)) { // true helps to append infos instead of recreating the txt file every time!!

                    ligne += Convert.ToString(collection["prenom"]) + ";";
                    ligne += Convert.ToString(collection["nom"]) + ";";
                    ligne += Convert.ToString(collection["courriel"]) + ";";
                    ligne += Convert.ToString(collection["telephone"]) + ";";
                    ligne += Convert.ToString(collection["commentaire"]);
                     fichMembres.WriteLine(ligne);

                }


                return RedirectToAction("Index");
                // return Content (taille.ToString()); for debugging => it return a page with the number of string elem. 
                // return Content(ligne); returns a line as an exmpl 
            } 
            catch
            {
                return View(); // we could include an error message => exmpl; saying the page is not loading as expected
            }
        }

        // GET: Membres/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Membres/Edit/5
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

        // GET: Membres/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Membres/Delete/5
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
