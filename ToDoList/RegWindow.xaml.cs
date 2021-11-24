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
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        AppContext db;
        public RegWindow()
        {
            InitializeComponent();

            db = new AppContext();
        }

        private void MakeRegButt_Click(object sender, RoutedEventArgs e)
        {
            string login = RegLogin.Text.Trim();
            string name = RegName.Text.Trim();
            string pass1 = RegPass1.Password;
            string pass2 = RegPass2.Password;
            if (pass1 != pass2)
            {
                RegPass2.Foreground = Brushes.DarkRed;
            }
            else {
                RegPass2.Foreground = Brushes.Black;
                User user = new User(login, pass2, name);
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }

        }
    }
}
