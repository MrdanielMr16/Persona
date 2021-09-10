using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class1
    {
        String Cedula;
        String Nombre;
        int Edad;
        int Fecha_Nacimiento;
        public int CalcularEdad()
        {
            Edad = Fecha_Nacimiento - 2021;
            return Edad;
        }
        public Class1(String cedula, String nombre, int edad, int fechaNacimiento)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Fecha_Nacimiento = fechaNacimiento;
        }
    }
}
