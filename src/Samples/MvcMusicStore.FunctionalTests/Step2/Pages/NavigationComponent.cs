using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace MvcMusicStore.FunctionalTests.Step2.Pages
{
    public class NavigationComponent : UiComponent
    {
        public LogonPage GoToAdminForAnonymousUser()
        {
            return NavigateTo<LogonPage>(By.LinkText("Admin"));
        }
    }
}