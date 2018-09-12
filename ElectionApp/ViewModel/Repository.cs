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
            return new LoginPageViewModel(mainWindowViewModel);
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
            return new WorkspaceViewModel(mainWindowViewModel);
        }

        public IWorkspaceBannerViewModel CreateWorkspaceBanner()
        {
            return new WorkspaceBannerViewModel();
        }

        public ILoginBannerViewModel CreateLoginBanner()
        {
            return new LoginBannerViewModel();
        }
    }
}