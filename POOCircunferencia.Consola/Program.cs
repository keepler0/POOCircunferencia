using POOCircunferencia.Datos;
using POOCircunferencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCircunferencia.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var circ = new Circunferencia(20);
            var repo = new RepositorioDeCircunferencias();
            var lista = repo.GetLista();
            Console.WriteLine($"valor de circunferencia={circ.Radio.ToString()}");
            Console.WriteLine(circ.GetPerimetro());
            Console.WriteLine(circ.GetSuperficie());
            repo.Agregar(circ);
            var circ2 = new Circunferencia() { Radio = 14 };
            Console.WriteLine($"valor de circunferencia={circ2.Radio.ToString()}");
            Console.WriteLine(circ2.GetPerimetro());
            Console.WriteLine(circ2.GetSuperficie());
            repo.Agregar(circ2);
            Console.WriteLine($"Cantidad en lista={repo.GetCantidad()}");
            Console.WriteLine("la lista contiene: ");
            mostrarLista(lista);

            Console.Write("Ingrese una nueva circunferencia=");
            var circ3 = new Circunferencia();
            var newCirc = int.Parse(Console.ReadLine());
            circ3.Radio = newCirc;
            
            if (circ3.validar())
            {
                repo.Agregar(circ3);
                Console.WriteLine($"valor de circunferencia={circ3.Radio.ToString()}");
                Console.WriteLine(circ3.GetPerimetro());
                Console.WriteLine(circ3.GetSuperficie());
            }
            else
            {
                Console.WriteLine("El valor debe ser mayor a cero");
            }
                 
            Console.ReadLine();
        }

        private static void mostrarLista(List<Circunferencia> lista)
        {
            int contador = 1;
            foreach(var circ in lista)
            {
                Console.Write($"Circunferencia {contador}=");
                Console.WriteLine(circ.Radio);
                contador++; 
            }
        }
    }
}
