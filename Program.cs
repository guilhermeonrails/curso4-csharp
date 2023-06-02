using screensound_04.Models;
using screensound_04.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string json = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var songs = JsonSerializer.Deserialize<List<Music>>(json)!;
        Console.WriteLine();

        //LinqFilter.FilterAllGenres(songs);

        //Console.WriteLine(songs.Count);
        //songs[1].ShowDetail();

        //var songs = JsonConvert.DeserializeObject<List<Music>>(resBody)!;
        //LinqFilter.FilterSongsByArtist(songs, "Kanye West");
        LinqFilter.FilterSongsByGenre(songs, "rock");
        //LinqFilter.FilterArtistsByGenre(songs, "hip hop");
        //LinqSort.ExibirListaDeArtistasOrdenados(songs);

        //var musicasFavoritasDoGuilherme = new MusicasFavoritas("gui");
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[1415]);
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[18]);
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[25]);
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[33]);
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[30]);
        //musicasFavoritasDoGuilherme.GerarDocumentoJsonComAsMusicasFavoritas();
        
    }
    catch ( Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

