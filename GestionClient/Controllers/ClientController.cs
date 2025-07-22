using GestionClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionClient.Controllers
{
    public class ClientController : Controller
    {
        // Pour stocker temporairement la liste (en vrai projet: utiliser une base de données)
        public static List<Client> Clients = new List<Client>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Client client)
        {
            Clients.Add(client);
            return View("Save", client); // Affiche les infos du client ajouté
        }

        // Pour voir la liste complète
        public IActionResult Liste()
        {
            return View(Clients);
        }
    }
}