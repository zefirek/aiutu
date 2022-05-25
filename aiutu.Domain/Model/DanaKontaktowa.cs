using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Domain.Model
{
    public class DanaKontaktowa
    {
        public int Id { get; set; }
        public string SzczegolyKontaktu { get; set; }
        public int SzczegolyKontaktuTypId { get; set; }
        public DanaKontaktowaTyp DanaKontaktowaTyp { get; set; }
        public int KontrahentId { get; set; }
        public Kontrahent Kontrahent { get; set; }
    }
}
