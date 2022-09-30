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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int contadorCaracteres = 0;
        int ultimoTamaño;
        public MainWindow()
        {
            InitializeComponent();
            ultimoTamaño = texto_TextBlock.Text.Length;
            contador_TextBlock.Text = $"{contadorCaracteres} / 140";
        }

        private void texto_TextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            int tamActual = texto_TextBlock.Text.Length;
            if (ultimoTamaño > tamActual) contadorCaracteres--;
            else contadorCaracteres++;

            if (tamActual >= 140) texto_TextBlock.IsReadOnly = true;

            ultimoTamaño = tamActual;
            contador_TextBlock.Text = $"{contadorCaracteres} / 140";
        }


        private void texto_TextBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                texto_TextBlock.Text = texto_TextBlock.Text + "\n";
                ultimoTamaño++;
                texto_TextBlock.CaretIndex = ultimoTamaño;
            }

        }
    }
}
