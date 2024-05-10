using MauiRickAndMorty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiRickAndMorty.Services
{
    public interface IRickMortyServices
    {
        Task <Rooot> all();
        Task<Result> GetCharacteById(string id);
        Task <LocationsModels> GetLocationById(string id);

        Task<Result> GetCharacterByURL(string residentUrl);
        Task<EpisodesModels> GetEpisodesByURL(string id);
    }
}
