namespace ElectionApp.ViewModel
{
    public class Repository
    {
        public static Repository Instance { get; } = new Repository();

        static Repository()
        {

        }

        private Repository()
        {
            
        }

        public ILoginPageViewModel CreateLoginPage(MainWindowViewModel mainWindowViewModel)
        {
            return new LoginPageViewModel();
        }

        public IAddEditPageViewModel<T> CreateAddEditPage<T>(IWorkspaceViewModel mainWindowViewModel)
        {
            return null;
        }

        public IViewPageViewModel<T> CreateViewPage<T>(IWorkspaceViewModel mainWindowViewModel)
        {
            return null;
        }

        public IWorkspaceViewModel CreateWorkspacePage(MainWindowViewModel mainWindowViewModel)
        {
            return null;
        }

        public IWorkspaceBannerViewModel CreateWorkspaceBanner()
        {
            return null;
        }

        public ILoginBannerViewModel CreateLoginBanner()
        {
            return new LoginBannerViewModel();
        }
    }
}