namespace ElectionApp.ViewModel
{
    public class MainWindowViewModel : BaseInpc
    {
        private IPageViewModel _currentPage;

        public IPageViewModel CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }

        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private readonly ILoginPageViewModel _loginPage = Repository.Instance.CreateLoginPage();

        public void GotoLoginPage()
        {
            CurrentPage = _loginPage;
        }
    }
}
