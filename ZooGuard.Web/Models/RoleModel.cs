using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class RoleModel
    {
        public int? Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
    }
}
