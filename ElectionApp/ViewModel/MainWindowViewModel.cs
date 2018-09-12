namespace ElectionApp.ViewModel
{
    public class MainWindowViewModel : BaseInpc
    {
        private string _title;
        private IPageViewModel _mainPage;
        private IBannerViewModel _banner;
        private readonly ILoginPageViewModel _loginPage;
        private readonly ILoginBannerViewModel _loginBannerViewModel;
        private readonly IWorkspaceViewModel _workspacePage;
        private readonly IWorkspaceBannerViewModel _workspaceBannerViewModel;

        public MainWindowViewModel()
        {
            _loginPage = Repository.Instance.CreateLoginPage(this);
            _loginBannerViewModel = Repository.Instance.CreateLoginBanner();
            _workspacePage = Repository.Instance.CreateWorkspacePage(this);
            _workspaceBannerViewModel = Repository.Instance.CreateWorkspaceBanner();
        }

        public IBannerViewModel Banner
        {
            get => _banner;
            set
            {
                _banner = value;
                OnPropertyChanged();
            }
        }

        public IPageViewModel MainPage
        {
            get => _mainPage;
            set
            {
                _mainPage = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value + " - " + ElectionAppConstants.ProgramName;
                OnPropertyChanged();
            }
        }

        public void GotoLoginPage()
        {
            Banner = _loginBannerViewModel;
            MainPage = _loginPage;
        }

        public void GotoWorkspace()
        {
            Banner = _workspaceBannerViewModel;
            MainPage = _workspacePage;
        }
    }
}
