class Album
{
    private List<Musica> musicas = new List<Musica>(); //campo 
    public string Nome { get; set; } //propriedade
    public int DuracaoTotal => musicas.Sum( musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"\n📋 Músicas do álbum {Nome}:\n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"🎵 {musica.Nome}");
        }
        Console.WriteLine($"\n🕐 A duração do álbum é de {DuracaoTotal} segundos!\n");
    }
}