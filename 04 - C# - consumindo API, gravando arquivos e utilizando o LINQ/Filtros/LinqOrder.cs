namespace ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas
        .OrderBy(musica => musica.Artista)
        .Select(musica => musica.Artista)
        .Distinct()
        .ToList();

        Console.WriteLine("Lista de Artistas Ordenados");
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}