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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RandomKleurcode();
        }

        private void RandomKleurcode()
        {
           
            
            var colors = new List<string> { "Red", "Yellow", "Orange", "White", "Green", "Blue" };

            
            
            var random = new Random();
            var randomCode = colors.OrderBy(x => random.Next()).Take(4).ToList();

   

            this.Title = "Mastermind (" + string.Join(", ", randomCode) + ")";
        }

        


             }


    
       
            
               

        

        

       
    }
