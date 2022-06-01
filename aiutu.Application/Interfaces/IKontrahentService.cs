using aiutu.Application.ViewModels.Kontrahent;
using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Application.Interfaces
{
    public interface IKontrahentService
    {
        ListKontrahentForListVm GetAllKontrahenciForList(int pageSize, int pageNo, string searchString);
        int AddKontrahent(NewKontrahentVm kontrahent);
        KontrahentDetailsVm GetKontrahentDetails(int kontrahentId);
        NewKontrahentVm GetKontrahentForEdit(int id);
        void UpdateKontrahent(NewKontrahentVm model);
        void DeleteKontrahent(int id);
    }
}
