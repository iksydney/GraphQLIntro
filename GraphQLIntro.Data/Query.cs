using GraphQLIntro.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLIntro.Data
{
    public class Query
    {
        public IQueryable<SuperHeroe> GetSuperHeroes => new List<SuperHeroe>().AsQueryable();
    }
}
