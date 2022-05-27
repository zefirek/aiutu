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

        //asp 8.7 05:57
        public IQueryable<Kontrahent> GetAllActiveKontrahenci()
        {
            return _context.Kontrahenci.Where(p => p.IsActive); ;
        }

        public Kontrahent GetKontrahent(int kontrahentId)
        {
            return _context.Kontrahenci.FirstOrDefault(p => p.Id == kontrahentId);
        }
    }
}
