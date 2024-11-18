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
using System.Windows.Threading;

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> randomCode;

        public MainWindow()
        {
            InitializeComponent();
            RandomKleurcode();
        }

        private void Tries()
        {
            

        }

        

       




        private void RandomKleurcode()
        {
            var colors = new List<string> { "Red", "Yellow", "Orange", "White", "Green", "Blue" };

            var random = new Random();
            randomCode = colors.OrderBy(x => random.Next()).Take(4).ToList();

            this.Title = "Mastermind (" + string.Join(", ", randomCode ) + ")";
        }
        

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender == comboBox1 && comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        eersteLabel.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 1:
                        eersteLabel.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 2:
                        eersteLabel.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        eersteLabel.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 4:
                        eersteLabel.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        eersteLabel.Background = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }




        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender == comboBox2 && comboBox2.SelectedItem != null)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        tweedeLabel.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 1:
                        tweedeLabel.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 2:
                        tweedeLabel.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        tweedeLabel.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 4:
                        tweedeLabel.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        tweedeLabel.Background = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender == comboBox3 && comboBox3.SelectedItem != null)
            {
                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        derdeLabel.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 1:
                        derdeLabel.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 2:
                        derdeLabel.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        derdeLabel.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 4:
                        derdeLabel.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        derdeLabel.Background = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender == comboBox4 && comboBox4.SelectedItem != null)
            {
                switch (comboBox4.SelectedIndex)
                {
                    case 0:
                        vierdeLabel.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 1:
                        vierdeLabel.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 2:
                        vierdeLabel.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        vierdeLabel.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 4:
                        vierdeLabel.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        vierdeLabel.Background = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }
        }

        private void kleurCodeCheck(object sender, RoutedEventArgs e)


        {

            int attempts = 0;

            attempts =+ 1; == attempttextbox.

            

            var kleur = (eersteLabel.Background as SolidColorBrush)?.Color;

            if (kleur.Value == (Color)ColorConverter.ConvertFromString(randomCode[0]))
            {
                eersteLabel.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                eersteLabel.BorderThickness = new Thickness(2);
            }
            if (kleur.Value != (Color)ColorConverter.ConvertFromString(randomCode[0])) 
            {
                eersteLabel.BorderBrush = new SolidColorBrush(Colors.Wheat);
                eersteLabel.BorderThickness = new Thickness(2);

            }
            else
            {
                eersteLabel.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                eersteLabel.BorderThickness = new Thickness(2);
            }
            
                var kleur1 = (tweedeLabel.Background as SolidColorBrush)?.Color;

                if (kleur1.Value == (Color)ColorConverter.ConvertFromString(randomCode[1]))
                {
                tweedeLabel.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                tweedeLabel.BorderThickness = new Thickness(2);
                }
                if (kleur1.Value != (Color)ColorConverter.ConvertFromString(randomCode[1]))
                {
                tweedeLabel.BorderBrush = new SolidColorBrush(Colors.Wheat);
                tweedeLabel.BorderThickness = new Thickness(2);

                }
                else
                {
                tweedeLabel.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                tweedeLabel.BorderThickness = new Thickness(2);
                }

            var kleur2 = (derdeLabel.Background as SolidColorBrush)?.Color;

            if (kleur2.Value == (Color)ColorConverter.ConvertFromString(randomCode[2]))
            {
                derdeLabel.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                derdeLabel.BorderThickness = new Thickness(2);
            }
            if (kleur2.Value != (Color)ColorConverter.ConvertFromString(randomCode[2]))
            {
                derdeLabel.BorderBrush = new SolidColorBrush(Colors.Wheat);
                derdeLabel.BorderThickness = new Thickness(2);

            }

            else
            {
                derdeLabel.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                derdeLabel.BorderThickness = new Thickness(2);
            }

            var kleur3 = (vierdeLabel.Background as SolidColorBrush)?.Color;

            if (kleur3.Value == (Color)ColorConverter.ConvertFromString(randomCode[3]))
            {
                vierdeLabel.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                vierdeLabel.BorderThickness = new Thickness(2);
            }
            if (kleur3.Value != (Color)ColorConverter.ConvertFromString(randomCode[3]))
            {
                vierdeLabel.BorderBrush = new SolidColorBrush(Colors.Wheat);
                vierdeLabel.BorderThickness = new Thickness(2);

            }
            else
            {
                vierdeLabel.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                vierdeLabel.BorderThickness = new Thickness(2);
            }


        }
    }
}
