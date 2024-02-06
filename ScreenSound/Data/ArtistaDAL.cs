using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Data;

internal class ArtistaDAL
{
    private readonly ScreenSoundContext _context;

    public ArtistaDAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<Artista> ObterTodosOsArtistas()
    {

        return _context.Artistas.ToList();
    }

    public void AdicionarArtista(Artista artista)
    {

        _context.Artistas.Add(artista);
        _context.SaveChanges();
    }

    public void AtualizarArtista(Artista artista)
    {
        _context.Artistas.Update(artista);
        _context.SaveChanges();
    }

    public void RemoverArtista(Artista artista)
    {
        _context.Artistas.Remove(artista);
        _context.SaveChanges();
    }

    public Artista ObterArtistasPorNome(string nome)
    {
        var artista = _context.Artistas.FirstOrDefault(a => a.Nome == nome);
        return artista is not null ? artista : null;
    }
}
