using System;
using Newtonsoft.Json;
namespace screensound_04.Models
{
	public class MusicasFavoritas
	{
		private string Nome { get; set; }
		private List<Music> listaDasMusicasFavoritas;

		public MusicasFavoritas(string nome)
		{
			Nome = nome;
			listaDasMusicasFavoritas = new List<Music>();
		}

		public void AdicionarMusicaFavorita(Music musica)
		{
			listaDasMusicasFavoritas.Add(musica);
		}

		public void ExibirMusicasFavorias()
		{
			Console.WriteLine($"Essas são as músicas preferidas do {Nome}\n");
			foreach (var musica in listaDasMusicasFavoritas)
			{
				Console.WriteLine($"- {musica.Song} de {musica.Artist}");
			}
		}

		public void GerarDocumentoJsonComAsMusicasFavoritas()
		{
            
            string jsonMusicas = JsonConvert.SerializeObject(listaDasMusicasFavoritas, Formatting.Indented);
			var json = $"{{ \"nome\": \"{Nome}\", \"musicas\": {jsonMusicas} }}";
            string filePath = $"musicas-favoritas-{Nome}.json";

			File.WriteAllText(filePath, json);

			Console.WriteLine("O arquivo JSON foi gerado com sucesso!");
			Console.WriteLine($"O arquivo está nesse caminho: {Path.GetFullPath(filePath)}");
		}
	}
}

