﻿using aiutu.Application.ViewModels.Kontrahent;
using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Application.Interfaces
{
    public interface IKontrahentService
    {
        ListKontrahentForListVm GetAllKontrahenciForList();
        int AddKontrahent(NewKontrahentVm kontrahent);
        KontrahentDetailsVm GetKontrahentDetails(int kontrahentId);



    }
}