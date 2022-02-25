using System.Collections.Generic;

namespace ZooGuard.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Project { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public ICollection<Member> Members { get; set; }
        public ICollection<Position> Positions { get; set; } 
    }
}
