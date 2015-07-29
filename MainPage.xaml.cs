using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace HolaMundo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Quéres que te salude?", "Pregunta", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {


                string nombre = txtNombre.Text;
                int hora = DateTime.Now.Hour;
                string mensaje = "";

                if (hora < 12)
                    mensaje = "Buenos Días ";
                else
                    if (hora < 20)
                        mensaje = "Buenas Tardes ";
                    else
                        mensaje = "Buenas Noches ";

                mensaje += nombre;
                txbMensaje.Text = mensaje;
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show(".........BYE!!! =.=' ");
            }
        }

        private void chbPermiso_Checked(object sender, RoutedEventArgs e)
        {
            if (btnSaludar != null)
            {
                btnSaludar.Visibility = Visibility.Visible;
            }
        }

        private void chbPermiso_Unchecked(object sender, RoutedEventArgs e)
        {
            btnSaludar.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}