using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Domain.Model
{
    public class Pojazd
    {
        public int Id { get; set; }
        public string NumerRejestracyjny { get; set; }
        public string ModelPojazdu { get; set; }
        public int PojazdRodzajId{ get; set; }
        public bool CzyJestWydawka { get; set; }
        public int WlascicielId { get; set; }

        public virtual PojazdRodzaj PojazdRodzaj { get; set; }  // Type

        public virtual Wlasciciel Wlsciciel { get; set; }

        public ICollection<PojazdTag> PojazdTags { get; set; }


    }
}
