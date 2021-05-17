using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneSpotApp.Models
{
    public class PlaneDetail
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public string Location { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateAndTime { get; set; }
     
    }
}
