using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Core.Entity;

namespace Hobify.Applicatione.Mapping
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
          
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<UserRequestDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();

            CreateMap<Post, PostDto>().ReverseMap();
            //CreateMap<PostRequestDto, Post>().ReverseMap();
            //CreateMap<PostUpdateDto, Post>().ReverseMap();

            CreateMap<Comment, CommentDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();    
           
            CreateMap<SubCategory, SubCategoryDto>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();

        }
    }
}
