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
using ToDoList.Model;

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для PersonalPage.xaml
    /// </summary>
    public partial class PersonalPage : Window
    {
        User userInfo = new User();
        public PersonalPage(User tmp)
        {
            InitializeComponent();
            this.userInfo = tmp;
            DataContext = new PlansModel();
            //TestLabel.Content = userInfo.Login + "\n" + userInfo.Name + "\n" + userInfo.user_id;
        }

        private void ExitButt_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TextBlockMain_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("TEST");
            DataContext = new PlansModel();
        }
    }
}
