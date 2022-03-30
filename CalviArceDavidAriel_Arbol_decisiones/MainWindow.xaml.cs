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
using Microsoft.VisualBasic;

namespace CalviArceDavidAriel_Arbol_decisiones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
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

        private void btnIniciarCustionario_Click(object sender, RoutedEventArgs e)
        {
            ab.Cuestionario(delegadoMostrar);
        }

        void CargarPreguntas()
        {
            //derecha NO
            //izquierda SI
            ab.insertar("Quiere un Ordenador de sobre mesa?", 1500);

            //Pregunatas para comprar una laptop
            ab.insertar("Su presupuesto es menor a 2000$?", 2000);
            //Precio mayor a 2000$
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
            ab.insertar("Puede comprarse un MacBook Pro 16'(2499$)", 1501);
            ab.insertar("Puede comprarse un Dell G15 Gaiming(2999$)", 1503);
            //Precio menor a 2000$
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

            //Preguntas para comprar una pc de sobre mesa
            //Precio mayor a 2000$
            ab.insertar("Su presupuesto es menor a 2000$?", 1000);
            ab.insertar("Piensa usarlo para trabajo?", 1200);
            ab.insertar("Prioriza la estetica?", 1275);
            ab.insertar("Puede comprarse un MSI Stealth GS6612UGS-002XE(2600$)", 1280);
            ab.insertar("Puede comprarse un Razer Blade 14(3000$)", 1270);
            ab.insertar("Prioriza la estetica?", 1100);
            ab.insertar("Puede comprarse un Microsoft Surface Studio 2(4200$)", 1050);
            ab.insertar("Puede comprarse un Dell XPS 15(2999$)", 1150);

            ab.insertar("Piensa usarlo para trabajo?", 600);
            ab.insertar("Prioriza la estetica?", 750);
            ab.insertar("Puede comprarse un CORSAIR ONE(4000$)", 800);
            ab.insertar("Puede comprarse un HP Envy 34(2100)", 700);
            ab.insertar("Prioriza la estetica?", 502);
            ab.insertar("Puede comprarse unHP Envy 32-a1001ng(2500$)", 501);
            ab.insertar("Puede comprarse un Dell G15 Gaiming(2999$)", 503);
            //Precio menor a 2000$
            ab.insertar("Su presupuesto es menor a 2000$?", 1000);
            ab.insertar("Piensa usarlo para trabajo?", 1500);
            ab.insertar("Prioriza la estetica?", 1650);
            ab.insertar("Puede comprarse un MSI Stealth GS6612UGS-002XE(2600$)", 800);
            ab.insertar("Puede comprarse un Razer Blade 14(3000$)", 1700);
            ab.insertar("Prioriza la estetica?", 1250);
            ab.insertar("Puede comprarse un Acer Aspire C22-1695(600$)", 1200);
            ab.insertar("Puede comprarse un HP All-in-One 22-df0005ns(500$)", 1300);

            ab.insertar("Piensa usarlo para trabajo?", 600);
            ab.insertar("Prioriza la estetica?", 750);
            ab.insertar("Puede comprarse un Lenovo V30a-24IIL(700$)", 800);
            ab.insertar("Puede comprarse un Lenovo Legion y540(3000$)", 700);
            ab.insertar("Prioriza la estetica?", 502);
            ab.insertar("Puede comprarse un MSI Modern AM241P 11M-001EU(1300$)", 501);
            ab.insertar("Puede comprarse un Dell OptiPlex 7490 AIO(1100$)", 503);
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
                respuesta = int.Parse(Interaction.InputBox(cadena, "Escriba NO para No y 1 para SI"));
                if (respuesta == 0)
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
