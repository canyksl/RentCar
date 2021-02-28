using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarImageDto:IDto
    {
        public string CarName{ get; set; }
        public string CarImage { get; set; }
    }
}
