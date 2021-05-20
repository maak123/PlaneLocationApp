using System;
using System.Collections.Generic;
using System.Text;

namespace PlaneLocation.Domain.Resources
{
    public class PlaneDetailsResource
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public string Location { get; set; }
        public DateTime DateAndTime { get; set; }
        public string ImagePath { get; set; }
    }
}
