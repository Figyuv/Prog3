using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041322_EjemplosLambda
{
    delegate void mar();
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main1();
            Main2();
            Console.ReadKey();
        }
        static void Main2()
        {
            var users = new List<Usuer>();
            for (int i = 0; i < 21; i++)
            {
                users.Add(new Usuer
                    { 
                    Id =i,
                    Name=$"User {i}",
                    Age=i*3,
                    Genre=i%2==0?1:0
                });
            }
            Action<List<Usuer>> showCollection = (collection) =>
            {
                foreach (var user in collection)
                {
                    Console.WriteLine($"{user.Name} Edad:{user.Age} IsOlder? {user.IsOlder} Genero: {user.Genre} {user.GenreForView}");
                }
                Console.WriteLine("=====================================================================");
            };
            Action<List<Usuer>> countCollection = (collection) =>
            {
                Console.WriteLine($"Number of users: {users.Count()}");
            };
            //Ordenar por genero
            //users = users.OrderBy(x => x.Genre).ToList();showCollection(users);

            //Ordenar por edad
            //users = users.OrderByDescending(x=> x.IsOlder).ToList(); showCollection(users);

            //Solo hombres
            //users = users.Where(x => x.Genre==1).ToList(); showCollection(users); countCollection(users);

            //Solo 5
            var temp = users.Take(5).ToList();
            //showCollection(temp);
            showCollection(users);
            
            //Agrupando por genero
            //var groupByGenre = users.GroupBy(x=>x.GenreForView).Select(x => new {Genero = x.Key, Total = x.Count()}).ToList();
            //foreach(var item in groupByGenre)
            //{
            //    Console.WriteLine(item.Genero + "  Total: " + item.Total);
            //}

            var groupByGenreObject = users.GroupBy(x => x.GenreForView).Select(x =>
                    new UserByGenre { Genre = x.Key, Total = x.Count(), Users = x.Where(y => y.GenreForView==x.Key).ToList() }).ToList();
            foreach (var item in groupByGenreObject)
            {
                Console.WriteLine(item.Genre + "  Total: " + item.Total);
                showCollection(item.Users);
            }
        }
        static void Main1()
        {
            //MULTIPLICA UN NUMERO POR 2
            Func<int, int> b = (n) => n * 2;
            int res = b(10);
            Console.WriteLine(res);

            //SUMA 2 NUMEROS
            Func<int, int, int> b1 = (a, c) => a + c;
            int res1 = b1(2, 4);
            Console.WriteLine(res1);

            //VERIFICA SI UN NUMERO ES IGUAL A 5
            Func<int, bool> op = x => x == 5;
            bool das = op(5);
            Console.WriteLine(das);

            //COMPARA 2 NUMEROS
            Func<int, int, bool> op1 = (y, z) => y == z;
            das = op1(3, 3);
            Console.WriteLine(das);

            //VERIFICA SI EL LARGO DE UNA CADENA ES MAYOR A X
            Func<int, string, bool> op2 = (x, s) => s.Length > x;
            das = op2(7, "Hola");
            Console.WriteLine(das);

            //
            int x1 = 0;
            mar d1 = () => x1 = 10;
            d1();
            Console.WriteLine(x1);

            Action<int> print = num => Console.WriteLine(num);


            Func<int, int, int> compare = (x, y) => x > y ? x : y;
            print(compare(3, 4));
            //
            var numeros = new List<int> { 54, 4, 3, 44, 6, 8, 9, 2 };
            Func<int, bool> par = numero => numero % 2 == 0;
            var pares = numeros.Where((numero) => numero % 2 == 0);
            //DEVUELVE LOS PARES DE LA LISTA


            //----------------------------------------------
            Func<int, Func<int, int>, int> compleja = (num1, funcion) =>
            {
                if (num1 < 10)
                    return funcion(num1);
                else
                    return num1;
            };
            int res2 = compleja(8, n => n * 2);
            print(res2);
            //-----------------------------------------------------------
            List<string> names = new List<string>()
            {
                "jose","juan","pedro","maria","natalia","maite","andres"
            };
            names.RemoveAll(name => name.StartsWith("j"));
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            //------------------------------------------------------

            int[] nums = { 3, 2, 34, 6, 3, 1, 4, 6, 3, 2, 5, 6, 9 };
            var variable = nums.TakeWhile((n, ind) => n >= ind);
            foreach (var item in variable)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
