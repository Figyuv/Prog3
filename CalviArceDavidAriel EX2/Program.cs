using System;
using System.Collections.Generic;
using System.Linq;
namespace PracticaLinq
{

    class MainClass
    {


        static Estudiante[] estudiantes = {
                new Estudiante(123, "Jose Costas", "ISI", 4),
                new Estudiante(234, "Carla Mendez", "ISI", 2),
                new Estudiante(345, "Lony Lopez", "IBI", 8),
                new Estudiante(456, "Elio Sierra", "ISI", 3),
                new Estudiante(567, "Jorge Andrade", "IBI", 8),
                new Estudiante(678, "Erika Herbas", "IEL", 5),
                new Estudiante(789, "Marco Ignacio", "ISI", 3),
                new Estudiante(890, "Jose Heredia", "IBI", 6),
                new Estudiante(901, "Ingrid Asis", "IEL", 5),
                new Estudiante(012, "Abel Illanes", "MED", 1), };

        static Carrera[] carreras = {

                new Carrera("ISI", "Ingenieria de Sistemas Informáticos", "DirISI"),
                new Carrera("IBI", "Ingenieria Biomedica", "DirIBI"),
                new Carrera("IEL", "Ingenieria Electronica", "DirIEL"),
                new Carrera("MED", "Medicina", "DirMED") };

        static Materia[] materias = {
                new Materia("PRO4","Programacion IV",4),
                new Materia("PRO3","Programacion III",3),
                new Materia("EDD","Estructura de datos",3),
                new Materia("CMP1","Computación",1),
                new Materia("CIR3","Circuitos III",5),
                new Materia("PRO1b","Programacion I",8),
                new Materia("CIR4","Circuitos IV",6),
                new Materia("PRO2","Programacion II",2),
                new Materia("PRO1a","Programacion I",1),
                new Materia("CAL2","Calculo II",2)};

        static Est_Mat[] estMaterias = {
            new Est_Mat(123, "PRO3"),
            new Est_Mat(123, "PRO4"),
            new Est_Mat(123, "EDD"),
            new Est_Mat(123, "CAL2"),
            new Est_Mat(234, "PRO1a"),
            new Est_Mat(234, "PRO2"),
            new Est_Mat(345, "PRO1b"),
            new Est_Mat(345, "CIR4"),
            new Est_Mat(456, "EDD"),
            new Est_Mat(456, "PRO2"),
            new Est_Mat(567, "PRO1b"),
            new Est_Mat(678, "CIR3"),
            new Est_Mat(678, "PRO4"),
            new Est_Mat(789, "EDD"),
            new Est_Mat(789, "PRO1a"),
            new Est_Mat(789, "CAL2"),
            new Est_Mat(890, "CIR4"),
            new Est_Mat(890, "PRO3"),
            new Est_Mat(901, "CIR3"),
            new Est_Mat(012, "CMP1") };
        static void Main(string[] args)
        {
            ej1();
            ej2();
            ej3();
            ej4();
            Console.ReadKey();
        }

        static void ej1()
        {
            Console.WriteLine("Dado el nombre de un director, mostrar los estudiantes que estudian esa carrera\nIntroducir nombre del director");
            string director = Console.ReadLine();
            var lstEst = from c in carreras
                         join e in estudiantes on c.codCarr equals e.codCarr
                         where c.nombreDir == director
                         select e.nombreEst;
            Console.WriteLine("\nLos siguientes estudiantes estan en la carrera con el director: "+director); 
            foreach (var est in lstEst)
            {
                Console.WriteLine(est);
            }
        }
        static void ej2()
        {
            var porMateria = from m in materias
                             join em in estMaterias on m.CodMateria equals em.IdMateria
                             join e in estudiantes on em.CI equals e.CI
                             group e by m.NomMateria;
            Console.WriteLine("\nMostrar los nombres de estudiantes por cada materia. ");
            foreach (var m in porMateria)
            {
                Console.WriteLine("Materia: " + m.Key);
                foreach(var n in m)
                {
                    Console.WriteLine(n.nombreEst);
                }
            }
        }
        static void ej3()
        {
            var porCarrera = from c in carreras
                             join e in estudiantes on c.codCarr equals e.codCarr
                             group e by c.nombreCarr;
            Console.WriteLine("\nMostrar el nombre de cada carrera junto a los nombres de sus respectivos estudiantes.");
            foreach( var c in porCarrera)
            {
                Console.WriteLine("Nombre de la carrera: "+c.Key);
                foreach( var n in c)
                {
                    Console.WriteLine(n.nombreEst);
                }
            }
        }
        static void ej4()
        {
            Console.WriteLine("Dado el nombre de una materia mostrar los nombres de estudiantes inscritos en ella.\nIntroducir nombre de la materia");
            string carrera = Console.ReadLine();
            var lstEst = from m in materias
                         join me in estMaterias on m.CodMateria equals me.IdMateria
                         join e in estudiantes on me.CI equals e.CI
                         where m.NomMateria == carrera
                         select e.nombreEst;
            Console.WriteLine("\nLos siguientes estudiantes estan inscritos en la materia: "+carrera);
            foreach( var m in lstEst)
            {
                Console.WriteLine(m);
            }
        }
    }
}
