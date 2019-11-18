using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekcik.Models
{
    [Table("Dania główne")]
    public class Danieglowne
    {
        [Required]
        [Key]
        [Display(Name = "Nazwa")]
        public string Nazwa { get; set; }
        [Required]
        [Display(Name = "Składniki")]
        public string Skladniki { get; set; }
        [Required]
        [Display(Name = "Sposób wykonania")]
        public string Wykonanie { get; set; }
        [Required]
        [Display(Name = "Liczba porcji")]
        public int Iloscporcji { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public Danieglowne()
        {

        }

        public Danieglowne(string nazwa, string skl, string wyk, int porcje)
        {
            Nazwa = nazwa;
            Skladniki = skl;
            Wykonanie = wyk;
            Iloscporcji = porcje;
        }
 
    }
}