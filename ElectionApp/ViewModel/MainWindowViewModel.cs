namespace ElectionApp.ViewModel
{
    public class MainWindowViewModel : BaseInpc
    {
        private string _title;
        private IPageViewModel _mainPage;
        private IBannerViewModel _banner;
        private readonly ILoginPageViewModel _loginPage;
        private readonly IWorkspaceViewModel _workspacePage;

        public MainWindowViewModel()
        {
            _loginPage = Repository.Instance.CreateLoginPage(this);
            _workspacePage = Repository.Instance.CreateWorkspacePage(this);
            GotoLoginPage();
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
            Banner = _loginPage.Banner;
            MainPage = _loginPage;
        }

        public void GotoWorkspace()
        {
            Banner = _workspacePage.Banner;
            MainPage = _workspacePage;
        }
    }
}
