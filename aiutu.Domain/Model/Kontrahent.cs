using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Domain.Model
{
    public class Kontrahent
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string NIP { get; set; }
        public KontrahentDanaKontaktowa KontrahentDaneKontaktowe { get; set; }
        public virtual ICollection<DanaKontaktowa> DaneKontaktowe { get; set; }
        public virtual ICollection<Adres> Adresy { get; set; }
    }
}
