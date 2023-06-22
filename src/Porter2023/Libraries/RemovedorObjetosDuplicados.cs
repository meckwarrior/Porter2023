using Porter2023.Interfaces;
using System.Text.Json;

namespace Porter2023.Libraries
{
    public class RemovedorObjetosDuplicados<T> : IRemovedorObjetosDuplicados<T>
    {
        public IList<T> Remover(IList<T> listaObjetos)
        {
            IList<T> result = new List<T>();

            if (listaObjetos != null)
                foreach(T objeto in listaObjetos) 
                {
                    if(!EstaNaLista(result, objeto))
                        result.Add(objeto);
                
                }

            return result;
        }

        private bool EstaNaLista(IList<T> listaObjetos, T objeto)
        {
            if(typeof(T).FullName.StartsWith("System"))
                foreach (T _objeto in listaObjetos)
                {
                    if (_objeto.ToString() == objeto.ToString())
                        return true;
                }

            else
                foreach (T _objeto in listaObjetos)
                {
                    if (JsonSerializer.Serialize(_objeto)
                        == JsonSerializer.Serialize(objeto))
                    return true;
                }

            return false;
        }
    }
}
