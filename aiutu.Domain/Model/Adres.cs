using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Domain.Model
{
    public class Adres
    {
        // rozbudować o tabele państw, miast ...
        public int Id { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string NumerLokalu { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public string Panstwo { get; set; }
        public int KontrahentId { get; set; }
        public virtual Kontrahent Kontrahent { get; set; }
    }
}
