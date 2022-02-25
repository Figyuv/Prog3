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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace BibliotecaPilasColas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Una libreria recibe pedidos por telefono
    /// Cada pedido es registrado y se atiende segun el orden de llegada
    /// Cada pedido puede solicitar varios productos de distintos tipos
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        //Instaciacion de la pila y la cola en la que se guardan los nuevos pedidos y los antiguos
        Queue<Pedido> pedido = new Queue<Pedido>();
        Stack<Pedido> completado = new Stack<Pedido>();
        public MainWindow()
        {
            InitializeComponent();
        }

        //Metodo para agregar los pedidos con los productos
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string order = txtProd.Text;
            List<string> productos = new List<string>();
            productos = order.Split(',').ToList();
            Pedido newPedido = new Pedido(int.Parse(txtTelefono.Text), productos);
            pedido.Enqueue(newPedido);
            ShowList();

        }

        //Metodo para mostrar/actualizar la lista de los pedidos pendientes
        void ShowList()
        {
            string prod="";
            lstNew.Items.Clear();
            foreach(var item in pedido)
            {
                foreach (string producto in item.Producto)
                {
                    prod = producto + " " + prod;
                }
                lstNew.Items.Add(item.Telefono + "\t" + prod);
                prod = "";
            }
            
        }

        //Metodos para mostrar/actualizar la lisata de los pedidos completados
        void ShowComplete()
        {
            string prod = "";
            lstOld.Items.Clear();
            foreach( var item in completado)
            {
                foreach (string producto in item.Producto)
                {
                    prod = producto + " " + prod;
                }
                lstOld.Items.Add(item.Telefono + "\t" + prod);
                prod = "";
            }
            
        }


        private void btnComplete_Click(object sender, RoutedEventArgs e)
        {
            completado.Push(pedido.Dequeue());
            ShowList();
            ShowComplete();
        }
    }
}
