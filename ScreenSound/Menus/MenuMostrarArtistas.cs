using ScreenSound.Data;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarArtistas : Menu
{
    public override void Executar(ArtistaDAL artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Exibindo todos os artistas registradas na nossa aplicação");

        var artistasRegistrados = artistaDAL.Listar();
        
        foreach (var artista in artistasRegistrados)
        {
            Console.WriteLine($"Artista: {artista}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
