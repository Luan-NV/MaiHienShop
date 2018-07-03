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
            CreateMap<List<Post>, List<PostViewModel>>();
            CreateMap<List<PostCategory>, List<PostCategoryViewModel>>();
            CreateMap<List<Tag>, List<TagViewModel>>();
            CreateMap<List<ProductCategory>, List<ProductCategoryViewModel>>();
            CreateMap<List<Product>, List<ProductViewModel>>();
            CreateMap<List<ProductTag>, List<ProductTagViewModel>>();
        }
    }
}