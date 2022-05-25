using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Domain.Model
{
    public class PojazdRodzaj
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<Pojazd> Pojazdy { get; set; }

    }
}
