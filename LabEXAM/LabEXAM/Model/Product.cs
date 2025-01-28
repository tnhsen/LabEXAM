using System;
using System.Collections.Generic;
using System.Text;

namespace LabEXAM.Model
{
    class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public Uri image { get; set; }
    }
}
