using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RobotControllerMaintenance.Variable
{
    class VariableViewModel:ObservableObject,IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Variable";
            }
        }
        #region Fields
        private ICommand _changePageCommand;
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        #endregion
        public VariableViewModel()
        {
            // Add available pages
            VariableViewModels.Add(new Byte.ByteViewModel());
            VariableViewModels.Add(new Double.DoubleViewModel());
            VariableViewModels.Add(new Integer.IntegerViewModel());
            VariableViewModels.Add(new Real.RealViewModel());
            VariableViewModels.Add(new String.StringViewModel());
            VariableViewModels.Add(new Register.RegisterViewModel());

            // Set starting page
            CurrentPageViewModel = VariableViewModels[0];
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

        public List<IPageViewModel> VariableViewModels
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
            if (!VariableViewModels.Contains(viewModel))
                VariableViewModels.Add(viewModel);

            CurrentPageViewModel = VariableViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }
        #endregion
    }
}
