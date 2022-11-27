using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using JoaoPedroAlbieroCezar_d7_avaliacao.Data;

namespace JoaoPedroAlbieroCezar_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user = new User();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext= user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //user.username = Usuario.Text;
            //user.password = Senha.Text;

            using (var context = new Context())
            {
                //Recebe o usuário com o mesmo login no db
                var testUser = context.users
                       .Where(b => b.username == user.username)
                       .FirstOrDefault<User>();
                //verifica se a senha é compatível e se testUser é nulo
                if (testUser == null || testUser.password != user.password)
                {
                    MainGrid.Children.Add(new Negado());
                }
                else if (testUser.password == user.password)
                {
                    MainGrid.Children.Add(new Aprovado());
                }
            }
        }
    }
}
