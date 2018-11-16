using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RobotControllerMaintenance.Alarm.MajorAlarm
{
    class MajorAlarmViewModel : ObservableCollection<MajorAlarmModel>,IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Major Alarm";
            }
        }
        /// <summary>
        /// asd
        /// </summary>
        //Constructor
        #region Constructor
        public MajorAlarmViewModel()
        {
            PrepareAlarmCollection();
        }
        #endregion
        private void PrepareAlarmCollection()
        {
            MajorAlarmModel alarm1 = new MajorAlarmModel
            {
                Index = 1,
                AlarmCode = 4511,
                AlarmCodeSub = 3,
                AlarmData = 4,
                AlarmDataSub = 5,
                AlarmName = "OUT OF RANGE(DROP-VALUE)",
                AlarmNameSub = "Alarm 1 Sub",
                AlarmTime = "2011/12/14 14:25",
                AlarmTimeSub = "15:44",
                AlarmType = 6,
                AlarmTypeSub = 7,
                AlarmTask = "TASK# 0",
            };
            Add(alarm1);
            MajorAlarmModel alarm2 = new MajorAlarmModel
            {
                Index = 2,
                AlarmCode = 8,
                AlarmCodeSub = 9,
                AlarmData = 10,
                AlarmDataSub = 11,
                AlarmName = "Alarm 2",
                AlarmNameSub = "Alarm 2 Sub",
                AlarmTime = "16:44",
                AlarmTimeSub = "16:55",
                AlarmType = 12,
                AlarmTypeSub = 13,
                AlarmTask = "TASK# 0",
            };
            Add(alarm2);
            MajorAlarmModel alarm3 = new MajorAlarmModel
            {
                Index = 3,
                AlarmCode = 14,
                AlarmCodeSub = 15,
                AlarmData = 16,
                AlarmDataSub = 17,
                AlarmName = "Alarm 3",
                AlarmNameSub = "Alarm 3 Sub",
                AlarmTime = "17:23",
                AlarmTimeSub = "17:24",
                AlarmType = 12,
                AlarmTypeSub = 13,
                AlarmTask = "TASK# 0",
            };
            Add(alarm3);
        }
    }
}
