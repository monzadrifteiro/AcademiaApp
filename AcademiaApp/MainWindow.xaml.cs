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

namespace AcademiaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Academia A;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            A = new Academia(txtAcadNome.Text, txtAcadEnde.Text);
            txtEspo.Items.Add(A.ToString());
            txtAcadNome.Text = String.Empty;
            txtAcadEnde.Text = String.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Esporte infos = new Esporte(txtEspNome.Text, txtEspHora.Text, double.Parse(txtEspMens.Text));
            A.Inserir(infos);
            txtEspNome.Text = String.Empty;
            txtEspHora.Text = String.Empty;
            txtEspMens.Text = String.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (Esporte modalidades in A.Listar())
            {
                txtEspo.Items.Add(modalidades);
            }
        }
    }
}
