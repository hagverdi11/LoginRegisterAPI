using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Account;
using ServiceLayer.DTOs.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<BookCreateDto, Book>();
            CreateMap<Book, BookListDto>();
            CreateMap<BookUpdateDto, Book>().ReverseMap(); 
            CreateMap<RegisterDto, AppUser>().ReverseMap();
           


        }

    }
}
