using ElectionApp.Model;

namespace ElectionApp.Facade
{
    public class UserFacade : BaseInpc
    {
        private readonly User _user;

        public UserFacade(User user)
        {
            _user = user;
        }

        public string Username
        {
            get => _user.Username;
            set
            {
                _user.Username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _user.Password;
            set
            {
                _user.Password = value;
                OnPropertyChanged();
            }
        }

        public AccountType AccountType
        {
            get => _user.AccountType;
            set
            {
                _user.AccountType = value;
                OnPropertyChanged();
            }
        }
    }
}
