using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteUnitario.Classes;

namespace TesteUnitario
{
    class Program
    {
        //------------------------------- Testes Unitários ------------------------------
        public static void testeAreaT() //AREA DE TRIANGULO
        {
            Calcular c = new Calcular();
            double resultado = c.AreaTriangulo(2,5);
            double resultado2 = c.AreaTriangulo(4,6);
            if (resultado == 5 & resultado2 == 12)
            {
                Console.WriteLine("Teste Area Triangulo: CORRETO");
            }
            else Console.WriteLine("Teste Area Triangulo: ERRADO");
        }
        
        public static void testeDiametro() //DIAMETRO DA CIRCUNFERENCIA
        {
            Calcular c = new Calcular();
            double resultado = c.Circunferencia(12);
            double resultado2 = c.Circunferencia(8);
            if (resultado == 24 & resultado2 == 16)
            {
                Console.WriteLine("Teste Diametro da Circunferencia: CORRETO");
            }
            else Console.WriteLine("Teste Diametro da Circunferencia: ERRADO");
        }
        
        public static void testePar() //IDENTIFICAR NUMERO PAR
        {
            Calcular c = new Calcular();
            bool resultado = c.Par(6);
            if (resultado)
            {
                Console.WriteLine("Teste Identificar Números Pares: CORRETO ");
            }
            else Console.WriteLine("Teste Identificar Números Pares: ERRADO");
        }  
        
        public static void testeMultiplicar() //MULTIPLICAR 2 NÚMEROS
        {
            Calcular c = new Calcular();
            double resultado = c.Multiplicar(2,8);
            if (resultado == 16)
            {
                Console.WriteLine("Teste Multiplicar: CORRETO");
            }
            else Console.WriteLine("Teste Multiplicar: ERRADO");
        }


        //---------------------------- MAIN ----------------------------
        public static void Main(string[] args)
        {
            Program.testeAreaT();
            Program.testeDiametro();
            Program.testePar();
            Program.testeMultiplicar();

            Console.ReadKey();
        }
    }
}
