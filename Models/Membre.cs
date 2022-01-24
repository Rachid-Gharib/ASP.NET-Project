using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Web_MVC_avec_fichier___CRUD.Models {
    public class Membre {
        public string Prenom { get; set;}           //Accessors, and there start with Capital letter
        public string Nom { get; set;}              //Accessors, and there start with Capital letter
        public string Courriel { get; set;}         //Accessors, and there start with Capital letter
        public string Telephone { get; set;}        //Accessors, and there start with Capital letter
        public string Commentaire { get; set;}      //Accessors, and there start with Capital letter
    }
}