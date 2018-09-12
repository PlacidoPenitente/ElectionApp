namespace ElectionApp.ViewModel
{
    public class Repository
    {
        public static Repository Instance { get; } = new Repository();

        static Repository()
        {

        }

        private Repository()
        {
            
        }

        public ILoginPageViewModel CreateLoginPage()
        {
            return null;
        }
    }
}