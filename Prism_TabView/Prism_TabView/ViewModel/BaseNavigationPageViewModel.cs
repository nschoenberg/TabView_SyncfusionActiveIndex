using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prism_TabView.ViewModels
{
    public class BaseNavigationPageViewModel : ViewModelBase
    {
        public BaseNavigationPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
