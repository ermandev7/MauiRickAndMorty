using MauiRickAndMorty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiRickAndMorty.Services
{
    public class RickMortyServices : IRickMortyServices
    {

        const string charactersUrl = "https://rickandmortyapi.com/api/character";
       

         public async Task<Rooot> all()
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(charactersUrl);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<Rooot>(content);

                    if (data != null && data.info != null)
                    {
                        // Suponiendo que 'results' es una lista de objetos que representan los personajes
                        var loginResult = data.results;
                        // Procesa 'loginResult' según sea necesario
                        // ...
                        return data;
                    }

                   
                }
                return new Rooot();
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente
                Console.WriteLine(ex.Message);
                return new Rooot();
            }
        }
    }
}

