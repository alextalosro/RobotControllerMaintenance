﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotControllerMaintenance.Variable.Integer
{
    class IntegerModel : ObservableObject
    {
        #region Fields

        private int _variableId;
        private uint _variableValue;

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

        public uint VariableValue
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
