Banda michaelJackson = new Banda("Michael Jackson");

Album albumDoMichaelJackson = new Album("Thriller");

Musica musica1 = new Musica(michaelJackson, "Thriller")
{
    Duracao = 358,
    Disponivel = true,
};
musica1.Duracao = 358;

Musica musica2 = new Musica(michaelJackson, "Beat it")
{
    Duracao = 259,
    Disponivel = false,
};
musica2.Duracao = 259;

albumDoMichaelJackson.AdicionarMusica(musica1);
albumDoMichaelJackson.AdicionarMusica(musica2);
michaelJackson.AdicionarAlbum(albumDoMichaelJackson);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoMichaelJackson.ExibirMusicasDoAlbum();
michaelJackson.ExibirDiscografia();
