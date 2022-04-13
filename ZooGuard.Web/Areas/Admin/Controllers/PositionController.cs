using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Enum;
using ZooGuard.Core.Interfaces.ForPosition;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionViewModelService positionViewModelService;
        private readonly IPositionService positionService;

        public PositionController(IPositionService positionService, IPositionViewModelService positionViewModelService)
        {
            this.positionService = positionService;
            this.positionViewModelService = positionViewModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Position/All")]
        public async Task<IActionResult> GetAllPositionsInDataBase()
        {
            var allPositions = await positionService.GetAllAsync();

            return View("Index", allPositions);
        }

        [HttpGet("Position/AddPosition/Form")]
        public IActionResult GetFormAddPosition()
        {
            var model = positionViewModelService.GetEmpty();
            return View("AddPosition", model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPosition(PositionViewModel position)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = position.Id;

            if (id == null || id == 0)
            {
                _ = await positionViewModelService.AddAsync(position);
            }
            else
            {
               await positionViewModelService.EditAsync(position);
            }

            return RedirectToAction("GetAllPositionsInDataBase");
        }

        [HttpGet("Position/Profile/{id}")]
        public async Task<IActionResult> GetProfileVenderById(int id)
        {
            var position = await positionViewModelService.GetPositionByIdAsync(id);

            return View("Profile", position);
        }

        [HttpGet("Position/Edit/{id}")]
        public async Task<IActionResult> EditPositionById(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var position = await positionViewModelService.GetModelByIdAsync(id);

            return View("EditPosition", position);
        }

        [HttpGet("Position/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var position = await positionViewModelService.GetModelByIdAsync(id);

            if (position == null)
            {
                return View();
            }

            return View("Delete", position);
        }

        [HttpPost("Position/Delete")]
        public async Task<IActionResult> DeletePosition(int id)
        {
           _= await positionViewModelService.DeleteAsync(id);

            return RedirectToAction("GetAllPositionsInDataBase");
        }

        [HttpGet("Position/byParam")]
        public async Task<IActionResult> GetPositionsAtInformTabById(int id, InformTab informTab)
        {
            var positions = await positionService.GetPosAtInformTabAsync(id, informTab);

            return View("Index", positions);
        }
    }
}
