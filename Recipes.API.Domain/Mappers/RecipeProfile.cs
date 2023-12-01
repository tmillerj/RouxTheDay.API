using AutoMapper;
using Recipes.API.Data.Entities;
using Recipes.API.Domain.DTO;

namespace Recipes.API.Domain.Mappers;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeDTO>()
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedAt));
    }
}