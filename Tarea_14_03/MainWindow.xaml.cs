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

namespace Tarea_14_03
{
    public delegate bool Del(int peso, string cadena, bool conclusion);
    public partial class MainWindow : Window
    {
        Arbol ab = new Arbol();
        Del delegadoMostrar;
        public MainWindow()
        {
            InitializeComponent();
            delegadoMostrar += VisualizarPregunta;
            CargarPreguntas();
            Visualizar();
        }
        void CargarPreguntas()
        {
            //derecha NO
            //izquierda SI
            ab.insertar("Quiere un Ordenador de sobre mesa?",1500);


            ab.insertar("Su presupuesto es menor a 2000$?", 2000);
            ab.insertar("Piensa usarlo para trabajo?", 2500);
            ab.insertar("Prioriza la estetica?", 2750);
            ab.insertar("Puede comprarse un MSI Stealth GS6612UGS-002XE(2600$)",2800);
            ab.insertar("Puede comprarse un Razer Blade 14(3000$)",2700);
            ab.insertar("Prioriza la estetica?", 2250);
            ab.insertar("Puede comprarse un MacBook Pro 16'(2499$)", 2200);
            ab.insertar("Puede comprarse un Dell XPS 15(2999$)", 2300);

            ab.insertar("Piensa usarlo para trabajo?", 1600);
            ab.insertar("Prioriza la estetica?", 1750);
            ab.insertar("Puede comprarse un Acer Predator Helios 300(1500$)", 1800);
            ab.insertar("Puede comprarse un Lenovo Legion y540(3000$)", 1700);
            ab.insertar("Prioriza la estetica?", 1502);
            ab.insertar("Puede comprarse un MacBook Pro 13'(2499$)", 1501);
            ab.insertar("Puede comprarse un Dell G15 Gaiming(2999$)", 1503);


            ab.insertar("Su presupuesto es menor a 2000$?", 2000);
            ab.insertar("Piensa usarlo para trabajo?", 2500);
            ab.insertar("Prioriza la estetica?", 2750);
            ab.insertar("Puede comprarse un MSI Stealth GS6612UGS-002XE(2600$)", 2800);
            ab.insertar("Puede comprarse un Razer Blade 14(3000$)", 2700);
            ab.insertar("Prioriza la estetica?", 2250);
            ab.insertar("Puede comprarse un MacBook Pro 16'(2499$)", 2200);
            ab.insertar("Puede comprarse un Dell XPS 15(2999$)", 2300);

            ab.insertar("Piensa usarlo para trabajo?", 1600);
            ab.insertar("Prioriza la estetica?", 1750);
            ab.insertar("Puede comprarse un Acer Predator Helios 300(1500$)", 1800);
            ab.insertar("Puede comprarse un Lenovo Legion y540(3000$)", 1700);
            ab.insertar("Prioriza la estetica?", 1502);
            ab.insertar("Puede comprarse un MacBook Pro 13'(2499$)", 1501);
            ab.insertar("Puede comprarse un Dell G15 Gaiming(2999$)", 1503);


        }
        void Visualizar()
        {
            List<Nodo> listaResultante = ab.mostrar();
            lstShow.Items.Clear();
            foreach (Nodo nodo in listaResultante)
            {
                lstShow.Items.Add(nodo.elemento + " peso:" + nodo.numero);
            }
        }

        private void btnIniciarCustionario_Click(object sender, RoutedEventArgs e)
        {
            ab.Cuestionario(delegadoMostrar);
        }
        public bool VisualizarPregunta(int peso, string cadena, bool conclusion)
        {
            int respuesta;
            if (conclusion)
            {
                MessageBox.Show(cadena.ToUpper());
                return false;
            }
            else
            {
                respuesta = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(cadena, "Escriba NO para No y 1 para SI"));
                if(respuesta == 0) 
                { 
                    return false; 
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
