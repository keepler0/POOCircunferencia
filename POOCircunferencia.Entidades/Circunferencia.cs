using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCircunferencia.Entidades
{
    public class Circunferencia
    {
        public int Radio { get; set; }

        //metodo constructor por defecto
        public Circunferencia()
        {
            
        }
        //metodo constructor sobrecargado
        //la diferencia entre el defecto y el cargado es que uno no tiene parametros agreagados y el otro si en este caso int radio
        public Circunferencia(int radio)
        {
            Radio = radio;
        }
        //metodo para obtener el perimetro
        public double GetPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
        //metodo para obtener la superficie
        public double GetSuperficie() => Math.PI * Math.Pow(Radio, 2);
        //filtro para evitar que el dato introducido no sea menor a cero
        public bool validar()
        {
            return Radio > 0;
        }
    }
   
}
