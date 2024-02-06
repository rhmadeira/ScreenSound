using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Data;

internal class ArtistaDAL : DAL<Artista>
{
    private readonly ScreenSoundContext _context;

    public ArtistaDAL(ScreenSoundContext context)
    {
        _context = context;
    }
    public override IEnumerable<Artista> Listar()
    {
        return _context.Artistas.ToList();
    }

    public override void Adicionar(Artista artista)
    {

        _context.Artistas.Add(artista);
        _context.SaveChanges();
    }

    public override void Atualizar(Artista artista)
    {
        _context.Artistas.Update(artista);
        _context.SaveChanges();
    }

    public override void Remover(Artista artista)
    {
        _context.Artistas.Remove(artista);
        _context.SaveChanges();
    }

    public Artista ObterPorNome(string nome)
    {
        var artista = _context.Artistas.FirstOrDefault(a => a.Nome == nome);
        return artista is not null ? artista : null;
    }


}
