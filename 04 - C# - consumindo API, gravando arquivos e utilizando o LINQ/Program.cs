using System.Text.Json;
using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        
        // LinqFilter.FiltrarGeneros(musicas);
        // LinqOrder.ExibirArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");

    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
