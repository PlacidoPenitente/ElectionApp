using ElectionApp.Model;

namespace ElectionApp.ViewModel
{
    public class WorkspaceViewModel : BaseInpc, IWorkspaceViewModel
    {
        private IWorkspacePageViewModel _currentPage;

        private readonly IAddEditPageViewModel<IVoter> _voterAddEditPage;
        private readonly IAddEditPageViewModel<ICandidate> _candidateAddEditPage;
        private readonly IAddEditPageViewModel<IParty> _partyAddEditPage;

        private readonly IViewPageViewModel<IVoter> _voterViewPage;
        private readonly IViewPageViewModel<ICandidate> _candidateViewPage;
        private readonly IViewPageViewModel<IParty> _partyViewPage;

        private readonly MainWindowViewModel _mainWindowViewModel;

        public WorkspaceViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;

            _voterAddEditPage = Repository.Instance.CreateAddEditPage<IVoter>(this);
            _candidateAddEditPage = Repository.Instance.CreateAddEditPage<ICandidate>(this);
            _partyAddEditPage = Repository.Instance.CreateAddEditPage<IParty>(this);

            _voterViewPage = Repository.Instance.CreateViewPage<IVoter>(this);
            _candidateViewPage = Repository.Instance.CreateViewPage<ICandidate>(this);
            _partyViewPage = Repository.Instance.CreateViewPage<IParty>(this);

            Banner = Repository.Instance.CreateWorkspaceBanner();
        }
        
        public string Title { get; }
        public IBannerViewModel Banner { get; }

        public IWorkspacePageViewModel CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }

        public void GotoVoterAddEditPage()
        {
            CurrentPage = _voterAddEditPage;
        }

        public void GotoCandidateAddEditPage()
        {
            CurrentPage = _candidateAddEditPage;
        }

        public void GotoPartyAddEditPage()
        {
            CurrentPage = _partyAddEditPage;
        }

        public void GotoVoterViewPage()
        {
            CurrentPage = _voterViewPage;
        }

        public void GotoCandidateViewPage()
        {
            CurrentPage = _candidateViewPage;
        }

        public void GotoPartyViewPage()
        {
            CurrentPage = _partyViewPage;
        }
    }
}
