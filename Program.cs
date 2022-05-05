using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Universidad", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogota");
            
            escuela.Cursos = new Curso[] {
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301" }
            };

            ImprimirCursosEscuela(escuela);
            WriteLine(escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("=====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("=====================");

            if (escuela?.Cursos != null) // escuela?.Cursos != Null es lo mismo que
            //escuela != Null && escuela.Cursos != Null
            { 
                foreach (var curso in escuela.Cursos){
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }
        }
    }
}