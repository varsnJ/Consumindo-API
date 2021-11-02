using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace ConsumindoAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://jsonplaceholder.typicode.com/comments";
            using(var http = new HttpClient())
            {
                var response = await http.GetStringAsync(url);
                var comentarios = JsonConvert.DeserializeObject<List<Comentarios>>(response);
                foreach(var comentario in comentarios)
                {
                    Console.WriteLine("CONSUMINDO API----->");
                    Console.WriteLine($"PostId: {comentario.postId}");
                    Console.WriteLine($"Id: {comentario.id}");
                    Console.WriteLine($"Name: {comentario.name}");
                    Console.WriteLine($"Email: {comentario.email}");
                    Console.WriteLine($"Comentario: {comentario.body}");
                    Console.WriteLine("-------------->");
                }
                Console.ReadLine();
            }
        }
    }
}
