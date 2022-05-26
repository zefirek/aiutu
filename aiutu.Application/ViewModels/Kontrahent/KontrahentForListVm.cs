using aiutu.Application.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Application.ViewModels.Kontrahent
{
    public class KontrahentForListVm : IMapFrom<aiutu.Domain.Model.Kontrahent>
    {
        public int Id { get; set; }
        public string  Nazwa { get; set; }
        public string NIP { get; set; }

        public void Mapping(Profile profile)
        {
            //profile.CreateMap<aiutu.Domain.Model.Kontrahent, KontrahentForListVm>()
            //    .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
            //    .ForMember(d => d.Nazwa, opt => opt.MapFrom(s => s.Nazwa))
            //    .ForMember(d => d.NIP, opt => opt.MapFrom(s => s.NIP));

            profile.CreateMap<aiutu.Domain.Model.Kontrahent, KontrahentForListVm>();
        }
    }
}
