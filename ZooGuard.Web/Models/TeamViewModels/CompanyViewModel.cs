using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class CompanyViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Display(Name = "Ogr form")]
        [Required, MaxLength(5)]
        public string OrgForm { get; set; }

        [Display(Name = "Name Vender" )]
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "UNP")]
        [Required]
        public int UNP { get; set; }

        [Display(Name = "Adress")]
        [Required, MaxLength(512)]
        public string Adress { get; set; }

        /*
        [Display(Name = "Worker")]
        public int[] WorkerIds { get; set; }
        public IEnumerable<SelectListItem> Workers { get; set; }

        [Display(Name = "Projects")]
        public int[] ProjectIds { get; set; }
        public IEnumerable<SelectListItem> Projects { get; set; }

        [Display(Name = "Positions")]
        public int[] PositionIds { get; set; }
        public IEnumerable<SelectListItem> Positions { get; set; }

        [Display(Name = "Places")]
        public int[] PlaceIds { get; set; }
        public IEnumerable<SelectListItem> Places { get; set; }

        [Display(Name = "Storagies")]
        public int[] StorageIds { get; set; }
        public IEnumerable<SelectListItem> Storagies { get; set; }

        [Display(Name = "Server Rooms")]
        public int[] ServerRoomIds { get; set; }
        public IEnumerable<SelectListItem> ServerRooms { get; set; } */
    }
}
