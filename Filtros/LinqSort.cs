using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using screensound_04.Models;
namespace screensound_04.Filtros
{
	public class LinqSort
	{
		public static void ExibirListaDeArtistasOrdenados(List<Music> songs)
		{
			var listaDeArtistasOrdenados = songs.OrderBy(s => s.Artist).Select(s => s.Artist).Distinct().ToList();
            // songs.OrderByDescending
            Console.WriteLine("Lista de artistas ordenados");
			foreach (var artista in listaDeArtistasOrdenados)
			{
				Console.WriteLine($"- {artista}");
			}

            // OrderBy(s => s.Artist): Ordena as músicas com base no nome do artista em ordem ascendente. Isso significa que as músicas serão agrupadas e classificadas pelo nome do artista em ordem alfabética crescente.

            //Select(s => s.Artist): Seleciona apenas o nome do artista de cada música.Isso cria uma nova sequência contendo somente os nomes dos artistas, mantendo a ordem estabelecida na etapa anterior.

            //Distinct(): Remove os elementos duplicados da sequência de nomes de artistas. Isso garante que cada nome de artista seja único na lista final.

			//ToList(): Converte a sequência de nomes de artistas em uma lista, armazenando o resultado em sortedArtists.

        }
	}
}

