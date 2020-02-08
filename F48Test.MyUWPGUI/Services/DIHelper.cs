using F48Test.MyLib.Services;

using Microsoft.Extensions.DependencyInjection;

namespace F48Test.MyUWPGUI.Services
{
    public static class DIHelper
    {
        public static INavigationService GetNavigationService()
        {
            return (App.Current as App)._serviceProvider.GetService<INavigationService>();
        }

        public static IGetNumberService GetNumberService()
        {
            return (App.Current as App)._serviceProvider.GetService<IGetNumberService>();
        }
    }
}
