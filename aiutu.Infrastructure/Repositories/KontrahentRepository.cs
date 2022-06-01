using aiutu.Domain.Interfaces;
using aiutu.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aiutu.Infrastructure.Repositories
{
    public class KontrahentRepository : IKontrahentRepository
    {
        // asp 8.8 2:30
        private readonly Context _context;
        public KontrahentRepository(Context context)
        {
            _context = context;
        }

        public int AddKontrahent(Kontrahent kontrahent)
        {
            _context.Kontrahenci.Add(kontrahent);
            _context.SaveChanges();
            return kontrahent.Id;
        }

        //asp 8.7 05:57
        public IQueryable<Kontrahent> GetAllActiveKontrahenci()
        {
            return _context.Kontrahenci.Where(p => p.IsActive); ;
        }

        public Kontrahent GetKontrahent(int kontrahentId)
        {
            return _context.Kontrahenci.FirstOrDefault(p => p.Id == kontrahentId);
        }

        public void UpdateKontrahent(Kontrahent kontrahent)
        {
            // asp 8.14 8:35
            _context.Attach(kontrahent);
            _context.Entry(kontrahent).Property("Nazwa").IsModified = true;
            _context.Entry(kontrahent).Property("NIP").IsModified = true;
            _context.Entry(kontrahent).Property("Regon").IsModified = true;
            _context.SaveChanges();
        }

        public void DeleteKontrahent(int id)
        {
            // asp 8.15 3:00
            var kontrahent = _context.Kontrahenci.Find(id);
            if (kontrahent!=null)
            {
                _context.Kontrahenci.Remove(kontrahent);
                _context.SaveChanges();
            }
        }

    }
}
