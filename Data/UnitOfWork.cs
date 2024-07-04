using CineVerse.Core.Interfaces;
using CineVerse.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IUserRepository Users {  get; private set; }
        public IMovieRepository Movies { get; private set; }
        public IListRepository Lists { get; private set; }
        public IListMovieRepository ListMovies { get; private set; }
        public IPersonRepository People { get; private set; }
        public ICompanyRepository Companies { get; private set; }
        public IReviewRepository Reviews { get; private set; }
        public IUserFollowRepository UserFollows { get; private set; }
        public IPostRepository Posts { get; private set; }
        public IPostVoteRepository PostVotes { get; private set; }
        public ICommentRepository Comments { get; private set; }
        public ICommentVoteRepository CommentVotes { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Movies = new MovieRepository(_context);
            Lists = new ListRepository(_context);
            ListMovies = new ListMovieRepository(_context);
            People = new PersonRepository(_context);
            Companies = new CompanyRepository(_context);
            Reviews = new ReviewRepository(_context);
            UserFollows = new UserFollowRepository(_context);
            Posts = new PostRepository(_context);
            PostVotes = new PostVoteRepository(_context);
            Comments = new CommentRepository(_context);
            CommentVotes = new CommentVoteRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            //_context.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
