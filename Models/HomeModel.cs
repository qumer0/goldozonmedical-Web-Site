using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace goldozonmedical_Web_Site.Models
{
    public class SliderItem
    {
        [Key]
        public int id{ get; set; }
        public string ImageUrl { get; set; }
        public string Caption { get; set; }
    }
}
