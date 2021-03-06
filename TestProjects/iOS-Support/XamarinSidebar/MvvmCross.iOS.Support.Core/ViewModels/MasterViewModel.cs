using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvvmCross.iOS.Support.XamarinSidebarSample.Core.ViewModels
{
    public class MasterViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MasterViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));

            ExampleValue = "Master View";
        }

        public IMvxCommand ShowDetailCommand
        {
            get
            {
                return new MvxCommand(ShowDetailCommandExecuted);
            }
        }

        private void ShowDetailCommandExecuted()
        {
            _navigationService.Navigate<DetailViewModel>();
        }
    }
}