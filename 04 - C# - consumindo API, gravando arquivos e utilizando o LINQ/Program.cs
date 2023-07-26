using System.Text.Json;
using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // musicas[1].ExibirDetalhesDaMusica();

        // LinqFilter.FiltrarGeneros(musicas);
        // LinqOrder.ExibirArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        // LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");

        // var musicasPreferidas = new MusicasPreferidas("Matheus");
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[0]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);

        // musicasPreferidas.ExibirMusicasFavoritas();
        // musicasPreferidas.GerarArquivoJson();

        LinqFilter.FiltrarMusicasC(musicas);



    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
