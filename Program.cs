using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace restApp
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static async Task<List<Clan>> GetClans()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Clan>));

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent","ACME Browser");
// //            var getMoviesTask = client.GetStringAsync("https://www.jeremymorgan.com:8080/fakeapi/Movies");
//             var getClansTask = client.GetStringAsync("http://35.159.12.27:8080/Clannitpdp/api/ListClans");
//             var output = await getClansTask;
//             Console.WriteLine(output);
                var streamTask = client.GetStreamAsync("http://35.159.12.27:8080/Clannitpdp/api/ListClans");
                var Clans = serializer.ReadObject(await streamTask) as List<Clan>;

                return Clans;
        }
        static void Main(string[] args)
        {
            // GetClans().Wait();
            var clans = GetClans().Result;

            foreach (var clan in clans)
            {
                Console.WriteLine(clan.ClanName + " (Description:= " + clan.Description + ")");
            }
        }
    }
}
