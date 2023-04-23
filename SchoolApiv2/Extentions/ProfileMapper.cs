using AutoMapper;
using DataModel.Entity;
using DataModel.Entity.EntityEShop;
using SharedModel.Models;
using SharedModel.Models.eShopModels;

namespace SchoolApiv2.Extentions
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper() {



            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<Course, CourseToEditDto>().ReverseMap();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductToEditDto>().ReverseMap();

            /* CreateMap<Product, ProductCategoryDto>().ReverseMap()
                .ForMember(dest => dest.Category.Name, opt => opt.MapFrom(src => src.CategoryName));

            CreateMap<ProductCategoryDto, Product>().ReverseMap()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<Product, ProductCategoryDto>()
            .ForMember(dst => dst.CategoryName, opt => opt.MapFrom(src => src.Category.Name));*/



            /*CreateMap<GetUserProfileDTO, ApplicationUser>().ReverseMap();
            CreateMap<ApplicationUser, ServiceResponse<ApplicationUser>>().ReverseMap();
            CreateMap<GetUserProfileDTO, ServiceResponse<ApplicationUser>>().ReverseMap();
            CreateMap<Projects, ProjectsMapper.CreateProjectsDTO>().ReverseMap();
            CreateMap<Projects, ProjectsMapper.EditProjectsDTO>().ReverseMap();
            CreateMap<CreateUserProfileDTO, ApplicationUser>()
                    .ForMember(dest =>
                            dest.PasswordHash,
                            opt => opt.MapFrom(src => src.Password))                    
                    .ForMember(dest => dest.DOB, opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.DOB)
                    ? DateTime.Parse(src.DOB): nullDate));

            */


            //.ForMember(dest => dest.DOB, opt => opt.MapFrom(src => ToDateTime(src.DOB)));
            // .ForMember(dest => dest.DOB, opt => opt.MapFrom(src => Convert.ToDateTime(src.DOB))) //s => Convert.ToDateTime(s.EndDate))
            // .ForMember(dest => dest.DOB, opt => opt.MapFrom(src => DateTime.Parse(src.DOB.ToString())))
            //.ForMember(dest => dest.DOB, opt => opt.MapFrom(src => DateTime.ParseExact(src.DOB, "", CultureInfo.InvariantCulture)));
            //.ForMember(dest => dest.DOB, opt => opt.Ignore());             
            //.ReverseMap();

            /*CreateMap<ApplicationUser, CreateUserProfileDTO>()
                .ForMember(dest =>
                        dest.Password,
                        opt => opt.MapFrom(src => src.PasswordHash))        
                .ReverseMap();
            */

        }

    }
}
