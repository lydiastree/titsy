using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekcik.Models;

namespace projekcik.Controllers
{
    public class ZupyController : Controller
    {
        public ActionResult Index(Zupa zupa)
        {
            List<Zupa> zupy = new List<Zupa>()
            {
                new Zupa("ZUPA Z SOCZEWICY Z ZIEMNIAKAMI I KURCZAKIEM","2 łyżki oliwy, \n 1 cebula, \n 1 marchewka, \n 2 litry bulionu,\n  1/2 szklanki \n czerwonej soczewicy, \n 3 ziemniaki, \n po 1/2 łyżeczki pieprzu,\n  kurkumy, papryki słodkiej i oregano, \n 1 pojedynczy filet z kurczaka, \n 2/3 szklanki przecieru pomidorowego","W garnku na oliwie zeszklić pokrojoną w kosteczkę cebulę. Dodać obraną i startą marchewkę i wymieszać, chwilę razem podsmażać. \n  Wlać bulion i zagotować. Dodać przepłukaną soczewicę oraz obrane i pokrojone w kostkę ziemniaki. Doprawić pieprzem, kurkumą, papryką i oregano oraz solą w razie potrzeby. Gotować przez ok. 3 minuty. \n  W gotującą się zupę włożyć pokrojoną w małą kosteczkę pierś kurczaka. Przykryć garnek i gotować przez ok. 8 minut. Wlać przecier pomidorowy i gotować jeszcze przez 3 - 5 minut. \n  Posypać zieleniną (np. szczypiorek, natka, koperek, rzeżucha) i podawać np. z pieczywem.", 4),
                new Zupa("ZUPA BROKUŁOWA Z GORGONZOLĄ I CHIPSAMI Z JARMUŻU","1 łyżka oliwy extra vergine,\n 1 por, \n 2 ziemniaki, \n 1 łyżka masła, \n 1 litr bulionu, \n 1 brokuł, \n 80 ml śmietanki 30%, \n 100 g sera gorgonzola (lub innego pleśniowego), \n szczypiorek","W szerokim garnku na oliwie poddusić pokrojonego pora (biała i jasnozielona część), ok. 4 minuty. \n Gdy por będzie już miękki dodać obrane i pokrojone w kosteczkę ziemniaki oraz masło i smażyć razem przez ok. 2 minuty. Doprawić solą i pieprzem. \n Wlać gorący bulion i zagotować. Przykryć i gotować przez ok. 10 minut. Dodać pokrojonego w kostkę brokuła i gotować pod przykryciem przez ok. 5 minut, do miękkości warzyw. \n Wlać śmietankę, dodać ok. 1/4 ilości gorgonzoli, przelać do kielicha blendera i zmiksować na krem. Podawać z resztą sera pokrojonego w kosteczkę, z chipsami jarmużowymi oraz szczypiorkiem.", 4)
            };
            if (zupa.Iloscporcji != 0)
            {
                zupy.Add(zupa);
            }
            return View(zupy);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Zupa zupa)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", zupa);
            }
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}