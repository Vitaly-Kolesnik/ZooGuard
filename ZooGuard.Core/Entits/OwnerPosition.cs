﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGuard.Core.Entits
{
    public class OwnerPosition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
    }
}
