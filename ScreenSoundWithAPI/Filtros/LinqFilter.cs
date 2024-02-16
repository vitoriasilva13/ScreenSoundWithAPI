using ScreenSoundWithAPI.Modelos;

namespace ScreenSoundWithAPI.Filtros;

internal class LinqFilter
{
	public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
	{
		var todosGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var item in todosGenerosMusicais)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public static void OrdenarArtistas(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
		foreach (var item in artistasOrdenados)
		{
			Console.WriteLine($"- {item}");
		}
	}

	public static void ArtistasPorGenero(List<Musica> musicas, string genero)
	{
		var artistasGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
		Console.WriteLine($"Artistas por gênero musical: {genero}");
		foreach (var item in artistasGenero)
		{
			Console.WriteLine($"- {item}");
		}
	}

	public static void MusicasPorArtista(List<Musica> musicas, string artista)
	{
		var musicasArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).ToList();
		Console.WriteLine($"Músicas do artista: {artista}");
		foreach (var item in musicasArtista)
		{
			Console.WriteLine($"- {item}");
		}
	}
}
