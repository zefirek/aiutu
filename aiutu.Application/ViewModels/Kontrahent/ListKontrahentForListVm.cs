using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Application.ViewModels.Kontrahent
{
    public class ListKontrahentForListVm
    {
        public List<KontrahentForListVm> Kontrahenci { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public int Count { get; set; }
    }
}
