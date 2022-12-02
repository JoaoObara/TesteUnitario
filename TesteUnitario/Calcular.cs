using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitario.Classes
{
    public class Calcular
    {

        public double AreaTriangulo(double b, double h)
        {
            double resultado = (b * h) / 2;
            return resultado;
        }

        public double Circunferencia(double r)
        {
            double resultado = r * 2;
            return resultado;
        }

        public bool Par(double x)
        {
            bool resultado = false;
            if((x%2) == 0)
            {
                resultado = true;
            } else resultado = false;

            return resultado;
        }

        public double Multiplicar(double x, double y)
        {
            double resultado = x * y;
            return resultado;
        }
    }


}
