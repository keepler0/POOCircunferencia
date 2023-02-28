using POOCircunferencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCircunferencia.Datos
{
    public class RepositorioDeCircunferencias
    {
        //aqui estoy creando un atributo tipo lista cicunferencia
        private List<Circunferencia> listaCircunferencias;
        //se crea el metodo constructor
        public RepositorioDeCircunferencias()
        {
            //dentro de ella Instancio la lista
            listaCircunferencias = new List<Circunferencia>();
            ////datos "genericos" como ejemplo para mostrar el DGV
            ////definimos las circunferencias de tipo Circunferencia y le añadimos un valor
            //var circ = new Circunferencia(20);
            //var circ2 = new Circunferencia(2);
            //var circ3 = new Circunferencia(42);
            //var circ4 = new Circunferencia(12);
            ////agregamos al repositorio con el metodo Agregar()
            //Agregar(circ);
            //Agregar(circ2);
            //Agregar(circ3);
            //Agregar(circ4);
            listaCircunferencias = ManejadorArchivoSecuencial.leerArchivoSecuancial();
        }
        //este metodo Agrega datos a la lista llamada listaCircunferencias con el metodo .Add()
        public void Agregar(Circunferencia circunferencia)
        {
            listaCircunferencias.Add(circunferencia);
        }

        public bool Borrar(Circunferencia circ)
        {
            if (listaCircunferencias.Contains(circ))
            {
                listaCircunferencias.Remove(circ);
                return true;
            }
            return false;
        }

        //este metodo nos retorna un int con la cantidad de datos en listaCircunferencia usando la property .Count
        public int GetCantidad()
        {
            return listaCircunferencias.Count;
        }
        /// <summary>
        /// metodo para enviar la lista. este envia los datos de la lista no la lista en si
        /// </summary>
        /// <returns>listaCircunferencias</returns>
        public List<Circunferencia> GetLista()
        {
            return listaCircunferencias;
        }

        public List<Circunferencia> FiltrarDatos(int radioFiltro)
        {
            return listaCircunferencias.Where(c => c.Radio > radioFiltro).ToList();
        }

        public int GetCantidadFiltrada(int radioFiltro)
        {
            return listaCircunferencias.Count(c => c.Radio > radioFiltro);
        }
    }
}
