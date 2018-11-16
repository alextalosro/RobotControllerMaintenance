using RobotControllerMaintenance.Alarm.MajorAlarm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RobotControllerMaintenance.Variable.Integer
{
    class IntegerViewModel : ObservableCollection<MajorAlarmModel>, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Integer";
            }
        }
    }
}
