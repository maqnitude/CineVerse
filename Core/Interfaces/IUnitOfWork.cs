using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IReviewRepository Reviews { get; }
        IPersonRepository People { get; }
        IMovieRepository Movies { get; }
        IListRepository Lists { get; }
        ICompanyRepository Companies { get; }
        Task<int> CompleteAsync();
    }
}
