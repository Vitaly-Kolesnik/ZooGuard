using Microsoft.AspNetCore.Mvc;
using System;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;

namespace ZooGuard.Web.Controllers
{
    public class PositionController : Controller
    {
        //private readonly IPositionViewModelService positionViewModelService;
        private readonly IPositionService positionService;

        public PositionController(IPositionService positionService)
        {
            this.positionService = positionService;
            //this.positionViewModelService = positionViewModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllPositionsInDataBase () //наименование метода должно совыпадать с Title во View
        {
            var allPositions = positionService.GetAll();
            
            return View("Index", allPositions); //Возвращает View c наименование Index и Title - GetAllPositionInDataBase
        }
    }
}
