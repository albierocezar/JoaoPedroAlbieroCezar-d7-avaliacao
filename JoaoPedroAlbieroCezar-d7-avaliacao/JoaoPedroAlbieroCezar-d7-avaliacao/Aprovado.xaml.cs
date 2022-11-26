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

namespace JoaoPedroAlbieroCezar_d7_avaliacao
{
    /// <summary>
    /// Interação lógica para Aprovado.xam
    /// </summary>
    public partial class Aprovado : UserControl
    {
        public Aprovado()
        {
            InitializeComponent();
        }

        private void newWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }


    }
}
