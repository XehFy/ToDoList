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

namespace ToDoList.View
{
    /// <summary>
    /// Логика взаимодействия для PlansView.xaml
    /// </summary>
    public partial class PlansView : UserControl
    {
        public PlansView()
        {
            InitializeComponent();
        }

        private void AddPlanButt_Click(object sender, RoutedEventArgs e)
        {
            CheckBox tmp = new CheckBox();
            tmp.Content = TextBlockPlan.Text + "\n" + Calendar.SelectedDate.ToString();
            tmp.BorderBrush = Brushes.Black;
            tmp.Foreground = Brushes.Black;
            tmp.Background = Brushes.DeepSkyBlue;
            if (TextBlockPlan.Text != "" && Calendar.SelectedDate != null)
            {
                ToDoListBox.Items.Add(tmp);
                TextBlockPlan.Text = "";
                Calendar.DisplayDate = DateTime.Today;
            }

        }
    }
}
