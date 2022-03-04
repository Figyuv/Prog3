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
using Microsoft.VisualBasic;

namespace _020422Praactica3Recursividad
{
    /// <summary>
    /// Lógica de interacción para Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, RoutedEventArgs e)
        {
            string word = txtIn.Text;
            string word2 = Reverse(word);
            //MessageBox.Show(word2);
            Palindromo(word, word2, true);

        }
        void Palindromo(string word, string word2, bool final)
        {

            if (word.Length==0)
            {
                if (final==true)
                {
                    txtOut.Text = ("Es un palindromo");
                }
                else
                {
                    txtOut.Text = ("No es un palindromo");
                }
                
            }
            else if (word.Length>0)
            {
                if (word.Substring(0, word.Length) == word2.Substring(0, word2.Length))
                {
                    word = word.Substring(0, word.Length - 1);
                    word2 = word2.Substring(0, word2.Length - 1);
                    final = true;
                    Palindromo(word, word2, final);
                }
                else
                {
                    final = false;
                    word = "";
                    Palindromo(word, word2, final);
                }
            }

        }
        string Reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
