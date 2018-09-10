using ElectionApp.Model;

namespace ElectionApp.Facade
{
    public class CandidateFacade : VoterFacade
    {
        private readonly Candidate _candidate;

        public CandidateFacade(Candidate candidate) : base(candidate)
        {
            _candidate = candidate;
        }

        public Position Position
        {
            get => _candidate.Position;
            set
            {
                _candidate.Position = value;
                OnPropertyChanged();
            }
        }

        public Party Party
        {
            get => _candidate.Party;
            set
            {
                _candidate.Party = value;
                OnPropertyChanged();
            }
        }
    }
}
