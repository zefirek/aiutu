using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Domain.Model
{
    public class Wlasciciel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Pojazd> Pojazdy { get; set; }

    }
}
