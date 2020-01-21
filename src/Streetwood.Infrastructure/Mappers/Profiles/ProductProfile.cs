﻿using AutoMapper;
using Streetwood.Core.Domain.Entities;
using Streetwood.Infrastructure.Dto;
using Streetwood.Infrastructure.Dto.Products;

namespace Streetwood.Infrastructure.Mappers.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
            : base("Products")
        {
            CreateMap<Product, ProductListDto>();
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.ProductCategoryId, opt => opt.MapFrom(src => src.ProductCategory.Id));
            CreateMap<Product, ProductWithDiscountDto>();

            CreateMap<Image, ImageDto>()
                .ForMember(dest => dest.Name, opt => opt.ResolveUsing<ImageResolver>());
        }
    }
}
