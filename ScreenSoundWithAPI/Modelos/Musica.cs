
using System.Text.Json.Serialization;

namespace ScreenSoundWithAPI.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

	[JsonPropertyName("genre")]
	public string? Genero { get; set; }

	[JsonPropertyName("duration_ms")]
	public int Duracao { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Duração: {Duracao/1000} seg");
    }
}
