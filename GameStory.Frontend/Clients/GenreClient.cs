using System;
using GameStory.Frontend.Models;

namespace GameStory.Frontend.Clients;

public class GenreClient(HttpClient httpClient)
{
   // private readonly List<Genre> genres = [
   //      new (){
   //          Id = 1,
   //          Name = "Fighting",
   //       },
   //       new (){
   //          Id = 2,
   //          Name = "Roleplaying",
   //       },
   //       new (){
   //          Id = 3,
   //          Name = "Sports",
   //       },
   //       new (){
   //          Id = 4,
   //          Name = "Racing",
   //       },
   //       new (){
   //          Id = 5,
   //          Name = "Kids and Family",
   //       },
   //  ];


   public async Task<Genre[]> GetGenresAsync() => await httpClient.GetFromJsonAsync<Genre[]>("genres") ?? [];

   public async Task<Genre> GetGenreAsync(string GenreId) =>
     await httpClient.GetFromJsonAsync<Genre>($"genres/{GenreId}") ??
      throw new Exception("Genres not found");
}
