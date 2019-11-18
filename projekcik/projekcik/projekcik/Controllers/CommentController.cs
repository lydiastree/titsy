using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekcik.Models;

namespace projekcik.Controllers
{
    public class CommentController : Controller
    {
        public ActionResult Index(Comment c)
        {
            List<Comment> komentarze = new List<Comment>()
            {
                //new Danieglowne("SAKIEWKI Z KURCZAKA Z KASZĄ JAGLANĄ I POMIDORAMI","2 pojedyncze piersi kurczaka, \n 1/2 szklanki ugotowanej kaszy jaglanej, \n 60 g sera pleśniowego (użyłam owczego, może być kozi ewentualnie krowi), \n 1 pomidor, \n 1 gałązka szczypiorku","Piersi kurczaka opłukać, osuszyć, oczyścić z błonek i kostek. Zrobić z nich sakiewki: położyć na desce, każdą pierś przekroić pionowo lub na ukos na 2 połówki (otrzymamy 4 porcje kurczaka). W każdej połówce, od góry, zrobić pionowe nacięcie wzdłuż filetu, rozchylić boki kurczaka i poszerzyć nieco powstałą sakiewkę robiąc boczne nacięcia również w środku kieszonki (aby zmieściło się więcej nadzienia). Można też nie kroić filetu na pół tylko zrobić jedną większą sakiewkę z jednego filetu. \n Mięso doprawić z każdej strony solą, pieprzem, kurkumą, ostrą papryką, następnie polać oliwą, skropić niewielką ilością soku z cytryny, wymieszać, odłożyć na ok. 30 minut a najlepiej na godzinę jeśli mamy czas. \n Nadzienie: ugotowaną kaszę jaglaną doprawić solą, pieprzem, skropić oliwą, dodać 2 łyżki posiekanego szczypiorku, 1 / 2 łyżeczki kurkumy, 1 / 3 łyżeczki ostrej papryki oraz ser kozi pokrojony w kosteczkę, wymieszać i nałożyć do kieszeni kurczaka. Na wierzchu położyć plaster pomidora, doprawić go solą, pieprzem, suszonym oregano i skropić odrobiną miodu lub syropu klonowego i oliwą extra.Ułożyć na blaszce do pieczenia, wstawić do piekarnika nagrzanego do 180 stopni C, piec przez 25 minut(małe sakiewki) oraz ok. 30 minut(duże).Podawać np.z sałatką. \n Sałata z awokado i brukselką: sałatę umyć, poszarpać, włożyć do salaterki, wymieszać z poszarpaną bazylią, dodać obrane i pokrojone w kosteczkę awokado, skropione sokiem z cytryny.Dodać obrane listki brukselki doprawione solą i pieprzem, posypać szczypiorkiem i polać winegretem(2 łyżki oliwy +2 łyżki soku z cytryny +2 łyżki miodu lub syropu klonowego + 1 łyżeczka musztardy +sól i pieprz) i posypać makiem.", 4),
                //new Danieglowne("DUSZONE ŻEBERKA W SOSIE WŁASNYM Z WARZYWAMI","1 kg żeberek, \n sól i pieprz, \n 1 łyżeczka mielone słodkiej papryki, \n 1/3 łyżeczki mielonej ostrej papryki, \n 1/4 szklanki mąki, \n 2 łyżki oleju roślinnego (np. rzepakowego), \n 1 cebula, \n 1 ząbek czosnku, \n 2 marchewki, \n 1 pietruszka, \n 1 mały seler korzeniowy, \n opcjonalnie - 1/2 batata, \n 2 łyżki sosu sojowego, \n 3 - 4 szklanki wody","Żeberka, umyć, pokroić na kawałki z jedną kostką. Doprawić solą i pieprzem. W misce wymieszać mąkę z mieloną papryką, wkładać żeberka i dokładnie obtoczyć je w mieszance. \n Szeroki, duży garnek rozgrzać na średnim ogniu, wlać 1 i 1/2 łyżki oleju, rozprowadzić go po całym dnie. Gdy tłuszcz będzie gorący, włożyć żeberka i dokładnie zrumienić raz przewracając (w sumie ok. 8 minut). Obsmażone żeberka wyjąć na talerz. \n Do garnka wlać pozostałe 1/2 łyżki oleju, włożyć pokrojoną w kosteczkę cebulę i czosnek, smażyć mieszając przez ok. 3 minuty. Dodać obrane i pokrojone w grubsze plasterki marchewkę, pietruszkę, selera. Doprawić do smaku solą i pieprzem, wymieszać. \n Do warzyw włożyć żeberka, wlać sos sojowy i gorącą wodę(do zakrycia składników). Przykryć i gotować przez ok. 1 i 1 / 2 godziny do 2 godzin, aż mięso będzie miękkie i odchodzące od kości. Obranego i pokrojonego w większą kostkę batata dodajemy na ok. 30 minut przed końcem gotowania potrawy.Jeśli na koniec sos nie jest jeszcze gęsty, można potrawę jeszcze pogotować bez przykrycia.", 4)
            };
            if (c.Nazwa != null)
            {
                komentarze.Add(c);
            }
            return View(komentarze);
        }
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Comment c)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", c);
            }
            return View(c);
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}