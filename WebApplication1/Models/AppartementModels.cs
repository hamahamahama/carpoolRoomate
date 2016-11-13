using Domain.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Models
{
    public class AppartementModels
    {
        public string Ville { get; set; }
        public string Rue { get; set; }
        public int CodePostal { get; set; }

        public Boolean Islocated { get; set; }
        public int RoomNumber { get; set; }

        public DateTime date_publication { get; set; }
        public String Description { get; set; }
        public float Price { get; set; }
        public float longitude { get; set; }
        public float lattitude { get; set; }
        public IEnumerable<SelectListItem> rentaltypes { get; set; }
        public string rentaltype { get; set; }
        public virtual AppartementOwner appartementOwner { get; set; }

    }
}