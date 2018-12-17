using Prism.Commands;
using RobotControllerMaintenance.Alarm;
using RobotControllerMaintenance.ConnectEntity;
using RobotControllerMaintenance.Helper_Classes;
using RobotControllerMaintenance.TopMenu.About;
using RobotControllerMaintenance.Variable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace RobotControllerMaintenance
{
    public class ApplicationViewModel : ViewModelBase
    {
        #region Fields

        private ICommand _changePageCommand;
        private ICommand _changeManuCommand;

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        private List<IPageViewModel> _menuViewModels;

        #endregion

        public ApplicationViewModel()
        {
            // Add available pages
            PageViewModels.Add(new StatusViewModel());
            PageViewModels.Add(new ProductsViewModel());
            PageViewModels.Add(new AlarmViewModel());
            PageViewModels.Add(new VariableViewModel());

            MenuViewModels.Add(new ConnectViewModel());
            MenuViewModels.Add(new AboutViewModel());

            // Set starting page
            CurrentPageViewModel = MenuViewModels[0];

            //ConnectCommand = new DelegateCommand(OnConnectExecute, OnConnectCanExecute);
        }

        //private void OnConnectExecute()
        //{
        //    CurrentPageViewModel = PageViewModels[0];
        //}

        //private bool OnConnectCanExecute()
        //{
        //    //TO DO. Verify If connect is valid.
        //    return true;
        //}

        public ICommand ConnectCommand { get; set; }

        public ICommand ChangeMenuCommand
        {
            get
            {
                if (_changeManuCommand == null)
                {
                    _changeManuCommand = new RelayCommand(
                        p => ChangeMenuViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changeManuCommand;
            }
        }
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

        public List<IPageViewModel> MenuViewModels
        {
            get
            {
                if (_menuViewModels == null)
                    _menuViewModels = new List<IPageViewModel>();

                return _menuViewModels;
            }
        }

        public List<IPageViewModel> PageViewModels
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

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        private void ChangeMenuViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

    }
}
