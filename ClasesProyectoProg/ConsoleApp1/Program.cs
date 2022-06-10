using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesProyectoProg.Modelo;
using ClasesProyectoProg.Vista;
using ClasesProyectoProg.Controlador;


namespace ConsoleApp1
{
    internal class Program
    {
        List<Conferencia> conferencias;
        static void Main(string[] args)
        {
            Usuario modelo = CrearUsuario();
            UsuarioView vista = new UsuarioView();
            UsuarioContr controlador = new UsuarioContr(modelo, vista);
            controlador.updateView();
            Console.ReadKey();
        }

        static Usuario CrearUsuario()
        {
            List<Conferencia> conferencias = new List<Conferencia>();
            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Name = "Hola";
            usuario.Rol = "Comun";
            usuario.Conferencias = conferencias;
            return usuario;
        }
    }
}
