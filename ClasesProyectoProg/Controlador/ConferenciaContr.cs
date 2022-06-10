using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesProyectoProg.Modelo;
using ClasesProyectoProg.Vista;

namespace ClasesProyectoProg.Controlador
{
    public class ConferenciaContr
    {
        private Conferencia modelo;
        private ConferenciaView vista;

        public void UserController(Conferencia modelo, ConferenciaView vista)
        {
            this.modelo = modelo;
            this.vista = vista;
        }
        public void setUsuario(Conferencia conferencia)
        {
            modelo.Id = conferencia.Id;
            modelo.Name = conferencia.Name;
            modelo.Inicio = conferencia.Inicio;
            modelo.Final = conferencia.Final;
            modelo.Asistentes = conferencia.Asistentes;
        }
        public string getConferencia()
        {
            return $"Id: {modelo.Id} Nombre: {modelo.Name}";
        }
        public void updateView()
        {
            vista.showConfferenceDetails(modelo.Id, modelo.Name, modelo.Inicio, modelo.Final, modelo.Asistentes);
        }
    }
}
