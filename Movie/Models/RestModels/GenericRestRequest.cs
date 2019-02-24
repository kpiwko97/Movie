using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Extensions;

namespace Movie.Models.RestModels
{
    public static class GenericRestRequest<T>
    {
       public static async Task<T> GetDataAsync(string baseUrl)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            var response = await client.ExecuteTaskAsync<T>(request);
            var result = JsonConvert.DeserializeObject<T>(response.Content);
            return result;
        }      
    }
}
