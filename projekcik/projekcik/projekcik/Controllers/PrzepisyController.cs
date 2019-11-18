using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekcik.Models;

namespace projekcik.Controllers
{
    public class PrzepisyController : Controller
    {
        public ActionResult Index(Przepis przepis)
        {
            List<Przepis> przepisy = new List<Przepis>()
            {
                new Przepis("CIASTO MICHAŁEK","6 jajek (ogrzane), \n 3/4 szklanki cukru, \n1 szklanka mąki pszennej, \n 3 łyżki kakao, \n 1 łyżeczka proszku do pieczenia, \n 1 / 2 łyżeczki sody, \n 1 / 2 szklanki oleju, \n do nasączenia: 1 / 2 szklanki zaparzonej kawy +1 / 3 szklanki likieru lub innego alkoholu","Ogrzane jajka ubić z cukrem na puszystą i jasną masę (ok. 10 minut). W oddzielnej misce wymieszać mąkę z kakao, proszkiem do pieczenia i sodą. Przesiać przez sitko bezpośrednio do masy. Wlać olej i całość delikatnie zmiksować na jednolitą masę. \n Wyłożyć do formy o wymiarach ok. 22 x 33 cm wyścielonej papierem do pieczenia i wstawić do piekarnika nagrzanego do 180 stopni C.Piec do suchego patyczka przez ok. 20 minut.Wyjąć i ostudzić, następnie przekroić poziomo na 2 blaty.", 400),
                new Przepis("ŚWIĄTECZNE CIASTO MARCHEWKOWE","2 jajka,  \n 200 g cukru, \n 150 ml oleju roślinnego, \n 200 g marchewki, \n 50 g orzechów włoskich lub pekan, \n 1 pomarańcza, \n 50 g wiórków kokosowych, \n 200 g mąki, \n 1/2 łyżeczki proszku do pieczenia, \n 1 i 1 / 2 łyżeczki sody oczyszczonej, \n 2 łyżeczki przyprawy piernikowej","Jajka ocieplić w temperaturze pokojowej. Ubić je do podwojenia objętości, następnie stopniowo dodawać po łyżce cukier, cały czas ubijając, w sumie przez ok. 10 minut. \n Wciąż ubijając na wysokich obrotach miksera, dolewać ciągłym i cieniutkim strumieniem olej (można go wcześniej delikatnie podgrzać). \n Dodać obraną i drobno startą marchewkę, drobno startą skórkę z pomarańczy, obraną z reszty skórki pomarańczę pokrojoną w małą kosteczkę, posiekane orzechy, wiórki kokosowe i wszystko delikatnie wymieszać. Piekarnik nagrzać do 150 stopni C. \n Do osobnej miski przesiać mąkę, dodać proszek do pieczenia, sodę, przyprawę piernikową i szczyptę soli, dokładnie wymieszać. Przesypać do miski z marchewką i delikatnie wymieszać łyżką wszystkie składniki. \n Ciasto wyłożyć do formy o średnicy ok. 22 - 24 cm wyłożonej papierem do pieczenia.Piec przez 1 godzinę lub do suchego patyczka.", 350)
            };
            if (przepis.Kalorie != 0)
            {
                przepisy.Add(przepis);
            }
            return View(przepisy);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Przepis przepis)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", przepis);
            }
            return View(przepis);
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}