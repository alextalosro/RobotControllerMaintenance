using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace RobotControllerMaintenance.Alarm.OfflineAlarm
{
    class OfflineAlarmViewModel : ObservableCollection<OfflineAlarmModel>,IPageViewModel

    {
        public string Name
        {
            get
            {
                return "Offline Alarm";
            }
        }
    }
}
