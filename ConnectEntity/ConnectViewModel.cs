using RobotControllerMaintenance.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControllerMaintenance.ConnectEntity
{
    class ConnectViewModel : ViewModelBase, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Connect";
            }
        }
    }
}
