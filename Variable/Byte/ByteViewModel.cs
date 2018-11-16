using RobotControllerMaintenance.Alarm.MajorAlarm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RobotControllerMaintenance.Variable.Byte
{
    class ByteViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Byte";
            }
        }
        #region Fields

        private int _variableId;
        private ByteModel _currentVariable;
        private ICommand _getVariableCommand;
        private ICommand _setVariableCommand;
        private ObservableCollection<ByteModel> _byteVarModels;

        #endregion

        #region Properties/Commands

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

        public ByteModel CurrentVariable
        {
            get { return _currentVariable; }
            set
            {
                if (value != _currentVariable)
                {
                    _currentVariable = value;
                    OnPropertyChanged("CurrentVariable");
                }
            }
        }

        public ICommand GetVariableCommand
        {
            get
            {
                if (_getVariableCommand == null)
                {
                    _getVariableCommand = new RelayCommand(
                        param => GetProduct(),
                        param => VariableId > 0
                    );
                }
                return _getVariableCommand;
            }
        }

        public ICommand SetVariableCommand
        {
            get
            {
                if (_setVariableCommand == null)
                {
                    _setVariableCommand = new RelayCommand(
                        param => SaveProduct(),
                        param => (CurrentVariable != null)
                    );
                }
                return _setVariableCommand;
            }
        }

        #endregion

        #region Methods

        private void GetProduct()
        {

            // Usually you'd get your Product from your datastore,
            // but for now we'll just return a new object
            

            ByteModel b = new ByteModel();
            b.VariableId = VariableId;
            b.VariableValue = 214;
            CurrentVariable = b;
        }

        private void SaveProduct()
        {
            // You would implement your Product save here
        }

        #endregion
    }
}
