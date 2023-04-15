using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo14_04_23
{
   
    class Program
        {
            static void Main(string[] args)
            {
                Console.Write("INGRESE CUAL ES LA CANTIDAD DE ALUMNOS: ");
                int cantidadAlumnos = int.Parse(Console.ReadLine());

                Alumno[] alumnos = new Alumno[cantidadAlumnos];

                
                for (int i = 0; i < cantidadAlumnos; i++)
                {
                    Console.Write($"INGRESE EL NOMBRE #{i + 1}: ");
                    string nombre = Console.ReadLine();

                    Console.Write($"INGRESE LA NOTA #{i + 1}: ");
                    int nota = int.Parse(Console.ReadLine());

                    alumnos[i] = new Alumno(nombre, nota);
                }

                int notaMaxima = alumnos[0].Nota;
                int indiceNotaMaxima = 0;

                int notaMinima = alumnos[0].Nota;
                int indiceNotaMinima = 0;

                int sumaNotas = 0;

                foreach (Alumno alumno in alumnos)
                {
                    sumaNotas += alumno.Nota;

                    if (alumno.Nota > notaMaxima)
                    {
                        notaMaxima = alumno.Nota;
                        indiceNotaMaxima = Array.IndexOf(alumnos, alumno);
                    }

                    if (alumno.Nota < notaMinima)
                    {
                        notaMinima = alumno.Nota;
                        indiceNotaMinima = Array.IndexOf(alumnos, alumno);
                    }
                }

                Console.WriteLine($"EL PROMEDIO DE NOTAS ES: {sumaNotas / cantidadAlumnos}");

                Console.WriteLine($"LA NOTA MAS ALTA FUE: {notaMaxima} FELICIDADES {alumnos[indiceNotaMaxima].Nombre}");
                Console.WriteLine($"LA NOTA MAS BAJA FUE: {notaMinima} ESFORCEMONOS MAS LA PROXIMA VEZ {alumnos[indiceNotaMinima].Nombre}");

                Console.ReadLine();
            }
        }

        class Alumno
        {
            public string Nombre { get; set; }
            public int Nota { get; set; }

            public Alumno(string nombre, int nota)
            {
                Nombre = nombre;
                Nota = nota;
            }
        }
}


  