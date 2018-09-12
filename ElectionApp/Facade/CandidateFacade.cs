using System;
using ElectionApp.Model;

namespace ElectionApp.Facade
{
    public class CandidateFacade : BaseInpc
    {
        private readonly Candidate _candidate;

        public CandidateFacade(Candidate candidate)
        {
            _candidate = candidate;
        }

        public string FirstName
        {
            get => _candidate.FirstName;
            set
            {
                _candidate.FirstName = value;
                OnPropertyChanged();
            }
        }

        public string MiddleName
        {
            get => _candidate.MiddleName;
            set
            {
                _candidate.MiddleName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _candidate.LastName;
            set
            {
                _candidate.LastName = value;
                OnPropertyChanged();
            }
        }

        public DateTime Birthdate
        {
            get => _candidate.Birthdate;
            set
            {
                _candidate.Birthdate = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get => _candidate.Address;
            set
            {
                _candidate.Address = value;
                OnPropertyChanged();
            }
        }

        public string Photo
        {
            get => _candidate.Photo;
            set
            {
                _candidate.Photo = value;
                OnPropertyChanged();
            }
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

        public Gender Gender
        {
            get => _candidate.Gender;
            set
            {
                _candidate.Gender = value;
                OnPropertyChanged();
            }
        }
    }
}
