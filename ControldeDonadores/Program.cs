using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeDonadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre, apellidop, apellidom, estadocivil, fechanacimiento, discapacidad, sexo, correoelectronico;
            int edad, ingresomensual;
            
            Console.WriteLine("Bienvenido al sistema de Donadores del Seguro Social" +
                "Ingrese los parametros solicitados y lea las recomendaciones para donadores.");
            Console.WriteLine("Ingrese:" +
                "-Nombre" +
                "-Apellido Paterno" +
                "-Apellido Materno" +
                "-Edad" +
                "-Sexo (M/F)" +
                "-Fecha de Nacimiento" +
                "-Estado civil" +
                "-¿Discapacidad?" +
                "-Ingreso Mensual" +
                "-Correo electronico");
            nombre = Console.ReadLine();
            apellidop = Console.ReadLine();
            apellidom = Console.ReadLine();
            edad = int.Parse(Console.ReadLine());
            sexo = Console.ReadLine();
            fechanacimiento = Console.ReadLine();
            estadocivil = Console.ReadLine();
            discapacidad = Console.ReadLine();
            ingresomensual = int.Parse(Console.ReadLine());
            correoelectronico = Console.ReadLine();

            string datetime = DateTime.Now.ToString("G");

        }
    }
}
