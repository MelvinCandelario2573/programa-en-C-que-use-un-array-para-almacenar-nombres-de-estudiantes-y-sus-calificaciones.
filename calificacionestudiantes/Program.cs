using System;

namespace EstudiantesCalificaciones
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public double Calificacion { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Definir un array para almacenar datos de estudiantes
            Estudiante[] estudiantes = new Estudiante[5];

            // Ingresar datos de los estudiantes
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Estudiante {0}:", i + 1);
                Console.Write("Nombre: ");
                estudiantes[i] = new Estudiante();
                estudiantes[i].Nombre = Console.ReadLine();
                Console.Write("Calificación: ");
                estudiantes[i].Calificacion = double.Parse(Console.ReadLine());
            }

            // Mostrar datos de los estudiantes
            Console.WriteLine("\nEstudiantes y Calificaciones:");
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("{0}: {1} - {2}", estudiante.Nombre, estudiante.Nombre, estudiante.Calificacion);
            }

            // Calcular el promedio de calificaciones
            double promedio = 0;
            foreach (Estudiante estudiante in estudiantes)
            {
                promedio += estudiante.Calificacion;
            }
            promedio /= estudiantes.Length;
            Console.WriteLine("\nPromedio general: {0}", promedio);

            // Buscar estudiante con la calificación más alta
            Estudiante mejorEstudiante = estudiantes[0];
            for (int i = 1; i < estudiantes.Length; i++)
            {
                if (estudiantes[i].Calificacion > mejorEstudiante.Calificacion)
                {
                    mejorEstudiante = estudiantes[i];
                }
            }
            Console.WriteLine("\nEstudiante con la calificación más alta:");
            Console.WriteLine("{0}: {1} - {2}", mejorEstudiante.Nombre, mejorEstudiante.Nombre, mejorEstudiante.Calificacion);
        }
    }
}
