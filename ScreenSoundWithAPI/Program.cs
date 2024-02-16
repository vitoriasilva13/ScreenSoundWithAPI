using ScreenSoundWithAPI.Modelos;
using ScreenSoundWithAPI.Filtros;
using System.Text.Json;

using (HttpClient cliente = new HttpClient())
{
	try
	{
		string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
		//Console.WriteLine(resposta);

		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
		LinqFilter.FiltrarTodosGenerosMusicais(musicas);
		Console.WriteLine("\n-----------------------------------------------------\n");
		LinqFilter.OrdenarArtistas(musicas);
		Console.WriteLine("\n-----------------------------------------------------\n");
		LinqFilter.ArtistasPorGenero(musicas, "pop");
		Console.WriteLine("\n-----------------------------------------------------\n");
		LinqFilter.MusicasPorArtista(musicas, "Taylor Swift");

	}
	catch (Exception ex)
	{
		Console.WriteLine($"Houve um problema ao realizar requisição. Erro: {ex.Message}");
	}
}