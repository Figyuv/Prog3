using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalviArceDavidArielFinal.Modelo;

namespace CalviArceDavidArielFinal.UsuarioUC
{
    /// <summary>
    /// Lógica de interacción para UCComun.xaml
    /// </summary>
    public partial class UCComun : UserControl
    {
        public UCComun()
        {
            InitializeComponent();
        }
        public List<Usuario> Config = new List<Usuario>();

        void cargarLista()
        { 
            if (!File.Exists(@"D:\ListaUsuarios.txt"))
                return;
            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.Open(@"D:\ListaUsuarios.txt", FileMode.Open);
            List<Usuario> DatosCargados = (List<Usuario>)BF.Deserialize(Archivo);
            Archivo.Close();
            Config = DatosCargados;
        }
        void agregarUsuario()
        {
            Conferencia conferencia = new Conferencia()
            {
                Id = 1,
                Name = "Tecnologias Emergentes",
                Inicio = DateTime.Now,
                Final = DateTime.Now,
                Asistentes = 10
            };
            List<string> Conferencias = new List<string>();
            Conferencias.Add(conferencia.Name);
            Config.Add(new Usuario()
            {
                Id = 1,
                Name = "Jose",
                Conferencias = Conferencias

            });

            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.OpenWrite(@"D:\ListaUsuarios.txt");
            BF.Serialize(Archivo, Config);
            Archivo.Close();

        }
        void loadData()
        {
            foreach (var conferencia in Config)
            {
                dgvUsers.Items.Add(conferencia.Name);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            cargarLista();
            loadData();
        }

        private void btnAddConf_Click(object sender, RoutedEventArgs e)
        {
            AgregarAsistencia agregarAsistencia = new AgregarAsistencia();
            agregarAsistencia.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
