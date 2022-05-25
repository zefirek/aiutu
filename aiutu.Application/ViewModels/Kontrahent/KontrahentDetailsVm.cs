using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Application.ViewModels.Kontrahent
{
    public class KontrahentDetailsVm
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string NIP { get; set; }
        public string Regon { get; set; }
        public string CEOFullName { get; set; }
        public string FirstLineOfKontaktInformation { get; set; }
        public List<AdresyForListVm> Adresy { get; set; }
        public List<DanaKontaktowaListVm> Emails { get; set; }
        public List<DanaKontaktowaListVm> PhoneNumbers { get; set; }

    }
}
