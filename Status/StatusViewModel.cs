using RobotControllerMaintenance.Status;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RobotControllerMaintenance
{
    public class StatusViewModel : ObservableCollection<StatusModel>, IPageViewModel
    {
        #region Fields
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return "Controller Status";
            }
        }
        #endregion


        public StatusViewModel()
        {
            PrepareStatusInfoColection();
        }

        private void PrepareStatusInfoColection()
        {
            StatusModel model = new StatusModel
            {
                Name = "Running",
                IsChecked = true,
            };
            Add(model);
            StatusModel model2 = new StatusModel
            {
                Name = "Hold",
                IsChecked = false,
            };
            Add(model2);
            StatusModel model3 = new StatusModel
            {
                Name = "Conected",
                IsChecked = true,
            };
            Add(model3);
        }
    }
}
