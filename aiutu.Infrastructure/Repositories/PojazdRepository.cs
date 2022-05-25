using aiutu.Domain.Interfaces;
using aiutu.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aiutu.Infrastructure.Repositories
{
    public class PojazdRepository : IPojazdRepository
    {
        private readonly Context _context;
        public PojazdRepository(Context context)
        {
            _context = context;
        }

        public void DeletePojazd(int pojazadId)
        {
            var item = _context.Pojazdy.Find(pojazadId);
            if (item != null)
            {
                _context.Pojazdy.Remove(item);
                _context.SaveChanges();
            }
        }

        public int AddPojazd(Pojazd pojazd)
        {
            _context.Pojazdy.Add(pojazd);
            _context.SaveChanges();
            return pojazd.Id;
        }

        public IQueryable<Pojazd> GetPojazdyByPojazdRodzajId(int pojazdRodzajId)
        {
            var pojazdy = _context.Pojazdy.Where(i => i.PojazdRodzajId == pojazdRodzajId);
            return pojazdy;
        }

        public Pojazd GetPojazdById(int pojazdId)
        {
            var pojazd = _context.Pojazdy.FirstOrDefault(i => i.Id == pojazdId);
            return pojazd;
        }

        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tagi;
            return tags;
        }

        public IQueryable<PojazdRodzaj> GetAllPojazdRodzaje()
        {
            var pojazdrodzaje = _context.PojazdRodzaje;
            return pojazdrodzaje;
        }

    }
}
