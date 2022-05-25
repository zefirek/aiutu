using aiutu.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aiutu.Domain.Interfaces
{
    public interface IPojazdRepository
    {
        void DeletePojazd(int pojazadId);
        int AddPojazd(Pojazd pojazd);
        IQueryable<Pojazd> GetPojazdyByPojazdRodzajId(int pojazdRodzajId);
        Pojazd GetPojazdById(int pojazdId);
        IQueryable<Tag> GetAllTags();
        IQueryable<PojazdRodzaj> GetAllPojazdRodzaje();
    }
}
