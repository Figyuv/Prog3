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
using System.IO;

namespace _02142022RetroalimentacionPractica1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 1;
        List<Producto> prodList = new List<Producto>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                prodList.Add(new Producto()
                {
                    Id =i,
                    Nombre = txtName.Text,
                    Cantidad = int.Parse(txtQuant.Text),
                    Precio = double.Parse(txtPrice.Text),
                }) ;
                i++;
                resetDG();
            }
            catch { }
            limpiar();
        }

        public void buscar(string WordS) {
            List<Producto> find = new List<Producto>();
            if (rbByName.IsChecked==true) {
                //MessageBox.Show("Searching by name ");
                foreach (Producto prod in prodList)
                { 
                    if (prod.Nombre==WordS)
                    {
                        find.Add(new Producto()
                        {
                            Id=prod.Id,
                            Nombre = prod.Nombre,
                            Cantidad = prod.Cantidad,
                            Precio = prod.Precio,
                        });
                        datagrid.ItemsSource = null;
                        datagrid.ItemsSource = find;
                    }
                }
            }
            else if (rbByPrice.IsChecked==true)
            {
                //MessageBox.Show("Searching by Price ");
                foreach (Producto prod in prodList)
                {
                    if (prod.Precio == double.Parse(WordS))
                    {
                        find.Add(new Producto()
                        {
                            Id=prod.Id,
                            Nombre = prod.Nombre,
                            Cantidad = prod.Cantidad,
                            Precio = prod.Precio,
                        });
                        datagrid.ItemsSource = null;
                        datagrid.ItemsSource = find;
                    }
                }
            }
        }

        public void limpiar()
        {
            txtName.Text = "";
            txtQuant.Text = "";
            txtPrice.Text = "";
            txtIdB.Text = "";
            txtQuaB.Text = "";
            txtSearch.Text = "";
            rbByName.IsChecked = false;
            rbByPrice.IsChecked = false;
        }
        public void resetDG()
        {
            datagrid.ItemsSource = null;
            datagrid.ItemsSource = prodList;
        }
        public void buyProd(int idB, int quaB)
        {
            foreach(Producto prod in prodList)
            {
                if (prod.Id == idB)
                {
                    if (quaB<=prod.Cantidad) 
                    { 
                        prod.Cantidad = prod.Cantidad - quaB;
                    }
                    else
                    {
                        MessageBox.Show("No hay cantidad suficiente");
                    }
                    
                }
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            buscar(txtSearch.Text);
            limpiar();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            resetDG();
            limpiar();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            buyProd(int.Parse(txtIdB.Text), int.Parse(txtQuaB.Text));
            resetDG();
            limpiar();
        }
    }
}
