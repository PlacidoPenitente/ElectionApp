using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp.ViewModel
{
    public class LoginPageViewModel : BaseInpc, ILoginPageViewModel
    {
        public LoginPageViewModel()
        {
            Banner = Repository.Instance.CreateLoginBanner();
        }

        public string Title { get; }
        public IBannerViewModel Banner { get; }

        public void Login()
        {
            throw new NotImplementedException();
        }
    }
}
