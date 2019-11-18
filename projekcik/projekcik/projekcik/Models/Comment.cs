using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekcik.Models
{
    [Table ("Comments")]
    public class Comment
    {
        [Key]
        public string DanieID { get; set; }
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        public string Nazwa { get; set; }
        [Required]
        [Display(Name = "Komentarz")]
        public string Komentarz { get; set; }
        public virtual Danieglowne Dania { get; set; }

        public Comment()
        {

        }

        public Comment(string nazwa, string kom)
        {
            Nazwa = nazwa;
            Komentarz = kom;
        }
    }
}