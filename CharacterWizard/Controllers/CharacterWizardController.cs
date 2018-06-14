using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharacterWizard.Models;
using CharacterWizardRepository;
using CharacterWizardRepository.Models;

namespace CharacterWizard.Controllers
{
    public class CharacterWizardController : Controller
    {
        CharWizRepo _repo = new CharWizRepo();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetPlayers()
        {
            return new JsonResult(_repo.GetPlayers());
        }

        [HttpPost]
        public IActionResult GetPlayerCharacters([FromBody]int playerId)
        {
            return new JsonResult(_repo.GetPlayerCharacterList(playerId));
        }
        public IActionResult GetNewCharacter()
        {
            return new JsonResult(new CharacterSheetVm());
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
