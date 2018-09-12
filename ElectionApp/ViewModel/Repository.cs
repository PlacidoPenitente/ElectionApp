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

        public ILoginPageViewModel CreateLoginPage(MainWindowViewModel mainWindowViewModel)
        {
            return null;
        }

        public IAddEditPageViewModel<T> CreateAddEditPage<T>(MainWindowViewModel mainWindowViewModel)
        {
            return null;
        }

        public IViewPageViewModel<T> CreateViewPage<T>(MainWindowViewModel mainWindowViewModel)
        {
            return null;
        }
    }
}