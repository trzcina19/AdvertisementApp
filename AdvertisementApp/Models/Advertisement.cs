using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisementApp.Models
{
    public class Advertisement
    {
        [Key]
        public int AdvertisementId { get; set; }
        [Required]
        public string AdvertisementTitle { get; set; }
        [Required]
        public int AdvertisementPrice { get; set; }
        [Required]
        public int AdvertisementContactNumber { get; set; }
        [Required]
        public string AdvertisementLocation { get; set; }
    }
}
