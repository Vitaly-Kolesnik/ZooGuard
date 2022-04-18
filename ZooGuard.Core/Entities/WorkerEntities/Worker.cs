using System.Collections.Generic;
using ZooGuard.Core.Entities.MultipleConnections;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Entities.StorageEntities;

namespace ZooGuard.Core.Entities.WorkerEntities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public bool IsResponsibilityStorage { get; set; }
        public bool IsResponsibilityServerRoom { get; set; }

        #region Many-to-Many (Worker - SpecialityWorker)
        public ICollection<SpecialitiesOfWorkers> SpecialitiesOfWorkers { get; set; }
        #endregion

        #region One-To-Many (Worker - Positions)
        public ICollection<Position> Positions { get; set; }
        #endregion

        #region One-to-One (Worker - Place)
        public Place Place { get; set; }
        #endregion

        #region One-To-Many (Worker - Storages)
        public ICollection<Storage> Storages { get; set; }
        #endregion

        #region Many-To-Many (Workers-Projects)
        public ICollection<WorkersInProject> WorkersInProjects { get; set; }
        #endregion

        #region One-To-Many (Worker - ServerRooms)
        public ICollection<ServerRoom> ServerRooms { get; set; }
        #endregion

        #region Many-To-Many (Worker-Company)
        public ICollection<WorkersInCompany> WorkersInCompanies { get; set; }
        #endregion

    }
}
