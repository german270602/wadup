using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class ClsEmpleados
    //Constructor
    {
    public ClsEmpleados()

    {
        Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }



        
    private string _Nombre;

        public decimal SueldoDiario { get; set; }

        public int Edad { get; set; }


        public string Nombre { get => _Nombre; set => _Nombre = value; }



        //Metodo

        public decimal CalcularSalario(int numerodias)
    {
        return SueldoDiario * numerodias;
    }

    }
}
