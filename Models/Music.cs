using System;
using System.Text.Json.Serialization;

namespace screensound_04.Models
{
	public class Music
	{
        [JsonPropertyName("artist")]
        public string? Artist { get; set; }
        [JsonPropertyName("song")]
        public string? Song { get; set; }
        [JsonPropertyName("duration_ms")]
        public string Duration_ms { get; set; }
        [JsonPropertyName("genre")]
        public string? Genre { get; set; }

        public void ShowDetail()
        {
            Console.WriteLine($"Artista: {Artist}");
            Console.WriteLine($"Música: {Song}");
            Console.WriteLine($"Duração em segundos: {Duration_ms}");
            Console.WriteLine($"Gênero: {Genre}");
        }

    }
}

