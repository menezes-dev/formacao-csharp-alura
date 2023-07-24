Banda skank = new Banda("Skank");
Album albumDoSkank = new Album("Velocia");

Musica musica1 = new Musica(skank, "Multidão")
{
    Duracao = 240,
    Disponivel = true
}; //inicializando propriedades opcionais do objeto

Musica musica2 = new Musica(skank, "Périplo")
{
    Duracao = 300,
    Disponivel = false
}; 

// Console.WriteLine();
// albumDoSkank.AdicionarMusica(musica1);
// albumDoSkank.AdicionarMusica(musica2);
// skank.AdicionarAlbum(albumDoSkank);

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumDoSkank.ExibirMusicas();
// skank.ExibirDiscografia();
// Console.WriteLine();

Episodio ep1 = new(3, "A história da Bomba Atômica", 35);
ep1.AdicionarConvidados("Pedro Loos");
ep1.AdicionarConvidados("Matheus Menezes");

Episodio ep2 = new(1, "A história dos Buracos Negros", 39);
ep2.AdicionarConvidados("Pedro Loos");
ep2.AdicionarConvidados("Matheus Menezes");

Episodio ep3 = new(2, "A história da Radiação Cósmica de Fundo", 32);
ep3.AdicionarConvidados("Pedro Loos");
ep3.AdicionarConvidados("Matheus Menezes");

Podcast podcast = new Podcast("Sinapse", "Pedro Loos");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();