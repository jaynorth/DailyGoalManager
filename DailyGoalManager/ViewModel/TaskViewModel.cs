using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyGoalManager;

namespace DailyGoalManager.ViewModel
{   
    public class TaskViewModel:  BaseViewModel
    {

        public TaskManageDBEntities1 _entity;

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

            _entity = new TaskManageDBEntities1();

            TaskList = new ObservableCollection<Task>(_entity.Tasks);

            //ObservableCollection<Task> tl = new ObservableCollection<Task>
            //{
            //new Task { Time = 4, TaskTitle = "Wash Dishes", Id = 2 },
            //new Task { Time = 5, TaskTitle = "Laundry", Id = 4 },
            //new Task { Time = 7, TaskTitle = "Homework", Id = 6 },
            //};

            //this.TaskList = tl;


        }
    }
}
