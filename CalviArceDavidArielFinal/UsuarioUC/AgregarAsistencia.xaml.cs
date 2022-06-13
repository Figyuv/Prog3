using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CalviArceDavidArielFinal.Modelo;
using System.Data;

namespace CalviArceDavidArielFinal.UsuarioUC
{
    /// <summary>
    /// Lógica de interacción para AgregarAsistencia.xaml
    /// </summary>
    public partial class AgregarAsistencia : Window
    {
        public AgregarAsistencia()
        {
            InitializeComponent();
        }
        public AgregarAsistencia(Usuario usuarioGet)
        {
            InitializeComponent();
            usuario = usuarioGet;
        }

        public Usuario usuario;
        
        public List<Usuario> Usuarios = new List<Usuario>();
        public List<Conferencia> Conferencias = new List<Conferencia>();

        public void Guardar()
        {
            var Conferencia = from conf in Conferencias
                              where conf.Name == dgvConferencias.SelectedItem.ToString()
                              select conf.Name;
            usuario.Conferencias.Add(dgvConferencias.SelectedItem.ToString());


            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.OpenWrite(@"D:\ListaUsuarios.txt");
            BF.Serialize(Archivo, Usuarios);
            Archivo.Close();
        }
        void cargarListaUsuarios()
        {
            if (!File.Exists(@"D:\ListaUsuarios.txt"))
                return;
            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.Open(@"D:\ListaUsuarios.txt", FileMode.Open);
            List<Usuario> DatosCargados = (List<Usuario>)BF.Deserialize(Archivo);
            Archivo.Close();
            Usuarios = DatosCargados;
        }
        void cargarConferencias()
        {
            if (!File.Exists(@"D:\ListaConferencias.txt"))
                return;
            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.Open(@"D:\ListaConferencias.txt", FileMode.Open);
            List<Conferencia> DatosCargados = (List<Conferencia>)BF.Deserialize(Archivo);
            Archivo.Close();
            Conferencias = DatosCargados;
        }
        void loadData()
        {
            
            foreach(var conferencia in Conferencias)
            {
                dgvConferencias.Items.Add(conferencia.Name);
            }
        }
        public void ConferenciaGuardar()
        {
            Conferencia conferencia = new Conferencia(){
                Id = 1,
                Name = "Tecnologias Emergentes",
                Inicio = DateTime.Now,
                Final = DateTime.Now,
                Asistentes = 10
            };

            Conferencias.Add(conferencia);


            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.OpenWrite(@"D:\ListaConferencias.txt");
            BF.Serialize(Archivo, Conferencias);
            Archivo.Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ConferenciaGuardar();
            cargarConferencias();
            
            cargarListaUsuarios();
            loadData();
        }

        private void btnAsistencia_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
