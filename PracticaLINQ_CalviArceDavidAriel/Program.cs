using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticaLinq
{
    
    class MainClass
    {
        public void cargar()
        {
            
        }
        static Turista[] turistas = {
                new Turista(123,"Elias Andrade","TA",4),
                new Turista(234,"Moira Alen","TA",2),
                new Turista(345,"Lony Labbe","TG",8),
                new Turista(456,"Sidney Sommer","TA",3),
                new Turista(567,"Ari Hass","TG",8),
                new Turista(678,"Rita Asis","TC",5),
                new Turista(789,"Marco Esteves","TA",3),
                new Turista(890,"Julia Lang","TG",6),
                new Turista(901,"Ingrid RamosAsis","TC",5),
                new Turista(012,"Erick Kolbe","TP",1)
            };
        static Tour[] excursiones = {
                new Tour("TA", "Turismo Aventura", "Magic Tours"),
                new Tour("TG", "Turismo Gastronómico", "Turismo Kronos"),
                new Tour("TC", "Turismo Compras", "Eva's Tours Co."),
                new Tour("TP", "Turismo Paseos", "Alex Tours")
            };
        static Lugar[] lugares = {
                new Lugar("PV", "Puerto Varas", 4),
                new Lugar("BRLCH", "Bariloche", 3),
                new Lugar("BRA", "Rio de Janeiro", 3),
                new Lugar("CHLT", "Chalten", 1),
                new Lugar("PA", "Punta Arenas", 5),
                new Lugar("PN", "Puerto Natales", 8),
                new Lugar("VAL", "Valdivia", 6),
                new Lugar("BA", "Buenos Aires", 2),
                new Lugar("SP", "San Pablo", 1),
                new Lugar("FLO", "Florianópolis", 2)
            };
        static Turista_Lugar[] turista_visita = {
                new Turista_Lugar(123, "BRLCH"),
                new Turista_Lugar(123, "PV"),
                new Turista_Lugar(123, "BRA"),
                new Turista_Lugar(123, "FLO"),
                new Turista_Lugar(234, "SP"),
                new Turista_Lugar(234, "BA"),
                new Turista_Lugar(345, "PN"),
                new Turista_Lugar(345, "VAL"),
                new Turista_Lugar(456, "BRA"),
                new Turista_Lugar(456, "BA"),
                new Turista_Lugar(567, "PN"),
                new Turista_Lugar(678, "PA"),
                new Turista_Lugar(678, "PV"),
                new Turista_Lugar(789, "BRA"),
                new Turista_Lugar(789, "SP"),
                new Turista_Lugar(789, "FLO"),
                new Turista_Lugar(890, "VAL"),
                new Turista_Lugar(890, "BRLCH"),
                new Turista_Lugar(901, "PA"),
                new Turista_Lugar(012, "CHLT")
            };
        static Paquete[] paquetes = {
                new Paquete(1,"Básico"),
                new Paquete(2,"Económico"),
                new Paquete(3,"Estandar"),
                new Paquete(4,"Jubilados"),
                new Paquete(5,"Familiar"),
                new Paquete(6,"Todo incluido"),
                new Paquete(7,"Extra"),
                new Paquete(8,"Vip")
            };

        static void Main(string[] args)
        {
            //ej1();
            //ej2("Rio de Janeiro");
            //ej3("Básico");
            //ej4("Elias Andrade");
            //ej5();
            //ej6();
            //ej7();
            //ej8();
            //ej9();
            ej10();
            Console.ReadKey();
        }
        static void ej1()
        {
            var perTour = from t in turistas
                          join e in excursiones on t.codTo equals e.codT
                          group t by t.codTo;
            foreach(var i in perTour)
            {
                Console.WriteLine("Tour " + i.Key);
                foreach (var j in i)
                {
                    Console.WriteLine(" " + j.nombreT);
                }
            }
        }
        static void ej2(string cadena)
        {
            var perPlace = from l in lugares
                           join tl in turista_visita on l.codL equals tl.codL
                           join t in turistas on tl.ci equals t.ci
                           where l.nombreL == cadena
                           select t;
            foreach(var i in perPlace)
            {
                Console.WriteLine(i.nombreT+" visitara el lugar que indico");

            }
        }
        static void ej3(string paq)
        {
            var perPack = from p in paquetes
                          join l in lugares on p.codP equals l.codP
                          where p.nombreP == paq
                          select l;
            foreach(var i in perPack)
            {
                Console.WriteLine("Se visitara: "+i.nombreL);
            }
        }
        static void ej4(string turis)
        {
            var responsable = from t in turistas
                              join e in excursiones on t.codTo equals e.codT
                              where t.nombreT == turis
                              select e;
            foreach(var i in responsable)
            {
                Console.WriteLine(i.responsableTo + " es responsable del tour");
            }
        }
        static void ej5()
        {
            var responsable = from e in excursiones
                              join t in turistas on e.codT equals t.codTo
                              select t.nombreT +"-"+ e.responsableTo;
            foreach(var i in responsable)
            {
                Console.WriteLine(i);
            }

        }
        static void ej6()
        {
            var totTuri = from t in turistas
                          join tl in turista_visita on t.ci equals tl.ci
                          join l in lugares on tl.codL equals l.codL
                          group t by l.nombreL;
            foreach( var l in totTuri)
            {
                Console.WriteLine(">"+l.Key);
                foreach(var i in l)
                {
                    Console.WriteLine("  " + i.nombreT);
                }
            }
        }
        static void ej7()
        {
            var numPerP= from t in turistas
                         join tl in turista_visita on t.ci equals tl.ci
                         join l in lugares on tl.codL equals l.codL
                         group t by l.nombreL;
            foreach(var l in numPerP)
            {
                Console.WriteLine(l.Key);
                Console.WriteLine("\t"+l.Count());
            }
        }
        static void ej8()
        {
            var namePack = from p in paquetes
                           join t in turistas on p.codP equals t.codP
                           group t by p.nombreP;
            foreach ( var i in namePack)
            {
                Console.WriteLine(i.Key);
                foreach(var j in i)
                {
                    Console.WriteLine("\t"+j.nombreT);
                }
            }
        }
        static void ej9()
        {
            var moreOne = from t in turistas
                                       join p in paquetes
                                       on t.codP equals p.codP
                                       group t by p.nombreP
                                       into temp
                                       where temp.Count() > 1
                                       select temp;

            Console.WriteLine("Ningun usuario tiene registrado mas de un paquete");
            
        }
        static void ej10()
        {
            var totalTo = from t in turistas
                          join e in excursiones on t.codTo equals e.codT
                          group t by e.codT into count
                          orderby count.Count() descending
                          select new { Tours = (from e in excursiones
                                                where e.codT == count.Key
                                                select e.nombreTo).FirstOrDefault(), Count = count.Count() };
                          
            foreach ( var i in totalTo)
            {
                Console.WriteLine("Tour: " + i.Tours + " turistas: " + i.Count);
            }
        }
    }
}
