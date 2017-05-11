using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyGoalManager 
{
    public class Task : BaseViewModel
    {
        public int Time { get; set; }
        private String _taskTitle;
        private string _header;
        public int Id { get; set; }

        public string TaskTitle
        {
            get { return _taskTitle; }
            set { if (_taskTitle != value)
                {
                    _taskTitle = value;
                    OnPropertyChanged("Header");
                    OnPropertyChanged();
                } 
                
            }
        }

        public string Header
        {
            get { return _header =  _taskTitle; }
            set {

                if (_header != value)
                {
                    _header = value;
                    OnPropertyChanged();
                }

                

            }
        }

        public Task()
        {
        
            
        }
    }
}
