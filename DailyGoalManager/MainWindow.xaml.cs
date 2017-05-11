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

namespace DailyGoalManager
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();

            //Task t = new Task { Time = 4, TaskTitle = "Wash Dishes", Id = 2 };
            List<Task> TaskList = new List<Task>
            {
            new Task { Time = 4, TaskTitle = "Wash Dishes", Id = 2 },
            new Task { Time = 5, TaskTitle = "Laundry", Id = 4 },
            new Task { Time = 7, TaskTitle = "Homework", Id = 6 },
            };
            DataContext = TaskList.FirstOrDefault();
        }
    }
}
