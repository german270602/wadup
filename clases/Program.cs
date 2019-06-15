using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    class Program
    {
        static void Main(string[] args)
        {
        ClsEmpleados empleado;
            empleado = new ClsEmpleados();

            empleado.Edad = 25;
            empleado.Nombre = "alejandro";
            empleado.SueldoDiario = 25.6m;

            decimal total;
            total = empleado.CalcularSalario(30);

            Console.WriteLine("El salario mensual del empleado" + empleado.Nombre);
            Console.WriteLine("Es: " + total.ToString("C"));
            Console.ReadKey();

        }
    }
}
