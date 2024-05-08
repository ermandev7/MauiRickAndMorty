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
    }
}
