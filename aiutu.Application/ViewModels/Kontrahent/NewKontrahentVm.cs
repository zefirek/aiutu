using aiutu.Application.Mapping;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace aiutu.Application.ViewModels.Kontrahent
{
    public class NewKontrahentVm : IMapFrom<aiutu.Domain.Model.Kontrahent>
    {
        //[Required]
        public int Id { get; set; }
        // asp 8.13 0:40
        [DisplayName("Nazwa")]
        public string Nazwa { get; set; }
        public string NIP { get; set; }
        public string Regon { get; set; }

        public void Mapping(Profile profile)
        {
            // asp 8.11 3:53
            profile.CreateMap<NewKontrahentVm, aiutu.Domain.Model.Kontrahent>();
        }
    }

    public class NewKontrahentValidation : AbstractValidator<NewKontrahentVm> 
    {
        // asp. 8.12 6:30
        public NewKontrahentValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Nazwa).MaximumLength(255);
            RuleFor(x => x.NIP).Length(10);
            RuleFor(x => x.Regon).Length(9,14);
        }
    }
}
