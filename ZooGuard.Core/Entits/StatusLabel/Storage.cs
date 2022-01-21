using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGuard.Core.Entits.StatusLabel
{
    public class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StatusLabel StatusLabel { get; set; }
    }
}
