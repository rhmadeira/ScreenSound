using ScreenSound.Data;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite o artista cuja música deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        var artistasEncontrado = artistaDAL.RecuperarPor(a => a.Nome.Equals(nomeDoArtista));
        if (artistasEncontrado is not null)
        {
            Console.Write("Agora digite o título da música: ");
            string tituloDaMusica = Console.ReadLine()!;
            Console.Write("Agora digite o ano da música: ");
            string anoDaMusica = Console.ReadLine()!;

            artistasEncontrado.AdicionarMusica(new Musica(tituloDaMusica, int.Parse(anoDaMusica)));
            Console.WriteLine($"A música {tituloDaMusica} de ano {anoDaMusica} do artista {nomeDoArtista} foi registrada com sucesso!");
            artistaDAL.Atualizar(artistasEncontrado);
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
