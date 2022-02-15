using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Services;
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
        public IActionResult GetAllLabelInDataBase()
        {
            var statusLabel = positionInformationService.GetAll();
            return View("Index", statusLabel);
        }

        [HttpGet("Status/AddStatus/Form")]
        public IActionResult GetFormAddStatus()
        {
            return View("AddStatus");
        }
        [HttpPost("Status/AddStatus")]
        public IActionResult AddStatusLabel (StatusViewModel statusLabelPos)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = statusLabelPos.Id;

            if (id == null || id == 0)
            {
                id = statusViewModelServise.Add(statusLabelPos);
            }
            else
            {
                return View();
            }

            return RedirectToAction("GetAllLabelInDataBase");
        }

        [HttpGet("Status/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var status = statusViewModelServise.GetById(id);

            if (status == null)
            {
                return View();
            }
            return View("Delete", status);
        }

        [HttpPost("Status/DeleteStatus")]
        public IActionResult DeleteStatus(int id)
        {
            positionInformationService.Delete(id);

            return RedirectToAction("GetAllLabelInDataBase");
        }
    }
}
