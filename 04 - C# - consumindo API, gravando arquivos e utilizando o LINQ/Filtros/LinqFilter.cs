namespace ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;

internal class LinqFilter
{
    public static void FiltrarGeneros(List<Musica> musicas)
    {
        var todosGeneros = musicas
        .Select(g => g.Genero)
        .Distinct()
        .ToList();

        foreach(var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistaPorgenero = musicas
        .Where(musica => musica.Genero!
        .Contains(genero))
        .Select(musica => musica.Artista)
        .Distinct()
        .ToList();

        Console.WriteLine($"Artistas do gênero {genero}: ");
        foreach(var artista in artistaPorgenero)
        {
            Console.WriteLine($"- {artista}");
        }

    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas
        .Where(musica => musica.Artista!
        .Equals(artista))
        .ToList();

        Console.WriteLine($"Músicas do artista {artista}: ");

        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}