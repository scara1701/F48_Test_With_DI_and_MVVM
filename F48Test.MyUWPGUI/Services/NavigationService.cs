using F48Test.MyLib.Models;
using F48Test.MyLib.Services;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace F48Test.MyUWPGUI.Services
{
    public class NavigationService : INavigationService
    {
        public void GoBack()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
        }

        public void Navigate(ApplicationPage sourcePage)
        {
            NavigateEventArgs args = new NavigateEventArgs();
            args.Page = sourcePage;
            OnNavigate(args);
        }


        //Event handler created in App.xaml.cs, used for navigating with serviceprovider
        public event EventHandler<NavigateEventArgs> NavigateEvent;

        protected virtual void OnNavigate(NavigateEventArgs e)
        {
            EventHandler<NavigateEventArgs> handler = NavigateEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class NavigateEventArgs : EventArgs
    {
        public ApplicationPage Page { get; set; }
    }
}
