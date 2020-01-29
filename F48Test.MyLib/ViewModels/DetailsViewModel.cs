using F48Test.MyLib.Models;
using F48Test.MyLib.Services;
using System.Collections.Generic;

namespace F48Test.MyLib.ViewModels
{
    public class DetailsViewModel : BaseViewModel
    {
        IGetNumberService _getNumberService;
        INavigationService _navigationService;
        public RelayCommand GoBackCommand { get; set; }
        public DetailsViewModel(IGetNumberService getNumberService, INavigationService navigationService)
        {
            _getNumberService = getNumberService;
            _navigationService = navigationService;
            GoBackCommand = new RelayCommand(() => GoBack());
        }


        public List<MyObject> TheList
        {
            get { return ListService.MyObjects(_getNumberService); }
        }


        private void GoBack()
        {
            _navigationService.GoBack();
        }
    }
}
