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
        public int Duration_ms { get; set; }
        [JsonPropertyName("genre")]
        public string? Genre { get; set; }
        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Tonalidade
        {
            get
            {
                string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
                return tonalidades[Key];
            }
        }

        public void ShowDetail()
        {
            Console.WriteLine($"Artista: {Artist}");
            Console.WriteLine($"Música: {Song}");
            Console.WriteLine($"Duração em segundos: {Duration_ms / 1000}");
            Console.WriteLine($"Gênero: {Genre}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }

    }
}

