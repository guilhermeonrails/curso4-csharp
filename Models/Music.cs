using System;
namespace screensound_04.Models
{
	public class Music
	{
        //[XML]
        public string? Artist { get; set; }
        public string? Song { get; set; }
        public int Duration_ms { get; set; }
        public bool Explicit { get; set; }
        public int Year { get; set; }
        public int Popularity { get; set; }
        public int Key { get; set; }
        public double Tempo { get; set; }
        public string? Genre { get; set; }

        public void ShowDetail()
        {
            Console.WriteLine($"Artista: {Artist}");
            Console.WriteLine($"Música: {Song}");
            Console.WriteLine($"Duração em segundos: {Duration_ms / 1000}");
            Console.WriteLine($"18+: {Explicit}");
            Console.WriteLine($"Ano: {Year}");
            Console.WriteLine($"Popularidade: {Popularity}");
            Console.WriteLine($"Tempo: {Tempo}");
            Console.WriteLine($"Gênero: {Genre}");
        }

    }
}

