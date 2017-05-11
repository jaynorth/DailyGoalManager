using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyGoalManager.ViewModel
{
    public class TaskViewModel:  BaseViewModel
    {



        private List<Task> _taskList;

        public List<Task> TaskList
        {
            get { return _taskList; }
            set { _taskList = value; }
        }




        private String _taskTitle;
        private string _header;


        public string TaskTitle
        {
            get { return _taskTitle; }
            set
            {
                if (_taskTitle != value)
                {
                    _taskTitle = value;
                    OnPropertyChanged("Header");
                    OnPropertyChanged();
                }

            }
        }

        public string Header
        {
            get { return _header = _taskTitle; }
            set
            {

                if (_header != value)
                {
                    _header = value;
                    OnPropertyChanged();
                }



            }
        }

        public TaskViewModel()
        {

            List<Task> tl = new List<Task>
            {
            new Task { Time = 4, TaskTitle = "Wash Dishes", Id = 2 },
            new Task { Time = 5, TaskTitle = "Laundry", Id = 4 },
            new Task { Time = 7, TaskTitle = "Homework", Id = 6 },
            };

            this.TaskList = tl;
            
        }
    }
}
