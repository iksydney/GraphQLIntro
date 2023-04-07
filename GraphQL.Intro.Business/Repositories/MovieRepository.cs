using GraphQLIntro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Intro.Business.Repositories
{
    public interface IMovieRepository { }
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;
        public MovieRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
    }
}
