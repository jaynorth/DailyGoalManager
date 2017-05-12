using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyGoalManager.ViewModel
{
    public class TaskViewModel:  BaseViewModel
    {



        private ObservableCollection<Task> _taskList;

        public ObservableCollection<Task> TaskList
        {
            get { return _taskList; }
            set { _taskList = value;
                OnPropertyChanged();
            }
        }


     

        public TaskViewModel()
        {

            ObservableCollection<Task> tl = new ObservableCollection<Task>
            {
            new Task { Time = 4, TaskTitle = "Wash Dishes", Name = "2" },
            new Task { Time = 5, TaskTitle = "Laundry", Name = "4" },
            new Task { Time = 7, TaskTitle = "Homework", Name = "6" },
            };

            this.TaskList = tl;
    
            
        }
    }
}
