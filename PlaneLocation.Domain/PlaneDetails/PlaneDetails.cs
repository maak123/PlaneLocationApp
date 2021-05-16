using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlaneLocation.Domain.PlaneDetails
{
    public class PlaneDetails
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public string Location { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateAndTime { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }
    }
}
