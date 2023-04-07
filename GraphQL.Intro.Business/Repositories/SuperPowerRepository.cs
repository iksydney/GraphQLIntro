using GraphQLIntro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Intro.Business.Repositories
{
    public interface ISuperPowerRepository { }
    public class SuperPowerRepository : ISuperPowerRepository
    {
        private readonly ApplicationDbContext _dbContext;
    }
}
