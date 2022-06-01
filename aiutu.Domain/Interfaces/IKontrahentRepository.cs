using aiutu.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aiutu.Domain.Interfaces
{
    public interface IKontrahentRepository
    {
        IQueryable<Kontrahent> GetAllActiveKontrahenci();
        Kontrahent GetKontrahent(int kontrahentId);
        int AddKontrahent(Kontrahent kontrahent);
        void UpdateKontrahent(Kontrahent kontrahent);
        void DeleteKontrahent(int id);
    }
}
