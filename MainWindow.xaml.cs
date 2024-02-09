using System.Globalization;
using System.Text;
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

namespace TestVzhleduKomponent
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

        private void MenuItem_Terminate_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_DefaultBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Constants.DEFAULT_BACKGROUND;
        }

        private void RadioButton_Background_Checked(object sender, RoutedEventArgs e)
        {
            if (true == RadioButton_Background_GoldenrodYellow.IsChecked) { this.Background = new SolidColorBrush(Colors.LightGoldenrodYellow); }
            if (true == RadioButton_Background_Gray.IsChecked) { this.Background = new SolidColorBrush(Colors.LightGray); }
            if (true == RadioButton_Background_Green.IsChecked) { this.Background = new SolidColorBrush(Colors.LightGreen); }
            if (true == RadioButton_Background_SkyBlue.IsChecked) { this.Background = new SolidColorBrush(Colors.LightSkyBlue); }
        }

        private void Button_Salmon_Click(object sender, RoutedEventArgs e)
        {
            Border_Col2.Background = new SolidColorBrush(Colors.LightSalmon);
        }

        private void ToggleButton_Col2_Checked(object sender, RoutedEventArgs e)
        {
            Border_Col2.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void ToggleButton_Col2_Unchecked(object sender, RoutedEventArgs e)
        {
            Border_Col2.Background = new SolidColorBrush(Colors.LightBlue);
        }
    }


    public class SubtractConverter : IMultiValueConverter
    {
        // https://stackoverflow.com/questions/45736374/in-wpf-how-to-prevent-controls-inside-scrollviewer-from-expanding
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double[] doubles = values.Cast<double>().ToArray();

            double result = doubles[0];

            for (int i = 1; i < doubles.Length; i++)
            {
                result -= doubles[i];
            }

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public static class Constants
    {
        public static readonly Brush DEFAULT_BACKGROUND = new SolidColorBrush(Colors.LightGray);

        public const string LOREM_IPSUM = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Nullam eget nisl. Fusce tellus odio, dapibus id fermentum quis, suscipit id erat. Donec iaculis gravida nulla. Maecenas fermentum, sem in pharetra pellentesque, velit turpis volutpat ante, in pharetra metus odio a lectus. Cras pede libero, dapibus nec, pretium sit amet, tempor quis. Etiam commodo dui eget wisi. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Aliquam ante. Nunc dapibus tortor vel mi dapibus sollicitudin. Aliquam erat volutpat. Mauris tincidunt sem sed arcu. Etiam dui sem, fermentum vitae, sagittis id, malesuada in, quam. Mauris elementum mauris vitae tortor. Nulla quis diam.";

        public const double WINDOW_PADDING = 16;
        //TODO the way this is used is not exact - WINDOW_PADDING=4 doesn't look like it does anything, there must be some margins around the header label or the columns

        public record struct Person(string FirstName, string Surname)
        {
            public override string ToString()
            {
                return $"{Surname}, {FirstName}";
            }
        }

        public static readonly Person[] PEOPLE =
        {
            new("Magnus","Carlsen"),
            new("Garry","Kasparov"),
            new("Fabiano","Caruana"),
            new("Levon","Aronian"),
            new("Wesley","So"),
            new("Shakhriyar","Mamedyarov"),
            new("Maxime","Vachier-Lagrave"),
            new("Viswanathan","Anand"),
            new("Vladimir","Kramnik"),
            new("Veselin","Topalov"),
            new("Hikaru","Nakamura"),
            new("Ding","Liren"),
            new("Alexander","Grischuk"),
            new("Alireza","Firouzja"),
            new("Anish","Giri"),
            new("Ian","Nepomniachtchi"),
            new("Teimour","Radjabov"),
            new("Alexander","Morozevich"),
            new("Sergey","Karjakin"),
            new("Vasyl","Ivanchuk"),
            new("Robert James","Fischer"),
            new("Anatoly","Karpov"),
            new("Boris","Gelfand"),
            new("Richard","Rapport"),
            new("Pentala","Harikrishna"),
            new("Peter","Svidler"),
            new("Leinier","Dominguez"),
            new("Pavel","Eljanov"),
            new("Yu","Yangyi"),
            new("Ruslan","Ponomariov"),
            new("Peter", "Leko")
        };
    }
}