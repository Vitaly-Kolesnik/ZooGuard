using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class UserViewModelService : IUserViewModelService
    {
        private readonly IUserService userService;
        private readonly IPasswordHasher passwordHasher;
        private readonly IRepository<Role> roleRepository;

        public UserViewModelService(IUserService userService, IPasswordHasher passwordHasher, IRepository<Role> roleRepository, IRepository<Member> memberRepository)
        {
            this.userService = userService;
            this.passwordHasher = passwordHasher;
            this.roleRepository = roleRepository;
        }

        public int Add(UserViewModel userViewModel)
        {
            return userService.Add(ConvertToModel(userViewModel));
        }

        public void Edit(UserViewModel user)
        {
            userService.Update(ConvertToModel(user));
        }

        public User GetUserById(int id)
        {
            var user = userService.Get(id);
            return user ?? null;
        }

        public UserViewModel GetModelById(int id)
        {
            var user = userService.Get(id);
            return user != null ? ConvertToViewModel(user) : null;
        }

        public UserViewModel GetEmpty()
        {
            return ConvertToViewModel(new User());
        }

        private User ConvertToModel(UserViewModel userViewModel)
        {
            var salt = passwordHasher.GenerateSalt();

            return new User
            {
                Id = userViewModel.Id.HasValue ? userViewModel.Id.Value : 0,
                Name = userViewModel.Name,
                Login = userViewModel.Login,
                LastName = userViewModel.LastName,
                Email = userViewModel.Email,
                Phone = userViewModel.Phone,
                Project = userViewModel.Project,
                Password = passwordHasher.Hash(userViewModel.Password, salt),
                Salt = salt,
                Members = userViewModel.RoleIds.Select(id => new Member { RoleId = id }).ToList()
            };
        }

        private UserViewModel ConvertToViewModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                Login = user.Login,
                Project = user.Project,
                Password = user.Password,
                Roles = roleRepository.List().Select(r => new SelectListItem(r.Name, r.Id.ToString(), user.Members?.Any(m => m.RoleId == r.Id) ?? false)).ToList()
            };
        }
    }
}
    

