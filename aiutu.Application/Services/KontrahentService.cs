using aiutu.Application.Interfaces;
using aiutu.Application.ViewModels.Kontrahent;
using aiutu.Domain.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aiutu.Application.Services
{
    public class KontrahentService : IKontrahentService
    {
        private readonly IKontrahentRepository _kontrahentRepo;
        private readonly IMapper _mapper;

        public KontrahentService(IKontrahentRepository kontrahentReop, IMapper mapper)
        {
            _kontrahentRepo = kontrahentReop;
            _mapper = mapper;
        }

        public int AddKontrahent(NewKontrahentVm kontrahent)
        {
            throw new NotImplementedException();
        }

        public ListKontrahentForListVm GetAllKontrahenciForList()
        {
            //var kontrahenci = _kontrahentRepo.GetAllActiveKontrahenci();
            //ListKontrahentForListVm result = new ListKontrahentForListVm();
            //result.Kontrahenci = new List<KontrahentForListVm>();
            //foreach(var kontrahent in kontrahenci)
            //{
            //    var custVm = new KontrahentForListVm()
            //    {
            //        Id = kontrahent.Id,
            //        Nazwa = kontrahent.Nazwa,
            //        NIP = kontrahent.NIP
            //    };
            //    result.Kontrahenci.Add(custVm);
            //}
            //result.Count = result.Kontrahenci.Count;
            //return result;

            // asp 8.6 18:40
            var kontrahenci = _kontrahentRepo.GetAllActiveKontrahenci()
                .ProjectTo<KontrahentForListVm>(_mapper.ConfigurationProvider).ToList();
            var kontrahentList = new ListKontrahentForListVm()
            {
                Kontrahenci = kontrahenci,
                Count = kontrahenci.Count
            };
            return kontrahentList;
        }

        public KontrahentDetailsVm GetKontrahentDetails(int kontrahentId)
        {
            //var kontrahent = _kontrahentRepo.GetKontrahent(kontrahentId);
            //var kontrahentVm = new KontrahentDetailsVm();
            //kontrahentVm.Id = kontrahent.Id;
            //kontrahentVm.Nazwa = kontrahent.Nazwa;
            //kontrahentVm.NIP = kontrahent.NIP;
            //kontrahentVm.Regon = kontrahent.Regon;
            //kontrahentVm.CEOFullName = kontrahent.CEOName + " " + kontrahent.CEOLastName;
            //var kontrKonInfo = kontrahent.KontrahentDaneKontaktowe;
            //kontrahentVm.FirstLineOfKontaktInformation = kontrKonInfo.Imie + " " + kontrKonInfo.Nazwisko;

            //kontrahentVm.Adresy = new List<AdresyForListVm>();
            //kontrahentVm.PhoneNumbers = new List<DanaKontaktowaListVm>();
            //kontrahentVm.Emails = new List<DanaKontaktowaListVm>();

            //// asp 8.5 => 22:22
            //foreach (var adresy in kontrahent.Adresy)
            //{
            //    var add = new AdresyForListVm()
            //    {
            //        Id = adresy.Id,
            //        Miasto = adresy.Miasto,
            //        Panstwo = adresy.Panstwo
            //    };
            //    kontrahentVm.Adresy.Add(add);
            //}
            //return kontrahentVm;

            //asp 8.6 23:00
            var kontrahent = _kontrahentRepo.GetKontrahent(kontrahentId);
            var kontrahentVm = _mapper.Map<KontrahentDetailsVm>(kontrahent);

            kontrahentVm.Adresy = new List<AdresyForListVm>();
            kontrahentVm.PhoneNumbers = new List<DanaKontaktowaListVm>();
            kontrahentVm.Emails = new List<DanaKontaktowaListVm>();

            // asp 8.5 => 22:22
            foreach (var adresy in kontrahent.Adresy)
            {
                var add = new AdresyForListVm()
                {
                    Id = adresy.Id,
                    Miasto = adresy.Miasto,
                    Panstwo = adresy.Panstwo
                };
                kontrahentVm.Adresy.Add(add);
            }
            return kontrahentVm;
        }
    }
}
