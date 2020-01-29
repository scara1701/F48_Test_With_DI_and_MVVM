using F48Test.MyLib.Services;
using F48Test.MyLib.ViewModels;
using System.Windows.Controls;

namespace F48Test.MyWPFGUI.Pages
{
    /// <summary>
    /// Interaction logic for DetailsPage.xaml
    /// </summary>
    public partial class DetailsPage : Page
    {
        //Dependency injection at work
        public DetailsPage(IGetNumberService getNumberService, INavigationService navigationService)
        {
            InitializeComponent();
            DataContext = new DetailsViewModel(getNumberService, navigationService);
        }
    }
}
