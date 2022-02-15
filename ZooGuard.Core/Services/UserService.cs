﻿using System;
using System.Collections;
using System.Collections.Generic;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class UserService : IUserService //Содержит бизнес логику для работы приложения
    {
        private readonly IRepository<User> userRepository; //репозиторий пользователей

        public UserService(IRepository<User> userRepository, IRepository<Role> roleRepository)
        {
            this.userRepository = userRepository; //получение доступа к репозиторию в базе данных
        }

        public int Add(User user) //бизнес логика - добавление Пользователя
        {
            userRepository.Add(user);

            return user.Id;
        }

        public User Get(int id) //вернуть пользователя по id
        {
            return userRepository.Get(id);
        }

        public User Get(string login)
        {
            return userRepository.Get(new UserByLoginSpecification(login));
        }

        public IList<User> GetAll()
        {
            return userRepository.List(new AllUserAndRoleSpecification());
        }
    }
}
