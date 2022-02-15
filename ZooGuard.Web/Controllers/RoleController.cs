using Microsoft.AspNetCore.Mvc;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService roleService;
        private readonly IRoleViewModelService roleViewModelService;

        public RoleController(IRoleViewModelService roleViewModelService, IRoleService roleService)
        {
            this.roleService = roleService;
            this.roleViewModelService = roleViewModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Role/All")]
        public IActionResult GetAllRolesInDataBase()
        {
            var role = roleService.GetAll();
            return View("Index", role);
        }

        [HttpGet("Role/AddRole/Form")]
        public IActionResult GetFormAddRole()
        {
            return View("AddRole");
        }
        [HttpPost("Role/AddRole")]
        public IActionResult AddRole(RoleViewModel role)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int? id = role.Id;

            if (id == null || id == 0)
            {
                id = roleViewModelService.Add(role);
            }
            else
            {
                return View();
            }
            return RedirectToAction("GetAllRolesInDataBase");
        }

        [HttpGet("Role/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var role = roleViewModelService.GetById(id);

            if (role == null)
            {
                return View();
            }
            return View("Delete", role);
        }

        [HttpPost("Role/Delete")]
        public IActionResult DeleteRole(int id)
        {
            roleService.Delete(id);

            return RedirectToAction("GetAllRolesInDataBase");
        }
    }
}
