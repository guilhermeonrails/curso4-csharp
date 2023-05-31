using Newtonsoft.Json;
using screensound_04.Models;
using screensound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        HttpResponseMessage res = await client.GetAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        res.EnsureSuccessStatusCode();
        string resBody = await res.Content.ReadAsStringAsync();
        var songs = JsonConvert.DeserializeObject<List<Music>>(resBody)!;
        //LinqFilter.FilterSongsByArtist(songs, "Kanye West");
        //LinqFilter.FilterSongsByGenre(songs, "hip hop");
        //LinqFilter.FilterArtistsByGenre(songs, "hip hop");
        //LinqSort.ExibirListaDeArtistasOrdenados(songs);

        var musicasFavoritasDoGuilherme = new MusicasFavoritas("daniel");
        musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[181]);
        musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[1220]);
        musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[1432]);
        musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[61]);
        musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[142]);
        musicasFavoritasDoGuilherme.GerarDocumentoJsonComAsMusicasFavoritas();
        
    }
    catch ( Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

