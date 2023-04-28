using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Xalise.Web.Models;

namespace Xalise.Web.Controllers
{
    public class GEDController : XaliseMvcController
    {
        private readonly ILogger<GEDController> _logger;

        public GEDController(ILogger<GEDController> logger)
        {
            _logger = logger;
        }

        // Un utilitaire pour gérer les fichiers : stockage (avec renommage si existe déjà), récupération, suppression, ...

        // Une entité 'ThemeGED' et 'FichierGED'

        public IActionResult Index()
        {
            // Écriture générique JSON
            // Lecture générique JSON : List<Theme> et List<ThemeDTO>

            //List<Theme> themes = new List<Theme>();
            //themes.Add(new Theme() { ID = 1, Libelle = "Non classé", NumOrdre = 1, EstInterne = true, ParentID = null });
            //themes.Add(new Theme() { ID = 2, Libelle = "Test", NumOrdre = 2, EstInterne = false, ParentID = null });
            //themes.Add(new Theme() { ID = 3, Libelle = "Sous-thème", NumOrdre = 1, EstInterne = false, ParentID = 2 });
            //themes.Add(new Theme() { ID = 4, Libelle = "Sous-thème-2", NumOrdre = 2, EstInterne = false, ParentID = 2 });
            //JsonDB.WriteJsonFile<Theme>(JsonDB.CSTS_FILENAME_THEMES, themes);

            //IEnumerable<ThemeDTO> themes = JsonDB.ReadJsonFile<ThemeDTO>(JsonDB.CSTS_FILENAME_THEMES);

            this.InitViewDataPageTitle("GED");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}