﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesProyectoProg.Modelo;
using ClasesProyectoProg.Vista;

namespace ClasesProyectoProg.Controlador
{
    public class UsuarioContr
    {
        private Usuario modelo;
        private UsuarioView vista;

        public UsuarioContr(Usuario modelo, UsuarioView vista)
        {
            this.modelo = modelo;
            this.vista = vista;
        }

        public void setUsuario(Usuario usuario)
        {
            modelo.Id = usuario.Id;
            modelo.Name = usuario.Name;
            modelo.Rol = usuario.Rol;
            modelo.Conferencias = usuario.Conferencias;
        }
        public string getUsuario()
        {
            return $"Id: {modelo.Id} Nombre: {modelo.Name}";
        }
        public void updateView()
        {
            vista.showUserDetails(modelo.Id, modelo.Name, modelo.Rol, modelo.Conferencias);
        }
    }
}
