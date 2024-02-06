using ScreenSound.Data;

namespace ScreenSound.Modelos; 

internal class Artista 
{
    private readonly ScreenSoundContext _context;
    
    public Artista(ScreenSoundContext context)
    {
        _context = context;
    }
    
    public Artista(string nome, string bio)
    {
        Nome = nome;
        Bio = bio;
        FotoPerfil = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
    }

    

    public string Nome { get; set; }
    public string FotoPerfil { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        _context.Musicas.Add(musica);
        _context.SaveChanges();
    }

    public void ExibirDiscografia()
    {
        var musicas = _context.Musicas.ToList();
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Nome: {Nome}
            Foto de Perfil: {FotoPerfil}
            Bio: {Bio}";
    }
}