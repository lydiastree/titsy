using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace projekcik.Models
{
    public class Przepis
    {
        [Required]
        [Display(Name = "Nazwa")]
        public string Nazwa { get; set; }
        [Required]
        [Display(Name = "Składniki")]
        public string Skladniki { get; set; }
        [Required]
        [Display(Name = "Sposób wykonania")]
        public string Wykonanie { get; set; }
        [Required]
        [Display(Name = "Kalorie")]
        public int Kalorie { get; set; }

        public Przepis()
        {

        }

        public Przepis(string nazwa, string skl, string wyk, int kal)
        {
            Nazwa = nazwa;
            Skladniki = skl;
            Wykonanie = wyk;
            Kalorie = kal;
        }
    }
}