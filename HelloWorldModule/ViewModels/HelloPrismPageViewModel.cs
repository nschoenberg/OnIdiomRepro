using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldModule.ViewModels
{
    public class HelloPrismPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public HelloPrismPageViewModel(INavigationService _navigationService)
        {
            _navigationService = _navigationService;
        }
    }
}
