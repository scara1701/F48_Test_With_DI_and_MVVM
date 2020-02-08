using F48Test.MyLib.Services;
using F48Test.MyLib.ViewModels;
using F48Test.MyUWPGUI.Services;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace F48Test.MyUWPGUI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Constructor parameterless in rootframe.navigate
            IGetNumberService getNumberService = DIHelper.GetNumberService();
            INavigationService navigationService = DIHelper.GetNavigationService();
            DataContext = new MainViewModel(getNumberService, navigationService);
        }
    }
}
