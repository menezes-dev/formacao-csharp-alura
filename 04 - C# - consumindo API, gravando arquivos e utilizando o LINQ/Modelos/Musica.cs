namespace ScreenSoundAPI.Modelos;
using System.Text.Json.Serialization;
internal class Musica
{
    [JsonPropertyName("song")] //propriedade vai fazer referência a propriedade song do array de resposta da requisição
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine();
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duracao: {Duracao / 1000}s");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine();
    }
}