using System;

namespace ElectionApp.ViewModel
{
    public class LoginPageViewModel : BaseInpc, ILoginPageViewModel
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public LoginPageViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            Title = ElectionAppConstants.Login;
            Banner = Repository.Instance.CreateLoginBanner();
            LoginCommand = new DelegateCommand(Login);
        }

        public DelegateCommand LoginCommand { get; set; }
        public string Title { get; }
        public IBannerViewModel Banner { get; }

        public void Login()
        {
            _mainWindowViewModel.GotoWorkspace();
        }
    }
}
