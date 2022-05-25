using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Domain.Model
{
    public class PojazdTag
    {
        public int PojazdId { get; set; }
        public Pojazd Pojazd { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
