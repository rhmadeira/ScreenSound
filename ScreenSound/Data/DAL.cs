
using ScreenSound.Modelos;

namespace ScreenSound.Data;

internal abstract class DAL<T> where T: class
{
    
    protected readonly ScreenSoundContext _context;

    public DAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<T> Listar()
    {
        return _context.Set<T>().ToList();
    }
    public void Adicionar(T obj)
    {

        _context.Set<T>().Add(obj);
        _context.SaveChanges();
    }
    public void Atualizar(T obj)
    {
        _context.Set<T>().Update(obj);
        _context.SaveChanges();
    }
    public void Remover(T obj)
    {
        _context.Set<T>().Remove(obj);
        _context.SaveChanges();
    }
    public T? RecuperarPor(Func<T, bool> filtro)
    {
        return _context.Set<T>().FirstOrDefault(filtro);
    }

}
