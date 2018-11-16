using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace RobotControllerMaintenance.Alarm.SystemUserAlarm
{
    class SystemUserAlarmViewModel : ObservableCollection<SystemUserAlarmModel>,IPageViewModel
    {
        public string Name
        {
            get
            {
                return "System(User) Alarm";
            }
        }

        #region Constructor
        public SystemUserAlarmViewModel()
        {
            PrepareAlarmCollection();
        }
        #endregion
        private void PrepareAlarmCollection()
        {
            SystemUserAlarmModel alarm1 = new SystemUserAlarmModel
            {

                AlarmCode = 2,
                AlarmCodeSub = 3,
                AlarmData = 4,
                AlarmDataSub = 5,
                AlarmName = "Alarm 1",
                AlarmNameSub = "Alarm 1 Sub",
                AlarmTime = "15:33",
                AlarmTimeSub = "15:44",
                AlarmType = 6,
                AlarmTypeSub = 7,
            };
            Add(alarm1);
            SystemUserAlarmModel alarm2 = new SystemUserAlarmModel
            {
                AlarmCode = 8,
                AlarmCodeSub = 9,
                AlarmData = 10,
                AlarmDataSub = 11,
                AlarmName = "Alarm 2",
                AlarmNameSub = "Alarm 2 Sub",
                AlarmTime = "16:44",
                AlarmTimeSub = "16:55",
                AlarmType = 12,
                AlarmTypeSub = 13
            };
            Add(alarm2);
            SystemUserAlarmModel alarm3 = new SystemUserAlarmModel
            {
                AlarmCode = 14,
                AlarmCodeSub = 15,
                AlarmData = 16,
                AlarmDataSub = 17,
                AlarmName = "Alarm 3",
                AlarmNameSub = "Alarm 3 Sub",
                AlarmTime = "17:23",
                AlarmTimeSub = "17:24",
                AlarmType = 12,
                AlarmTypeSub = 13
            };
            Add(alarm3);
        }
    }
}
