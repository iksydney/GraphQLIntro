﻿using GraphQLIntro.Data.Entities;
using HotChocolate;
using System.Linq;

namespace GraphQLIntro.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]

        //public IQueryable<SuperHeroe> GetSuperHeroes => new List<SuperHeroe>().AsQueryable();
        public IQueryable<SuperHeroe> GetSuperheroes([Service] ApplicationDbContext context)
        {
            return context.SuperHeroes;
        }

    }
}
