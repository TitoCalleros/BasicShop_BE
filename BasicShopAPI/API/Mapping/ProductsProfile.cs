using AutoMapper;
using BasicShopAPI.API.DTOs.Products;
using BasicShopAPI.Application.CQRS.Commands.Products;
using BasicShopAPI.Domain.Entities;

namespace BasicShopAPI.API.Mapping
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile() 
        {
            // From Request -> Commands
            CreateMap<CreateProductRequestDTO, CreateProductCommand>();
            CreateMap<UpdateProductRequestDTO, UpdateProductCommand>();

            // Form Entities -> Response
            CreateMap<Product, ProductResponseDTO>();
            CreateMap<Product, ProductListItemResponseDTO>();
        }
    }
}
