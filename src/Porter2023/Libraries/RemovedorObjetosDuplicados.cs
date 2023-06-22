using Porter2023.Interfaces;
using System.Text.Json;

namespace Porter2023.Libraries
{
    public class RemovedorObjetosDuplicados<T> : IRemovedorObjetosDuplicados<T>
    {
        /// <summary>
        /// Remove objetos duplicados de uma lista genérica.
        /// </summary>
        /// <param name="listaObjetos">Lista genérica de objetos</param>
        /// <returns>Uma Lista sem objetos duplicados.</returns>
        public IList<T> Remover(IList<T> listaObjetos)
        {
            IList<T> listaSemDuplicados = new List<T>();

            if (listaObjetos != null)
                foreach(T objetoAtual in listaObjetos) 
                {
                    if(!EstaNaLista(listaSemDuplicados, objetoAtual))
                        listaSemDuplicados.Add(objetoAtual);
                
                }

            return listaSemDuplicados;
        }

        private bool EstaNaLista(IList<T> listaObjetos, T objetoAtual)
        {
            if(typeof(T).FullName.StartsWith("System"))
                foreach (T _objeto in listaObjetos) //Objetos do sistema
                {
                    if (_objeto.ToString() == objetoAtual.ToString())
                        return true;
                }

            else
                foreach (T _objeto in listaObjetos)
                {
                    if (JsonSerializer.Serialize(_objeto)
                        == JsonSerializer.Serialize(objetoAtual))
                    return true;
                }

            return false;
        }
    }
}
