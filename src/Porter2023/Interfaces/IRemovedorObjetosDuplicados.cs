namespace Porter2023.Interfaces
{
    public interface IRemovedorObjetosDuplicados<T>
    {
        IList<T> Remover(IList<T> listaObjetos);
    }
}
