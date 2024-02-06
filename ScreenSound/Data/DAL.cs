
namespace ScreenSound.Data;

internal abstract class DAL<T>
{
    public abstract IEnumerable<T> Listar();
    public abstract void Adicionar(T obj);
    public abstract void Atualizar(T obj);
    public abstract void Remover(T obj);

}
