using F48Test.MyLib.Services;
using F48Test.MyLib.ViewModels;
using System.Windows.Controls;

namespace F48Test.MyWPFGUI.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        //Dependency injection at work
        public MainPage(IGetNumberService getNumberService, INavigationService navigationService)
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(getNumberService, navigationService);
        }
    }
}
