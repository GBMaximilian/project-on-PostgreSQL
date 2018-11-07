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

namespace PostgreInterface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string LicenceNumber
        {
            get
            {
                return ComboBox1.SelectedValue.ToString();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var context = new Context();
            ComboBox1.ItemsSource = context.Cars.Select(x => x.LicenceNumber).ToList();
            ComboBox2.ItemsSource = context.Users.Select(x => x.Name).ToList();
        }

        private void MenuItem_click_1(object sender, RoutedEventArgs e)
        {
            tabControl1.SelectedItem = tabControl1.Items[0];
        }

        private void MenuItem_click_2(object sender, RoutedEventArgs e)
        {
            tabControl1.SelectedItem = tabControl1.Items[1];
        }

        private void Button_click_1(object sender, RoutedEventArgs e)
        {
            var context = new Context();
            User user = new User();
            user.Name = TextBox1.Text;
            if (ComboBox1.SelectedItem == null) { }
            else
                user.Cars.Add(context.Cars.First(x => x.LicenceNumber == LicenceNumber));
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("suck");
        }

        private void Button_click_2(object sender, RoutedEventArgs e)
        {
            var context = new Context();
            Car car = new Car();
            car.LicenceNumber = TextBox2.Text;
            car.Year = Convert.ToInt32(TextBox3.Text);
            if (ComboBox2.SelectedItem == null) { }
            else
            {
                string name = ComboBox2.SelectedValue.ToString();
                List<User> Users = context.Users.Where(x => (x.Name == name)).ToList();

                //var Users = from users in context.Users
                //            where users.Name == name
                //            select users;
                car.User = Users.First();
                //MessageBox.Show(ComboBox2.SelectedValue.ToString());
                //MessageBox.Show(context.Users.First().Name);
            }
            context.Cars.Add(car);
            context.SaveChanges();
        }
    }
}
