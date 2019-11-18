using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace projekcik.Models
{
    public class Zupa
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
        [Display(Name = "Ilość porcji")]
        public int Iloscporcji { get; set; }

        public Zupa()
        {

        }

        public Zupa(string rodz, string skl, string wyk, int porcje)
        {
            Nazwa = rodz;
            Skladniki = skl;
            Wykonanie = wyk;
            Iloscporcji = porcje;
        }
    }
}