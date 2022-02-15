using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    public class FormOfOccurenceController : Controller
    {
        private readonly IPositionInformationService<FormOfOccurence> positionInformationService;
        private readonly IOccurenceViewModelService occurenceViewModelServise;

        public FormOfOccurenceController(IPositionInformationService<FormOfOccurence> positionInformationService, IOccurenceViewModelService occurenceViewModelServise)
        {
            this.positionInformationService = positionInformationService;
            this.occurenceViewModelServise = occurenceViewModelServise;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("TypesOfProperty/All")]
        public IActionResult GetAllOccurenceInDataBase()
        {
            var occurence = positionInformationService.GetAll();
            return View("Index", occurence);
        }

        [HttpGet("Types_of_property/AddType/Form")]
        public IActionResult GetFormOccurence()
        {
            return View("AddOccurence");
        }

        [HttpPost("Types_of_property/AddType")]
        public IActionResult AddOccurence(OccurenceViewModel occurence)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = occurence.Id;

            if (id == null || id == 0)
            {
                id = occurenceViewModelServise.Add(occurence);
            }
            else
            {
                return View();
            }
            return RedirectToAction("GetAllOccurenceInDataBase");
        }

        [HttpGet("TypesOfProperty/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var occurence = occurenceViewModelServise.GetById(id);

            if (occurence == null)
            {
                return View();
            }
            return View("Delete", occurence);
        }

        [HttpPost("Types_of_property/Delete")]
        public IActionResult DeleteType(int id)
        {
            positionInformationService.Delete(id);

            return RedirectToAction("GetAllOccurenceInDataBase");
        }
    }
}
