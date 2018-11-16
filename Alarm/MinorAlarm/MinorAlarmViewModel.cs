using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
//using HSEthernet;

namespace RobotControllerMaintenance.Alarm.MinorAlarm
{
    class MinorAlarmViewModel : ObservableCollection<MinorAlarmModel>,IPageViewModel
    {
        //HSEClient H = new HSEClient("192.168.255.1", 10, 2);

        public string Name
        {
            get
            {
                return "Minor Alarm";
            }
        }
        //Constructor
        #region Constructor
        public MinorAlarmViewModel()
        {
            PrepareAlarmCollection();
        }
        #endregion
        private void PrepareAlarmCollection()
        {

            for (int i = 0; i <= 100; i++)
            {
                //HSEClient.RecStatus alarmStatus = H.ReadAlarmHistoryData(i, out Alarm_Data AD);
                //HSEClient.RecStatus subAlarmStatus = H.ReadAlarmHistoryData(i, out Alarm_Data_Sub ADS);

                MinorAlarmModel alarm = new MinorAlarmModel
                {
                    //#region Class content
                    //Index = Convert.ToUInt32(i),
                    //AlarmCode = AD.AlarmCode,
                    //AlarmCodeSub = ADS.AlarmCode,
                    //AlarmData = AD.AlarmData,
                    //AlarmDataSub = ADS.AlarmData,
                    //AlarmName = AD.AlarmName,
                    //AlarmNameSub = ADS.AlarmName,
                    //AlarmTime = AD.AlarmTime,
                    //AlarmTimeSub = ADS.AlarmTime,
                    //AlarmType = AD.AlarmType,
                    //AlarmTypeSub = ADS.AlarmType,
                    //SubCodeDataAditionalInfo = ADS.SubCodeDataAdditionalInfo,
                    //SubCodeDataCharacterString = ADS.SubCodeDataCharacterStrings,
                    //SubCodeDataCharacterStringRev = ADS.SubCodeDataCharacterStringsRev,
                    //#endregion
                    #region Class content
                    Index = Convert.ToUInt32(i),
                    AlarmCode = 1,
                    AlarmCodeSub = 1,
                    AlarmData = 12,
                    AlarmDataSub = 1221,
                    AlarmName = "asdas",
                    AlarmNameSub = "asdassad",
                    AlarmTime = "qwdqdq",
                    AlarmTimeSub = "eirhekrr",
                    AlarmType =2122,
                    AlarmTypeSub = 2124,
                    SubCodeDataAditionalInfo = "dsfsd",
                    SubCodeDataCharacterString = "skjdfnks",
                    SubCodeDataCharacterStringRev = "fslkdnfk",
                    #endregion
                };
                Add(alarm);
            }

        }
    }
}
