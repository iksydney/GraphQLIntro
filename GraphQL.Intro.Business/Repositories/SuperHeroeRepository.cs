using GraphQLIntro.Data;

namespace GraphQL.Intro.Business.Repositories
{
    public interface ISuperHeroeRepository
    {

    }
    public class SuperHeroeRepository : ISuperHeroeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SuperHeroeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
