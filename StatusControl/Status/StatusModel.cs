using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotControllerMaintenance.Status
{
    public class StatusModel : ObservableObject
    {
        #region Fields
        private string _name;
        private bool _isChecked;

        #region Explications
        //bool Step Program is executed one step at a time.
        //bool Cycle1 1 cycle.The current program is executed but not
        //restarted when it ends.
        //bool AutomaticAndContinous Program is executed and restarted when it ends.
        //bool Running Program is currently running.
        //bool InGuardSafeOperation Program is executed in Teach mode.
        //bool Teach Programming pendant is in Teach mode.
        //bool Play Programming pendant is in Play mode.
        //bool CommandRemote Programming pendant is in Remote mode.
        //bool InHoldStatusByPP In Hold status, ordered from the programming
        //pendant.
        //bool InHoldStatusExt In Hold status, ordered from external source.
        //bool InHoldStatusCmd In Hold status, ordered from a command.
        //bool Alarming An alarm is currently active.
        //bool ErrorOccuring An error is currently active.
        //bool ServoON Servos are currently active.
        #endregion
        #endregion
        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }
        #endregion
    }
}

