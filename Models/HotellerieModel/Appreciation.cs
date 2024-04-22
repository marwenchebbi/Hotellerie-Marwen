using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using VotreApplication.Models;
using VotreApplication.Models.HotellerieModel;

namespace VotreApplication.Models.HotellerieModel
{
    public class Appreciation
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de la personne est obligatoire")]
        [Display(Name = "Nom Personne")]
        public string? NomPers { get; set; }

        [Required(ErrorMessage = "Le commentaire est obligatoire")]
        [DataType(DataType.MultilineText)]
        public string? Commentaire { get; set; }

        public int HotelId { get; set; }

        public  virtual Hotel? Hotel { get; set; }

        [Required(ErrorMessage = "La note est obligatoire")]
        [Range(1, 5, ErrorMessage = "La note doit être comprise entre 1 et 5")]
        public int Note { get; set; }

       


    }
}
