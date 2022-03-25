using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    public class StatusLabelController : Controller
    {
        private readonly IPositionInformationService<StatusLabel> positionInformationService;
        private readonly IStatusViewModelService statusViewModelServise;

        public StatusLabelController(IStatusViewModelService statusViewModelServise, IPositionInformationService<StatusLabel> positionInformationService)
        {
            this.positionInformationService = positionInformationService;
            this.statusViewModelServise = statusViewModelServise;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("StatusLabel/All")]
        public async Task<IActionResult> GetAllLabelInDataBase()
        {
            var statusLabel = await positionInformationService.GetAllAsync();
            return View("Index", statusLabel);
        }

        [HttpGet("Status/AddStatus/Form")]
        public IActionResult GetFormAddStatus()
        {
            return View("AddStatus");
        }

        [HttpPost("Status/AddStatus")]
        public async Task<IActionResult> AddStatusLabel (StatusViewModel statusLabelPos)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = statusLabelPos.Id;

            if (id == null || id == 0)
            {
                _ = await statusViewModelServise.AddAsync(statusLabelPos);
            }
            else
            {
                return View();
            }

            return RedirectToAction("GetAllLabelInDataBase");
        }

        [HttpGet("Status/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var status = await statusViewModelServise.GetByIdAsync(id);

            if (status == null)
            {
                return View();
            }
            return View("Delete", status);
        }

        [HttpPost("Status/DeleteStatus")]
        public async Task<IActionResult> DeleteStatus(int id)
        {
            await positionInformationService.DeleteAsync(id);

            return RedirectToAction("GetAllLabelInDataBase");
        }
    }
}
