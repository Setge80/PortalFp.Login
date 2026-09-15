using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PortalFp.Login
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

        private void BtnAcceder_Click(object sender, RoutedEventArgs e)
        {
            String nombre= TxtNombre.Text.Trim();
            String contrasenya= TxtContrasenya.Password.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contrasenya))
            {
                TxtFeedback.Text = "Uno o más campos estan vacíos.";
                TxtFeedback.Foreground = Brushes.Red;
            }
            else if (nombre == "admin" && contrasenya == "1234")
            {
                TxtFeedback.Text = $"Acceso concedido. Bienvenido {nombre}";
                TxtFeedback.Foreground = Brushes.Green;
            }
            else
            {
                TxtFeedback.Text = "Credenciales incorrectas.";
                TxtFeedback.Foreground = Brushes.Red;
            }
        }
    }
}