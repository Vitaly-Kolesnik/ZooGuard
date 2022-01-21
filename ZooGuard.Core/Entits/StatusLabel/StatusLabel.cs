using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGuard.Core.Entits.StatusLabel
{
    public class StatusLabel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }

        //One-to-One Relationship (StatusLabel - Storage)
        public int IdStorage { get; set; }
        public string NameStorage { get; set; }
    }
}
