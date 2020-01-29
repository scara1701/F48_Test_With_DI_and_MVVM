using F48Test.MyLib.Models;

namespace F48Test.MyLib.Services
{
    /// <summary>
    /// Interface for navigation commands in UI
    /// </summary>
    public interface INavigationService
    {
        void Navigate(ApplicationPage sourcePage);
        void GoBack();
    }
}
