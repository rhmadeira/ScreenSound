using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Data;

internal class MusicaDAL 
{
    private readonly ScreenSoundContext _context;

    public MusicaDAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<Musica> ObterTodasAsMusicas()
    {
        return _context.Musicas.ToList();
    }

    public void AdicionarMusica(Musica musica)
    {
        _context.Musicas.Add(musica);
        _context.SaveChanges();
    }
}
