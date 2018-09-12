namespace ElectionApp.ViewModel
{
    public interface IViewPageViewModel : IPageViewModel
    {
        void Load();
        void Edit();
        void Delete();
    }
}
