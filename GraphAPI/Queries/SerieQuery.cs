using System;
using System.Collections.Generic;
using System.Linq;
using GraphAPI.Models;
using HotChocolate;

namespace GraphAPI.Queries
{
    public class SerieQuery
    {
        private readonly List<Serie> _series = new List<Serie>
        {
            new Serie
            {
                Id = 1,
                SeriesAnime = new List<SeriesA>
                {
                    new SeriesA { name = "One Piece" }
                },
                ReleaseDate = DateTime.UtcNow.AddDays(-10),
                plataform = new List<Plataform>
                {
                    new Plataform { name = "CrunchyRoll", followers = 1000 },
                    new Plataform { name = "Netflix", followers = 2000 }
                }
            },
            new Serie
            {
                Id = 2,
                SeriesAnime = new List<SeriesA>
                {
                    new SeriesA { name = "Naruto" }
                },
                ReleaseDate = DateTime.UtcNow.AddDays(-10),
                plataform = new List<Plataform>
                {
                    new Plataform { name = "CrunchyRoll", followers = 5000 },
                    new Plataform { name = "Netflix", followers = 8000 }
                }
            }
        };

        [GraphQLName("serie")]
        public Serie GetSerieById(int id)
        {
            return _series.FirstOrDefault(s => s.Id == id);
        }
    }
}
