using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> GetUserByEmailAsync(string email);
    }

    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IEnumerable<Movie>> FindMoviesByTitleAsync(string title);
        Task<IEnumerable<Movie>> GetMoviesAsync(int pageNumber,  int pageSize);
        Task<int> CountMoviesAsync();
    }

    public interface IListRepository : IRepository<List>
    {
        Task<List> GetListWithMoviesAsync(string listId);
    }

    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Company> GetCompanyWithMoviesAsync(int companyId);
    }

    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetPersonWithMoviesAsync(int personId);
    }

    public interface IReviewRepository : IRepository<Review>
    {
        Task<IEnumerable<Review>> GetReviewsForMovieAsync(int movieId);
    }
}
