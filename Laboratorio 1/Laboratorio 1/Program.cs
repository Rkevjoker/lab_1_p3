using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//El programa tendrá que tener estructuras de control. Elaborar una aplicación de consola
//con los siguientes datos:
//1.Se ingresarán 3 datos nombres, edad, departamento y municipio.
//2. Los municipios deberán estar en lasados al departamento seleccionado.
//3. Al darle agregar el dato se guardarán en un arregló.
//4. Recorrer el arreglo y mostrar la edad.

namespace Laboratorio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Municipio[] municipio = new Municipio[16];
            Persona[] per = new Persona[1];

            municipio[0] = new Municipio("Chalatenango", "Nueva Concepcion");
            municipio[1] = new Municipio("Chalatenango", "El Paraiso");
            municipio[2] = new Municipio("Chalatenango", "La Laguna");

            municipio[3] = new Municipio("Cabañas", "Dolores");
            municipio[4] = new Municipio("Cabañas", "Sensutepeque");
            municipio[5] = new Municipio("Cabañas", "Cinquera");

            municipio[6] = new Municipio("Cuscatlán", "San Rafael Cedros");
            municipio[7] = new Municipio("Cuscatlán", "Suchitoto");

            municipio[8] = new Municipio("La Libertad", "Chiltiupán");
            municipio[9] = new Municipio("La Libertad", "Ciudad Arce");
            municipio[10] = new Municipio("La Libertad", "Colón");

            municipio[11] = new Municipio("La Paz", "El Rosario");
            municipio[12] = new Municipio("La Paz", "San Emigdio");
            municipio[13] = new Municipio("La Paz", "San Francisco Chinameca");

            municipio[14] = new Municipio("Morazán", "Cacaopera");
            municipio[15] = new Municipio("Morazán", "Guatajiagua");

            Console.WriteLine("bienvenido cual su nombre y edad");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Nombre: ");
            Console.WriteLine("------------------------------------------------------------------------");
            string nombre = Console.ReadLine();
            Console.WriteLine("Edad: ");
            Console.WriteLine("------------------------------------------------------------------------");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Ahora escriba un departamento dentro de las opciones: Chalatenango, Cabañas, Cuscatlán, La Libertad, La Paz, Morazán");
            string depa = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------");

            Console.Clear();
            for (int i = 0; i < municipio.Length; i++)
            {
                if (municipio[i].departamento == depa)
                {
                    Console.WriteLine(i + " - " + municipio[i].municipio);
                }

            }
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Seleccione un municipio");
            Console.WriteLine("------------------------------------------------------------------------");
            int opc = Convert.ToInt32(Console.ReadLine());

            per[0] = new Persona(nombre, edad, municipio[opc].departamento, municipio[opc].municipio);

            for (int i = 0; i < per.Length; i++)
            {
                Console.WriteLine(per[i].ddad);
            }
            Console.ReadLine();
        }

        public class Persona
        {
            public string nombre { get; set; }
            public string departamento { get; set; }
            public string municipio { get; set; }
            public int ddad { get; set; }
            public Persona(string nombre, int edad, string departamento, string municipio)
            {
                this.nombre = nombre;
                this.ddad = edad;
                this.departamento = departamento;
                this.municipio = municipio;
            }
        }

        public abstract class Dpt
        {
            public abstract string departamento { get; set; }
        }

        public class Municipio : Dpt
        {
            public string municipio { get; set; }
            public override string departamento { get; set; }

            public Municipio(string departamento, string municipio)
            {
                this.departamento = departamento;
                this.municipio = municipio;
            }

        }
    }
    
}
