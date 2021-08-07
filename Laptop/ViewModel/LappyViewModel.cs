using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laptop.ViewModel
{
    public class LappyViewModel
    {
        public int Id { get; set; }
        public string LaptopName { get; set; }
        public int NumberOfPorts { get; set; }
        public string Processor { get; set; }
        public string GraphicCard { get; set; }
        public string RAM { get; set; }
        public string Memory { get; set; }
        public string Screen { get; set; }
        public int Price { get; set; }
    }
}
