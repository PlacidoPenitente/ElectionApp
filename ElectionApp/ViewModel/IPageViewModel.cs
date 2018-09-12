namespace ElectionApp.ViewModel
{
    public interface IPageViewModel
    {
        string Title { get; }
        IBannerViewModel Banner { get; }
    }
}
