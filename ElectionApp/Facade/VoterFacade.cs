using System;
using ElectionApp.Model;

namespace ElectionApp.Facade
{
    public class VoterFacade : BaseInpc
    {
        private readonly Voter _voter;

        public VoterFacade(Voter voter)
        {
            _voter = voter;
        }

        public string FirstName
        {
            get => _voter.FirstName;
            set
            {
                _voter.FirstName = value;
                OnPropertyChanged();
            }
        }

        public string MiddleName
        {
            get => _voter.MiddleName;
            set
            {
                _voter.MiddleName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _voter.LastName;
            set
            {
                _voter.LastName = value;
                OnPropertyChanged();
            }
        }

        public DateTime Birthdate
        {
            get => _voter.Birthdate;
            set
            {
                _voter.Birthdate = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get => _voter.Address;
            set
            {
                _voter.Address = value;
                OnPropertyChanged();
            }
        }

        public string Photo
        {
            get => _voter.Photo;
            set
            {
                _voter.Photo = value;
                OnPropertyChanged();
            }
        }
    }
}
