using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ListaDeAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            //SE CREA LA LISTA
            List<alumno> lista = new List<alumno>();
            //SE AÑADE SU CONTENIDO
            lista.Add(new alumno("Valentino", "Casadidio", 43576343, 7.5f));
            lista.Add(new alumno("Ivo", "Perez", 43577312, 5.5f));
            lista.Add(new alumno("Tomas", "Draese", 43576435, 7.0f));
            lista.Add(new alumno("Martin", "Corallo", 43576353, 6.0f));
            lista.Add(new alumno("Francisco", "Cumino", 43576567, 8.0f));
            //SE MUESTRA LA LISTA
            foreach (alumno Aalumno in lista)
            {
                Console.WriteLine("nombre: "+ Aalumno.nombre + " apellido: " + Aalumno.apellido + " dni: " + Aalumno.dni + " promedio: " + Aalumno.promedio);
            }
        }
    }

    public class alumno
    {
        public int dni;
        public string nombre;
        public string apellido;
        public float promedio;
        public alumno(string nom, string ape, int d, float prom)
        {
            dni = d;
            nombre = nom;
            apellido = ape;
            promedio = prom;
        }
    }
}
