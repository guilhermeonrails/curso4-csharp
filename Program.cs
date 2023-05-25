using Newtonsoft.Json;
using screensound_04.Models;
using (HttpClient client = new HttpClient())
{
    try
    {
        HttpResponseMessage res = await client.GetAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        res.EnsureSuccessStatusCode();
        string resBody = await res.Content.ReadAsStringAsync();
        var songs = JsonConvert.DeserializeObject<List<Music>>(resBody)!;
        songs[1998].ShowDetail();
    }
    catch ( Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

