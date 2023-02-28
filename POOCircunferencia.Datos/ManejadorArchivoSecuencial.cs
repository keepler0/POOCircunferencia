using POOCircunferencia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCircunferencia.Datos
{
    public static class ManejadorArchivoSecuencial
    {
        private static string archivo = "Circunferencias.txt";
        public static void GuardarArchivoSecuancial(List<Circunferencia>lista)
        {
            //creo el objeto que va a escribir en el archivo secuancial
            using (var escritor=new StreamWriter(archivo))
            {
                //recorro la lista
                foreach(var circunferencia in lista)
                {
                    //creo la linea a escribir
                    string linea = ConstruirLinea(circunferencia);
                    escritor.WriteLine(linea);
                }
            }
        }
        public static List<Circunferencia> leerArchivoSecuancial()
        {
            List <Circunferencia> lista=new List<Circunferencia>();
            using (var lector=new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    Circunferencia circ = ConstruirCircunferencia(linea);
                    lista.Add(circ);
                }
            }
            return lista;
        }

        private static Circunferencia ConstruirCircunferencia(string linea)
        {
            //var capos=linea.Split(','); 
            return new Circunferencia() { Radio=int.Parse(linea) };
        }

        private static string ConstruirLinea(Circunferencia circunferencia)
        {
            return $"{circunferencia.Radio}";
        }
    }
}
