using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Book;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;
        private readonly IMapper _mapper;
        public BookService(IBookRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
    
        public async Task CreateAsync(BookCreateDto book)
        {
           await _repo.Create(_mapper.Map<Book>(book));
        }

        public async Task<List<BookListDto>> GetAllAsync()
        {
            
            return _mapper.Map<List<BookListDto>>(await _repo.GetAll());
        }
        public async Task DeleteAsync(int id) 
        {
            Book book = await _repo.Get(id);
            //if (book == null) throw new NullReferenceException();
            await _repo.Delete(book);
        }

        public async Task SoftDelete(int id)
        {
            Book book = await _repo.Get(id);
            await _repo.SoftDelete(book);
        }

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

     

        public async Task UpdateAsync(int id, BookUpdateDto book)
        {
            var dbBook = await _repo.Get(id);

            _mapper.Map(book, dbBook);

            await _repo.Update(dbBook);
        }

        public async Task<List<BookListDto>> SearchAsync(string? searchText)
        {
            List<Book> searchDatas = new();

            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Name.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }

            return _mapper.Map<List<BookListDto>>(searchDatas);
        }
    }
}
