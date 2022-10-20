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

namespace Ava30_Oficial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public bool botao1 = false;
        public bool botao2 = false;
        public bool botao3 = false;
        public bool botao4 = false;
        public bool botao5 = false;
        public bool botao6 = false;
        public bool botao7 = false;

        private void erro1(object sender, MouseButtonEventArgs e)
        {
            img1.Visibility = Visibility.Visible;
            botao1 = true;
            mostrarMensagem();
        }

        private void erro2(object sender, MouseButtonEventArgs e)
        {
            img2.Visibility = Visibility.Visible;
            botao2 = true;
            mostrarMensagem();
        }

        private void erro3(object sender, MouseButtonEventArgs e)
        {
            img3.Visibility = Visibility.Visible;
            botao3 = true;
            mostrarMensagem();
        }

        private void erro4(object sender, MouseButtonEventArgs e)
        {
            img4.Visibility = Visibility.Visible;
            botao4 = true;
            mostrarMensagem();
        }

        private void erro5(object sender, MouseButtonEventArgs e)
        {
            img5.Visibility = Visibility.Visible;
            botao5 = true;
            mostrarMensagem();
        }

        private void erro6(object sender, MouseButtonEventArgs e)
        {
            img6.Visibility = Visibility.Visible;
            botao6 = true;
            mostrarMensagem();
        }

        private void erro7(object sender, MouseButtonEventArgs e)
        {
            img7.Visibility = Visibility.Visible;
            botao7 = true;
            mostrarMensagem();
        }
        

        private void mostrarMensagem()
        {
            if (botao1 == true && botao2 == true && botao3 == true && botao4 == true && botao5 == true && botao6 == true && botao7 == true)
            {
                MessageBoxResult result = MessageBox.Show("Você encontrou todos os erros. Parabéns!","Parabéns!");
                img1.Visibility = Visibility.Hidden;
                img2.Visibility = Visibility.Hidden;
                img3.Visibility = Visibility.Hidden;
                img4.Visibility = Visibility.Hidden;
                img5.Visibility = Visibility.Hidden;
                img6.Visibility = Visibility.Hidden;
                img7.Visibility = Visibility.Hidden;
                botao1 = false;
                botao2 = false;
                botao3 = false;
                botao4 = false;
                botao5 = false;
                botao6 = false;
                botao7 = false;



            }
            
        }
        
    }
}
