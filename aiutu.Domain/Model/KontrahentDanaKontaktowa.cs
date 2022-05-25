using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Domain.Model
{
    // dane osób do kontaktu u klienta
    public class KontrahentDanaKontaktowa
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }

        public int KontrahentRef { get; set; }

        public Kontrahent Kontrahent { get; set; }

    }
}
