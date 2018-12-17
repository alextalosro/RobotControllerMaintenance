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
            MajorAlarmModel alarm4 = new MajorAlarmModel
            {
                Index = 4,
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
            Add(alarm4);
            MajorAlarmModel alarm5 = new MajorAlarmModel
            {
                Index = 5,
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
            Add(alarm5);
            MajorAlarmModel alarm6 = new MajorAlarmModel
            {
                Index = 6,
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
            Add(alarm6);
            MajorAlarmModel alarm7 = new MajorAlarmModel
            {
                Index = 7,
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
            Add(alarm7);
            MajorAlarmModel alarm8 = new MajorAlarmModel
            {
                Index = 8,
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
            Add(alarm8);
            MajorAlarmModel alarm9 = new MajorAlarmModel
            {
                Index = 9,
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
            Add(alarm9);
            MajorAlarmModel alarm10 = new MajorAlarmModel
            {
                Index = 10,
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
            Add(alarm10);
            MajorAlarmModel alarm11 = new MajorAlarmModel
            {
                Index = 11,
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
            Add(alarm11);
            MajorAlarmModel alarm12 = new MajorAlarmModel
            {
                Index = 12,
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
            Add(alarm12);
            MajorAlarmModel alarm13 = new MajorAlarmModel
            {
                Index = 13,
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
            Add(alarm13);
            MajorAlarmModel alarm14 = new MajorAlarmModel
            {
                Index = 14,
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
            Add(alarm14);
            MajorAlarmModel alarm15 = new MajorAlarmModel
            {
                Index = 15,
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
            Add(alarm15);
            MajorAlarmModel alarm16 = new MajorAlarmModel
            {
                Index = 16,
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
            Add(alarm16);
            MajorAlarmModel alarm17 = new MajorAlarmModel
            {
                Index = 17,
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
            Add(alarm17);
            MajorAlarmModel alarm18 = new MajorAlarmModel
            {
                Index = 18,
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
            Add(alarm18);
            MajorAlarmModel alarm19 = new MajorAlarmModel
            {
                Index = 19,
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
            Add(alarm19);
            MajorAlarmModel alarm20 = new MajorAlarmModel
            {
                Index = 20,
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
            Add(alarm20);
            MajorAlarmModel alarm21 = new MajorAlarmModel
            {
                Index = 21,
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
            Add(alarm21);
            MajorAlarmModel alarm22 = new MajorAlarmModel
            {
                Index = 22,
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
            Add(alarm22);
            MajorAlarmModel alarm23 = new MajorAlarmModel
            {
                Index = 23,
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
            Add(alarm23);
            MajorAlarmModel alarm24 = new MajorAlarmModel
            {
                Index = 24,
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
            Add(alarm24);

        }
    }
}
