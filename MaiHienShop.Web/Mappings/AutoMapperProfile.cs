using AutoMapper;
using MaiHienShop.Model.Models;
using MaiHienShop.Web.Models;
using System.Collections.Generic;

namespace MaiHienShop.Web.Mappings
{
    //Su dung automapper 4.2.1
    //public class AutoMapperConfiguration
    //{
    //    public static void Configure()
    //    {
    //        Mapper.CreateMap<Post, PostViewModel>();
    //        Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
    //        Mapper.CreateMap<Tag, TagViewModel>();
    //    }
    //}

    //Su dung automapper 6.2.2
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Tag, TagViewModel>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductTag, ProductTagViewModel>();
        }
    }
}