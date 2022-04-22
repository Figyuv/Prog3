using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviDavid_Lambda
{
    internal class Program
    {
        static Turista[] turistas = {
         new Turista(123,"Elias Andrade","TA",4),
         //new Turista(123,"Elias Andrade","TA",3),
         new Turista(234,"Moira Alen","TA",2),
         new Turista(345,"Lony Labbe","TG",8),
         new Turista(456,"Sidney Sommer","TA",3),
         new Turista(567,"Ari Hass","TG",8),
         new Turista(678,"Rita Asis","TC",5),
         new Turista(789,"Marco Esteves","TA",3),
         new Turista(890,"Julia Lang","TG",6),
         new Turista(901,"Ingrid RamosAsis","TC",5),
         new Turista(012,"Erick Kolbe","TP",1)};

        static Tour[] excursiones = {
         new Tour("TA","Turismo Aventura","Magic Tours"),
         new Tour("TG","Turismo Gastronómico","Turismo Kronos"),
         new Tour("TC","Turismo Compras","Eva's Tours Co."),
         new Tour("TP","Turismo Paseos","Alex Tours")};

        static Lugar[] lugares = {
         new Lugar("PV","Puerto Varas",4),
         new Lugar("BRLCH","Bariloche",3),
         new Lugar("BRA","Rio de Janeiro",3),
         new Lugar("CHLT","Chalten",1),
         new Lugar("PA","Punta Arenas",5),
         new Lugar("PN","Puerto Natales",8),
         new Lugar("VAL","Valdivia",6),
         new Lugar("BA","Buenos Aires",2),
         new Lugar("SP","San Pablo",1),
         new Lugar("FLO","Florianópolis",2)
         };

        static Turista_Lugar[] turista_visita = {
         new Turista_Lugar(123,"BRLCH"),
         new Turista_Lugar(123,"PV"),
         new Turista_Lugar(123,"BRA"),
         new Turista_Lugar(123,"FLO"),
         new Turista_Lugar(234,"SP"),
         new Turista_Lugar(234,"BA"),
         new Turista_Lugar(345,"PN"),
         new Turista_Lugar(345,"VAL"),
         new Turista_Lugar(456,"BRA"),
         new Turista_Lugar(456,"BA"),
         new Turista_Lugar(567,"PN"),
         new Turista_Lugar(678,"PA"),
         new Turista_Lugar(678,"PV"),
         new Turista_Lugar(789,"BRA"),
         new Turista_Lugar(789,"SP"),
         new Turista_Lugar(789,"FLO"),
         new Turista_Lugar(890,"VAL"),
         new Turista_Lugar(890,"BRLCH"),
         new Turista_Lugar(901,"PA"),
         new Turista_Lugar(012,"CHLT")};

        static Paquete[] paquetes = {
         new Paquete(1,"Básico"),
         new Paquete(2,"Económico"),
         new Paquete(3,"Estandar"),
         new Paquete(4,"Jubilados"),
         new Paquete(5,"Familiar"),
         new Paquete(6,"Todo incluido"),
         new Paquete(7,"Extra"),
         new Paquete(8,"Vip")};
        static void Main(string[] args)
        {
            ej1();
            ej2("Puerto Varas");
            ej3("Estandar");
            ej4("Elias Andrade");
            ej5();
            ej6();
            ej7();
            ej8();
            ej9();
            ej10();
            Console.ReadKey();
        }

        static void ej1()
        {
            var newT = turistas;
            foreach(var t in excursiones)
            {
                Console.WriteLine(t.NombreTo);
                var group = newT.Where(x => x.CodTo == t.CodTo).ToList();
                foreach(var t2 in group)
                {
                    Console.WriteLine("\t"+t2.NombreT);
                }
            }
        }
        static void ej2(string lugar)
        {
            var visT = turista_visita;
            var newT = turistas;

            foreach (var l in lugares)
            {
                if (l.NombreL == lugar)
                {
                    var list = newT.Join(visT, x => x.CIT, y => y.CIT, (t1, t2) => new { ci = t1.CIT, nombre = t1.NombreT, cod = t2.CodL }).ToList().Where(e => e.cod == l.CodL).ToList();
                    foreach (var t2 in list)
                    {
                        Console.WriteLine(t2.nombre);
                    }
                }
            }

        }
        static void ej3(string paquete)
        {
            foreach(var p in paquetes)
            {
                if (p.NombreP == paquete)
                {
                    var list = lugares.Join(paquetes, x=>x.CodP, y=>y.CodP, (x, y) => new {nombre = x.NombreL,paq=y.CodP}).Where(e=>e.paq==p.CodP).ToList();
                    foreach (var t in list)
                    {
                        Console.WriteLine(t.nombre);
                    }
                }
            }
        }
        static void ej4(string turista)
        {
            foreach( var t in turistas)
            {
                if(t.NombreT == turista)
                {
                    var resp = excursiones.Where(e => e.CodTo == t.CodTo).ToList();
                    foreach( var r in resp)
                    {
                        Console.WriteLine(r.RespTo);
                    }
                        
                    
                }
            }
        }
        static void ej5()
        {
            foreach (var ex in excursiones)
            {
                var list = excursiones.Join(turistas, x => x.CodTo, y => y.CodTo, (x, y) => new { nombreTo = x.NombreTo, codTo = x.CodTo, nombreT = y.NombreT }).ToList()
                    .Where(e=>e.codTo==ex.CodTo);
                Console.WriteLine(ex.RespTo);
                foreach (var t in list)
                {
                    Console.WriteLine("\t"+t.nombreT);
                }
            }
        }
        static void ej6()
        {
            var list = turistas.Join(turista_visita, x => x.CIT, y => y.CIT, (x, y) => new { turista = x.NombreT, ciT = x.CIT, codL = y.CodL })
                .Join(lugares, x => x.codL, y => y.CodL, (x, y) => new { nomT = x.turista, nomL = y.NombreL, ci = x.ciT }).GroupBy(e => e.nomL).ToList();

            foreach(var t in list)
            { 
                Console.WriteLine(t.Key);
                foreach(var j in t)
                {
                    Console.WriteLine("\t"+j.nomT);
                }
            }
        }
        static void ej7()
        {
            var list = turistas.Join(turista_visita, x => x.CIT, y => y.CIT, (x, y) => new { turista = x.NombreT, ciT = x.CIT, codL = y.CodL })
                .Join(lugares, x => x.codL, y => y.CodL, (x, y) => new { nomT = x.turista, nomL = y.NombreL, ci = x.ciT }).GroupBy(e => e.nomL).ToList();
            foreach (var t in list)
            {
                Console.WriteLine(t.Key + " Cantidad: " +t.Count());
            }
        }
        static void ej8()
        {
            var list = turistas.Join(paquetes, x => x.CodP, y => y.CodP, (x, y) => new { turista = x.NombreT, paq = y.NombreP }).GroupBy(e => e.paq).ToList();
            foreach (var t in list)
            {
                Console.WriteLine(t.Key);
                foreach (var x in t)
                {
                    Console.WriteLine("\t" + x.turista);
                }
            }
        }
        static void ej9()
        {
            bool verf = false;
            var list = turistas.GroupBy(e=>e.CodP).Where(e=>e.Count()>1);
            foreach(var t in list)
            {
                foreach( var x in t)
                {
                    var aux = turistas.Where(e=>e.CIT==x.CIT).ToList();
                    if(aux.Count()>1)
                        Console.WriteLine("El turista: " + x.NombreT+" esta registrado en mas de un paquete"); verf=true;
                }
            }
            if (verf)
                Console.WriteLine("No existe ningun turista registrado en mas de un paquete");
        }
        static void ej10()
        {
            var list = turistas.Join(excursiones, x=>x.CodTo, y=>y.CodTo, (x, y) => new {codTo=y.CodTo,nomTo=y.NombreTo, nomT=x.NombreT,ci=x.CIT}).GroupBy(e=>e.nomTo)
                .ToList().OrderByDescending(e=>e.Count());
            //var list = turistas.GroupBy(e => e.CodTo).ToList().OrderByDescending(e=>e.Key.Count());
            foreach (var t in list)
            {
                Console.WriteLine(t.Key+": "+t.Count());
                foreach( var x in t)
                {
                    Console.WriteLine("\t"+x.nomT);
                }
            }
            
        }
    }
}
