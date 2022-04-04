﻿using System.Collections.Generic;
using ZooGuard.Core.Entities.BaseEntities;

namespace ZooGuard.Core.Entities
{
    public class Storage : BaseStorageEntitties
    {
        #region One-to-Many (Storage - Positions )
        public ICollection<Position> Positions { get; set; }
        #endregion
    }
}
