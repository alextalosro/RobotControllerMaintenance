using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControllerMaintenance.Alarm
{
    /// <summary>
    /// This is the AlarmModel for out MVVM pattern
    /// </summary>
    public class Alarm : ObservableObject
    {
        //Fields
        #region Fields
        private uint _index;
        private uint _alarmCode;
        private uint _alarmData;
        private uint _alarmType;
        private string _alarmTime;
        private string _alarmName;
        private string _alarmTask;

        private uint _alarmCodeSub;
        private uint _alarmDataSub;
        private uint _alarmTypeSub;
        private string _alarmTimeSub;
        private string _alarmNameSub;
        private string _subCodeDataAditionalInfo;
        private string _subCodeDataCharacterString;
        private string _subCodeDataCharacterStringRev;
        #endregion
        //Properties
        #region Properties
        public uint Index
        {
            get { return _index; }
            set {
                _index = value;
                OnPropertyChanged("Index");
            }
        }
        public uint AlarmCode
        {
            get { return _alarmCode; }
            set
            {
                _alarmCode = value;
                OnPropertyChanged("AlarmCode");
            }
        }
        public uint AlarmData
        {
            get { return _alarmData; }
            set
            {
                _alarmData = value;
                OnPropertyChanged("AlarmData");
            }
        }
        public uint AlarmType
        {
            get { return _alarmType; }
            set
            {
                _alarmType = value;
                OnPropertyChanged("AlarmType");
            }
        }
        public string AlarmTime
        {
            get { return _alarmTime; }
            set
            {
                _alarmTime = value;
                OnPropertyChanged("AlarmTime");
            }
        }
        public string AlarmName
        {
            get { return _alarmName; }
            set
            {
                _alarmName = value;
                OnPropertyChanged("AlarmName");
            }
        }
        public string AlarmTask
        {
            get { return _alarmTask; }
            set
            {
                _alarmTask = value;
                OnPropertyChanged("AlarmTask");
            }
        }

        public uint AlarmCodeSub
        {
            get { return _alarmCodeSub; }
            set
            {
                _alarmCodeSub = value;
                OnPropertyChanged("AlarmCodeSub");
            }
        }
        public uint AlarmDataSub
        {
            get { return _alarmDataSub; }
            set
            {
                _alarmDataSub = value;
                OnPropertyChanged("AlarmDataSub");
            }
        }
        public uint AlarmTypeSub
        {
            get { return _alarmTypeSub; }
            set
            {
                _alarmTypeSub = value;
                OnPropertyChanged("AlarmTypeSub");
            }
        }
        public string AlarmTimeSub
        {
            get { return _alarmTimeSub; }
            set
            {
                _alarmTimeSub = value;
                OnPropertyChanged("AlarmTimeSub");
            }
        }
        public string AlarmNameSub
        {
            get { return _alarmNameSub; }
            set
            {
                _alarmNameSub = value;
                OnPropertyChanged("AlarmNameSub");
            }
        }
        public string SubCodeDataAditionalInfo
        {
            get { return _subCodeDataAditionalInfo; }
            set
            {
                _subCodeDataAditionalInfo = value;
                OnPropertyChanged("SubCodeDataAditionalInfo");
            }
        }
        public string SubCodeDataCharacterString
        {
            get { return _subCodeDataCharacterString; }
            set
            {
                _subCodeDataCharacterString = value;
                OnPropertyChanged("SubCodeDataCharacterString");
            }
        }
        public string SubCodeDataCharacterStringRev
        {
            get { return _subCodeDataCharacterStringRev; }
            set
            {
                _subCodeDataCharacterStringRev = value;
                OnPropertyChanged("SubCodeDataCharacterStringRev");
            }
        }
        #endregion
    }
}