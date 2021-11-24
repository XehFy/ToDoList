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

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User authUser = null;
        public MainWindow()
        {
            InitializeComponent();
            AppContext db = new AppContext();
        }

        private void RegButt_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Hide();
        }

        private void EntButt_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLog.Text.Trim();
            string password = PassBox.Password;
            //User authUser = null;
            using (AppContext db = new AppContext())
            {
                authUser = db.Users.Where(i => i.Login == login && i.Password == password).FirstOrDefault();
            }
            if (authUser != null)
            {
                MessageBox.Show("Вход в приложение");
                PersonalPage personalPage = new PersonalPage(authUser);
                personalPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
        }
    }
}
