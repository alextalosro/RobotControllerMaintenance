using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace RobotControllerMaintenance.Alarm
{
    class AlarmViewModel : ObservableObject,IPageViewModel
    {
        #region Fields
        private ICommand _changePageCommand;
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        #endregion
        public AlarmViewModel()
        {
            // Add available pages
            AlarmViewModels.Add(new MajorAlarm.MajorAlarmViewModel());
            AlarmViewModels.Add(new MinorAlarm.MinorAlarmViewModel());
            AlarmViewModels.Add(new OfflineAlarm.OfflineAlarmViewModel());
            AlarmViewModels.Add(new SystemUserAlarm.SystemUserAlarmViewModel());
            AlarmViewModels.Add(new UserUserAlarm.UserUserAlarmViewModel());

            // Set starting page
            CurrentPageViewModel = AlarmViewModels[0];
        }
        #region Properties / Commands
        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }
        public string Name
        {
            get
            {
                return "Alarm";
            }
        }
        public List<IPageViewModel> AlarmViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }
        #endregion
        #region Methods
        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!AlarmViewModels.Contains(viewModel))
                AlarmViewModels.Add(viewModel);

            CurrentPageViewModel = AlarmViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }
        #endregion
    }
}
