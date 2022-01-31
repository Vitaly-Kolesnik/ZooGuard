using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGuard.Core.Entites.InfoAboutPos
{
    public abstract class _InformationAboutPosition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Position> Positions { get; set; }
    }
}

