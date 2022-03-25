using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    public class FormOfOccurenceController : Controller
    {
        private readonly IPositionInformationService<FormOfOccurence> positionInformationService;
        private readonly IOccurenceViewModelService occurenceViewModelService;

        public FormOfOccurenceController(IPositionInformationService<FormOfOccurence> positionInformationService, IOccurenceViewModelService occurenceViewModelService)
        {
            this.positionInformationService = positionInformationService;
            this.occurenceViewModelService = occurenceViewModelService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("TypesOfProperty/All")]
        public async Task<IActionResult> GetAllOccurenceInDataBase()
        {
            var occurence = await positionInformationService.GetAllAsync();
            return View("Index", occurence);
        }

        [HttpGet("Types_of_property/AddType/Form")]
        public IActionResult GetFormOccurence()
        {
            return View("AddOccurence");
        }

        [HttpPost("Types_of_property/AddType")]
        public async Task<IActionResult> AddOccurence(OccurenceViewModel occurence)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = occurence.Id;

            if (id == null || id == 0)
            {
               await occurenceViewModelService.AddAsync(occurence);
            }
            else
            {
                return View();
            }
            return RedirectToAction("GetAllOccurenceInDataBase");
        }

        [HttpGet("TypesOfProperty/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var occurence = await occurenceViewModelService.GetByIdAsync(id);

            if (occurence == null)
            {
                return View();
            }
            return View("Delete", occurence);
        }

        [HttpPost("Types_of_property/Delete")]
        public async Task<IActionResult> DeleteTypeAsync(int id)
        {
            await occurenceViewModelService.DeleteByIdAsync(id);

            return RedirectToAction("GetAllOccurenceInDataBase");
        }
    }
}
