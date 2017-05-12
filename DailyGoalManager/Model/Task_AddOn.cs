using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyGoalManager
{
    public partial class Task
    {
        private string _header;
        public string Header
        {
            get { return _header = TaskTitle; }
            set
            {

                if (_header != value)
                {
                    _header = value;
                    //OnPropertyChanged();
                }



            }
        }
    }
}
