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
                       
                        return data;
                    }

                   
                }
                return new Rooot();
            }
            catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
                return new Rooot();
            }
        }

        public async Task<Result> GetCharacterByURL(string residentUrl)
        {
            //https://rickandmortyapi.com/api/character/38
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(residentUrl);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<Result>(content);

                    if (data != null && data != null)
                    {

                        return data;
                    }


                }
                return new Result();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return new Result();
            }
        }

        public async Task <LocationsModels> GetLocationById(string id)
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/location/"+id);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<LocationsModels>(content);

                    if (data != null && data != null)
                    {
                        
                        return data;
                    }


                }
                return new LocationsModels();
            }
            catch (Exception ex)
            {
              
                Console.WriteLine(ex.Message);
                return new LocationsModels();
            }
        }
    }
}

