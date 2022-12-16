using AutoMapper;
using Hya.Kadaster.Bag.Models.Generated;
using Hya.Kadaster.Bag.Tool.Models;

namespace Hya.Kadaster.Bag.Tool.Mappings;

public class AddressMapper : Profile
{
    public AddressMapper()
    {
        CreateMap<AdresIOHal, AddressDto>()
            .ForMember(
                dest => dest.Id,
                opt => opt.MapFrom(src => src.NummeraanduidingIdentificatie)
            )
            .ForMember(
                dest => dest.City,
                opt => opt.MapFrom(src => src.WoonplaatsNaam)
            )
            .ForMember(
                dest => dest.PostalCode,
                opt => opt.MapFrom(src => src.Postcode)
            )
            .ForMember(
                dest => dest.Street,
                opt => opt.MapFrom(src => src.OpenbareRuimteNaam)
            )
            .ForMember(
                dest => dest.HouseNumber,
                opt => opt.MapFrom(src => src.Huisnummer)
            )
            .ForMember(
                dest => dest.HouseNumberAddition,
                opt => opt.MapFrom(src => src.Huisnummertoevoeging)
            )
            .ForMember(
                dest => dest.HouseLetter,
                opt => opt.MapFrom(src => src.Huisletter)
            );
    }
}