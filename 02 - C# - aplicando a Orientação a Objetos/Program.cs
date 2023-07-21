Album albumDoSkank = new Album();
albumDoSkank.Nome = "Velocia";

Musica musica1 = new Musica();
musica1.Nome = "Multidão";
musica1.Duracao = 240;

Musica musica2 = new Musica();
musica2.Nome = "Périplo";
musica2.Duracao = 300;

albumDoSkank.AdicionarMusica(musica1);
albumDoSkank.AdicionarMusica(musica2);

albumDoSkank.ExibirMusicas();