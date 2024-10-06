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

namespace git_taak_1_groep_abc_DistnGeorisPXL
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

        const string greenCode = "#008000";
        const string yellowCode = "#FFFF00";
        const string blueCode = "#0000FF";
        const string redCode = "#FF0000";

        private void greenImage_MouseEnter(object sender, MouseEventArgs e)
        {

            mainWindow.Background = Brushes.Green;

        }

        private void greenImage_MouseLeave(object sender, MouseEventArgs e)
        {

            mainWindow.Background = Brushes.White;

        }

        private void yellowImage_MouseEnter(object sender, MouseEventArgs e)
        {

            mainWindow.Background = Brushes.Yellow;

        }

        private void yellowImage_MouseLeave(object sender, MouseEventArgs e)
        {

            mainWindow.Background = Brushes.White;

        }

        private void blueImage_MouseEnter(object sender, MouseEventArgs e)
        {

            mainWindow.Background = Brushes.Blue;

        }

        private void blueImage_MouseLeave(object sender, MouseEventArgs e)
        {

            mainWindow.Background = Brushes.White;

        }

        private void redImage_MouseEnter(object sender, MouseEventArgs e)
        {

            mainWindow.Background = Brushes.Red;

        }

        private void redImage_MouseLeave(object sender, MouseEventArgs e)
        {

            mainWindow.Background = Brushes.White;

        }

        private void greenImage_MouseDown(object sender, MouseButtonEventArgs e)
        {

            imageSelectionTextBox.Text = greenCode;

        }

        private void yellowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {

            imageSelectionTextBox.Text = yellowCode;

        }

        private void blueImage_MouseDown(object sender, MouseButtonEventArgs e)
        {

            imageSelectionTextBox.Text = blueCode;

        }

        private void redImage_MouseDown(object sender, MouseButtonEventArgs e)
        {

            imageSelectionTextBox.Text = redCode;

        }
    }
}