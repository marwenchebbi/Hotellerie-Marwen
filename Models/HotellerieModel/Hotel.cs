using VotreApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace VotreApplication.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de l'hôtel est obligatoire")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le nom doit comporter entre 3 et 20 caractères")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "Le nombre d'étoiles est obligatoire")]
        [Range(1, 5, ErrorMessage = "Le nombre d'étoiles doit être compris entre 1 et 5")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire")]
        public string? Ville { get; set; }

        [Required(ErrorMessage = "Le site web est obligatoire")]
        [Url(ErrorMessage = "Le site web doit être une URL valide")]
        [Display(Name ="Site Web")]
        public string? SiteWeb { get; set; }

        
        [Required(ErrorMessage = "Le numero de l'hôtel est obligatoire")]
        [StringLength(8, ErrorMessage = "Le nom doit comporter entre 3 et 20 caractères")]
        public string? Tel { get; set; }

        public string? Pays { get; set; }


        public virtual ICollection<Appreciation>? Appreciations { get; set; }


    }
}
