using ScreenSound.Modelos;

namespace ScreenSound.Data;

internal class MusicaDAL : DAL<Musica>
{
    private readonly ScreenSoundContext _context;

    public MusicaDAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public override IEnumerable<Musica> Listar()
    {
        return _context.Musicas.ToList();
    }

    public override void Adicionar(Musica artista)
    {

        _context.Musicas.Add(artista);
        _context.SaveChanges();
    }

    public override void Atualizar(Musica artista)
    {
        _context.Musicas.Update(artista);
        _context.SaveChanges();
    }

    public override void Remover(Musica artista)
    {
        _context.Musicas.Remove(artista);
        _context.SaveChanges();
    }
}
