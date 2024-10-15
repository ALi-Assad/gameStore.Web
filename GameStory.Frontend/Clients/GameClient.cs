using System;
using GameStory.Frontend.Models;

namespace GameStory.Frontend.Clients;

public class GameClient(HttpClient httpClient)
{
    public async Task<GameSummary[]> GetGamesAsync() => await
       httpClient.GetFromJsonAsync<GameSummary[]>("games") ?? [];
    public async Task<GameDetails>? GetGameAsync(int GameSummaryId) => await
       httpClient.GetFromJsonAsync<GameDetails>($"games/{GameSummaryId}") ?? throw new Exception("Game not found");

    public async Task CreateGameAsync(GameDetails game)
    {
      await httpClient.PostAsJsonAsync("games", game);
    }

    public async Task UpdateGameAsync(GameDetails game)
    {
       await httpClient.PutAsJsonAsync($"games/{game.Id}", game);
    }

    public async Task DeleteGameAsync(GameSummary game){
       await httpClient.DeleteAsync($"games/{game.Id}");
    }

}
