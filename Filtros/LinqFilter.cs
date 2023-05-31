using System;
using System.Linq;
using screensound_04.Models;
namespace screensound_04.Filtros
{
	public class LinqFilter
	{
		public static void FilterSongsByArtist(List<Music> songs, string artist)
		{
			var filterSongs = songs.Where(s => s.Artist == artist).ToList();
			Console.WriteLine($"{artist}");
			foreach(var song in filterSongs)
			{
				Console.WriteLine($"- {song.Song}");
			}
		}

		public static void FilterSongsByGenre(List<Music> songs, string genre)
		{
			var filterSongs = songs.Where(s => s.Genre == genre).ToList();
			Console.WriteLine($"Músicas do gênero {genre}");
			foreach (var song in filterSongs)
			{
				Console.WriteLine($"{song.Song} de {song.Artist}");
			}
		}

		public static void FilterArtistsByGenre(List<Music> songs, string genre)
		{
			var filteredArtistByGenre = songs.Where(s => s.Genre == genre).Select(s => s.Artist).Distinct().ToList();
            // Esse metodo utiliza LINQ para filtrar as músicas pelo gênero especificado, seleciona apenas o nome dos artistas (ignorando as informações das músicas), remove duplicatas usando Distinct(), e retorna uma lista dos artistas filtrados.

            Console.WriteLine($"Artistas do gênero {genre}:");
            foreach (var artist in filteredArtistByGenre)
            {
                Console.WriteLine($"- {artist}");
            }
        }
    }
}

