using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotControllerMaintenance.Variable.Real
{
    class RealModel : ObservableObject
    {
        #region Fields

        private int _variableId;
        private double _variableValue;

        #endregion // Fields

        #region Properties

        public int VariableId
        {
            get { return _variableId; }
            set
            {
                if (value != _variableId)
                {
                    _variableId = value;
                    OnPropertyChanged("VariableId");
                }
            }
        }

        public double VariableValue
        {
            get { return _variableValue; }
            set
            {
                if (value != _variableValue)
                {
                    _variableValue = value;
                    OnPropertyChanged("VariableValue");
                }
            }
        }

        #endregion // Properties
    }
}
