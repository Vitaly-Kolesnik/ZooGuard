using Microsoft.AspNetCore.Mvc;
using System;
using ZooGuard.Core.Enum;
using ZooGuard.Core.Interfaces;
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
        public IActionResult GetAllPositionsInDataBase() //наименование метода должно совыпадать с Title во View
        {
            var allPositions = positionService.GetAll();

            return View("Index", allPositions); //Возвращает View c наименование Index и Title - GetAllPositionInDataBase
        }

        [HttpGet("Position/AddPosition/Form")]
        public IActionResult GetFormAddPosition()
        {
            var model = positionViewModelService.GetEmpty();
            return View("AddPosition", model);
        }

        [HttpPost]
        public IActionResult AddPosition(PositionViewModel position)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = position.Id;

            if (id == null || id == 0)
            {
                id = positionViewModelService.Add(position);
            }
            else
            {
                positionViewModelService.Edit(position);
            }

            return RedirectToAction("GetAllPositionsInDataBase");
        }

        [HttpGet("Position/Profile/{id}")]
        public IActionResult GetProfileVenderById(int id)
        {
            var position = positionViewModelService.GetPositionById(id);

            return View("Profile", position);
        }

        [HttpGet("Position/Edit/{id}")]
        public IActionResult EditPositionById(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var position = positionViewModelService.GetModelById(id);

            return View("EditPosition", position);
        }

        [HttpGet("Position/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var position = positionViewModelService.GetModelById(id);

            if (position == null)
            {
                return View();
            }

            return View("Delete", position);
        }

        [HttpPost("Position/Delete")]
        public IActionResult DeletePosition(int id)
        {
            positionService.Delete(id);

            return RedirectToAction("GetAllPositionsInDataBase");
        }

        [HttpGet("Position/By/Storage/{id}")]
        public IActionResult GetPositionsAtStorageById(int id)
        {
            var positions = positionService.GetPosAtStorage(id);

            return View("Index", positions);
        }

        [HttpGet("Position/By/Vender/{id}")]
        public IActionResult GetPositionsAtVenderById(int id)
        {
            var positions = positionService.GetPosAtVender(id);

            return View("Index", positions);
        }

        [HttpGet("Position/By/{CategoryTab}/{id}")]
        public IActionResult GetPositionsAtUserById(int id, int enumNumber)
        {
            //var positions = positionService.GetPosAtUser(id, tab);

            return View("Index");
        }
    }
}
