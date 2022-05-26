using aiutu.Application.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Application.ViewModels.Kontrahent
{
    public class KontrahentDetailsVm : IMapFrom<aiutu.Domain.Model.Kontrahent>
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

        public void Mapping(Profile profile)
        {
            //profile.CreateMap<aiutu.Domain.Model.Kontrahent, KontrahentForListVm>()
            //    .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
            //    .ForMember(d => d.Nazwa, opt => opt.MapFrom(s => s.Nazwa))
            //    .ForMember(d => d.NIP, opt => opt.MapFrom(s => s.NIP));

            profile.CreateMap<aiutu.Domain.Model.Kontrahent, KontrahentDetailsVm>()
                .ForMember(s => s.CEOFullName, opt => opt.MapFrom(d => d.CEOName + " " + d.CEOLastName))
                .ForMember(s => s.FirstLineOfKontaktInformation, opt =>
                            opt.MapFrom(d => d.KontrahentDaneKontaktowe.Imie+" " + d.KontrahentDaneKontaktowe.Nazwisko))
                .ForMember(s => s.Adresy, opt => opt.Ignore())
                .ForMember(s => s.Emails, opt => opt.Ignore())
                .ForMember(s => s.PhoneNumbers, opt => opt.Ignore())
                ;

        }
    }
}
