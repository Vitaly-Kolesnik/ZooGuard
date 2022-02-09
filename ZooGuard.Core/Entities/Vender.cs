﻿
using System.Collections.Generic;

namespace ZooGuard.Core.Entities
{
    public class Vender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstNameRepresentative { get; set; }
        public string LastNameRepresentative { get; set; }
        public string PhoneRepresentative { get; set; }
        public string EmailRepresentative { get; set; }
        public ICollection<Position> Positions { get; set; }

    }
}
