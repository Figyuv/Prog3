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

namespace CalviArceDavid_PRG_III__A__Práctica2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Una empresa dedicada a la elaboración de comida que será distribuida a 
    /// domicilio desea presentar a sus clientes una aplicación que les permita 
    /// seleccionar de un menúposibles platos dados ciertos ingredientes. 
    /// Por ejemplo, el cliente puede requerir platos que contengan carne, pero 
    /// no papas yotrosplatos que contenganverdura y arroz.En ambos casos, los 
    /// platos pueden contener además otros ingredientes no mencionados por el 
    /// cliente.Además, cada plato tiene asociado un precio, por lo que luego 
    /// de la selección deplatos y las cantidades requeridas podrá conocer el total a pagar.
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        enum type
        {
            carne,
            verdura,
            cereal
        }
        //Declaracion de las listas
        List<Plato> menu = new List<Plato>(); 
        List<Ingrediente> allIngredients = new List<Ingrediente>();
        int idI=0;
        public MainWindow()
        {
            InitializeComponent();
            AddIngredients();
            FillCombo();
            FillMenu();
            ShowMenu();
            
        }
        public void ShowMenu()
        {
            //Mostrando la el menu de platos
            foreach (Plato platos in menu)
            {
                lstMenu.Items.Add(platos.DishName.ToUpper()+" ID:"+platos.DishId + "\t" + "\tPrecio: " + platos.DishPrice);
                foreach (Ingrediente ingredientes in platos.IngredientsList)
                {
                    lstMenu.Items.Add(ingredientes.IngredientName + "\t");
                }
                lstMenu.Items.Add("------------------------------------");
            }
        }
        public void FillMenu()
        {
            //Metodo para rellenar el menu
            menu.Clear();
            AddMenu();
        }
        public void AddMenu()
        {
            //Agregando platos con sus respectivos ingredientes
            List<Ingrediente> tacosIngredients = new List<Ingrediente>()
            {new Ingrediente(7,"Tortilla"), new Ingrediente(1,"Vaca"),new Ingrediente(2,"Pollo"),new Ingrediente(3,"Cerdo")};
            menu.Add(new Plato(0,"Tacos", 8.5, tacosIngredients));

            List<Ingrediente> burgerIngredients = new List<Ingrediente>()
            {new Ingrediente(9,"Pan"), new Ingrediente(1,"Vaca"),new Ingrediente(11,"Cebolla"),new Ingrediente(12,"Lechuga")
            ,new Ingrediente(5,"Tomate"),new Ingrediente(9,"Ketchup"),new Ingrediente(6,"Mostaza")};
            menu.Add(new Plato(1,"Hamburguesa", 10, burgerIngredients));

            List<Ingrediente> pizzaIngredients = new List<Ingrediente>()
            {new Ingrediente(12,"Harina"), new Ingrediente(5,"Tomate"),new Ingrediente(13,"Queso"),new Ingrediente(3,"Cerdo")};
            menu.Add(new Plato(2,"Pizza", 30, pizzaIngredients));

            List<Ingrediente> chickenIngredients = new List<Ingrediente>()
            {new Ingrediente(4,"Arroz"), new Ingrediente(2,"Pollo"),new Ingrediente(0,"Papa")};
            menu.Add(new Plato(3,"Pollo", 15, chickenIngredients));

        }
        public void AddIngredients()
        {
            //Agregando todos los ingredientes con los que trabaja la empresa
            allIngredients.Add(new Ingrediente(idI++, "Papa"));//0
            allIngredients.Add(new Ingrediente(idI++, "Vaca"));//1
            allIngredients.Add(new Ingrediente(idI++, "Pollo"));//2
            allIngredients.Add(new Ingrediente(idI++, "Cerdo"));//3
            allIngredients.Add(new Ingrediente(idI++, "Arroz"));//4
            allIngredients.Add(new Ingrediente(idI++, "Tomate"));//5
            allIngredients.Add(new Ingrediente(idI++, "Mostaza"));//6
            allIngredients.Add(new Ingrediente(idI++, "Tortilla"));//7
            allIngredients.Add(new Ingrediente(idI++, "Pan"));//8
            allIngredients.Add(new Ingrediente(idI++, "Ketchup"));//9
            allIngredients.Add(new Ingrediente(idI++, "Cebolla"));//10
            allIngredients.Add(new Ingrediente(idI++, "Lechuga"));//11
            allIngredients.Add(new Ingrediente(idI++, "Harina"));//12
            allIngredients.Add(new Ingrediente(idI++, "Queso"));//13
        }

        public void FillCombo()
        {
            //Llenando los 2 combo box para poder filtrar luego
            foreach (Ingrediente listaIngredientes in allIngredients)
            {
                cmbAdd.Items.Add(listaIngredientes.IngredientName);
                cmbRest.Items.Add(listaIngredientes.IngredientName);
            }
        }

        private void chngCmmAdd(object sender, SelectionChangedEventArgs e)
        {
            //borrar el item en el segundo combo box que ya fue seleccionado en el primer combobox
            cmbRest.Items.Clear();
            foreach (Ingrediente listaIngredientes in allIngredients)
            {
                cmbRest.Items.Add(listaIngredientes.IngredientName);
            }

            int asd;
            asd = cmbAdd.SelectedIndex;
            cmbRest.Items.RemoveAt(asd);

        }
        public void BorrarLista()
        {
            //Borar la lista mostrada
            lstMenu.Items.Clear();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            //Filtrando los platos segun los ingredientes seleccionados
            BorrarLista();
            if (cmbAdd.SelectedIndex!=-1 && cmbRest.SelectedIndex==-1)
            {
                foreach (Plato platos in menu)
                {
                    foreach (Ingrediente ingredientes in platos.IngredientsList)
                    {
                        if (cmbAdd.SelectedItem==ingredientes.IngredientName)
                        {
                            lstMenu.Items.Add(platos.DishName.ToUpper() + " ID:" + platos.DishId + "\t" + "\tPrecio: " + platos.DishPrice);
                            foreach (Ingrediente filtrado in platos.IngredientsList)
                            {
                                lstMenu.Items.Add(filtrado.IngredientName + "\t");
                            }
                            lstMenu.Items.Add("------------------------------------");
                        } 
                    }   
                }
            }
            else if (cmbAdd.SelectedIndex == -1 && cmbRest.SelectedIndex != -1)
            {
                int aux=0;
                int[] aux1 = new int[menu.Count];
                int count = 0;
                foreach (Plato platos in menu)
                {
                    foreach (Ingrediente ingredientes in platos.IngredientsList)
                    {
                        if (ingredientes.IngredientName==cmbRest.SelectedItem)
                        {
                            aux1[count] = aux;
                            count++;
                        }
                    }
                    aux++;
                }
                for (int i = 0; i < count; i++)
                {
                    if (aux1[i] == menu.Count)
                    {
                        menu.Remove(menu.Last());
                    }else
                    {
                        menu.RemoveAt(aux1[i]);
                    }
                }
                ShowMenu();
                FillMenu();
            }
            else if (cmbAdd.SelectedIndex != 1 && cmbRest.SelectedIndex != -1)
            {
                int aux = 0;
                int[] aux1 = new int[menu.Count];
                int count = 0;
                foreach (Plato platos in menu)
                {
                    foreach (Ingrediente ingredientes in platos.IngredientsList)
                    {
                        if (cmbAdd.SelectedItem == ingredientes.IngredientName && ingredientes.IngredientName == cmbRest.SelectedItem)
                        {
                            aux1[count] = aux;
                            count++;
                        }
                    }
                    aux++;
                }
                for (int i = 0; i < count; i++)
                {
                    if (aux1[i] == menu.Count)
                    {
                        menu.Remove(menu.Last());
                    }
                    else
                    {
                        menu.RemoveAt(aux1[i]);
                    }
                }
                foreach (Plato platos in menu)
                {
                    foreach (Ingrediente ingredientes in platos.IngredientsList)
                    {
                        if (cmbAdd.SelectedItem == ingredientes.IngredientName)
                        {
                            lstMenu.Items.Add(platos.DishName.ToUpper() + " ID:" + platos.DishId + "\t" + "\tPrecio: " + platos.DishPrice);
                            foreach (Ingrediente filtrado in platos.IngredientsList)
                            {
                                lstMenu.Items.Add(filtrado.IngredientName + "\t");
                            }
                            lstMenu.Items.Add("------------------------------------");
                        }
                    }
                } 
            }
            
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            //Resetar para ver el menu completo
            BorrarLista();
            ShowMenu();
        }

        private void btnIngredients_Click(object sender, RoutedEventArgs e)
        {
            //Para poder ver todos los ingredientes con lso que se trabajan
            BorrarLista();
            foreach(Ingrediente todos in allIngredients)
            {
                lstMenu.Items.Add(todos.IngredientName);
            }
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            //Devolucion del precio calculado del plato y cantidad que se requiere comprar
            int bid;
            int bqua;
            bid = int.Parse(txtId.Text);
            bqua = int.Parse(txtQuant.Text);
            foreach (Plato platos in menu)
            {
                if (platos.DishId == bid)
                {
                    MessageBox.Show("Cantidad a pagar: " + (platos.DishPrice * bqua));
                }else
                {
                    continue;
                }
            }
        }
    }
}
