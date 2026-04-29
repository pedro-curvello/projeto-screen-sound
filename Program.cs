Album albumDoMichaelJackson = new Album();
albumDoMichaelJackson.Nome = "Thriller";

Musica musica1 = new Musica();
musica1.Nome = "Thriller";
musica1.Duracao = 358;

Musica musica2 = new Musica();
musica2.Nome = "Beat it";
musica2.Duracao = 259;

albumDoMichaelJackson.AdicionarMusica(musica1);
albumDoMichaelJackson.AdicionarMusica(musica2);

albumDoMichaelJackson.ExibirMusicasDoAlbum();
