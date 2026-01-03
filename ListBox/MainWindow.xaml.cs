using DataBinding.Data;
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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name = "Hussein" , Age = 20},
            new Person{Name = "Sara" , Age =10 },
            new Person{Name = "Jhon" , Age =14 },
            new Person{Name = "Peter" , Age = 44},
            new Person{Name = "Snow" , Age = 32},
            new Person{Name = "Iran" , Age =32 },
            new Person{Name = "Julia" , Age =43 },
            new Person{Name = "Paul" , Age =12 },
        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           var selectedItems =  ListBoxPeople.SelectedItems;
            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name + person.Age);
            }
        }
    }
}