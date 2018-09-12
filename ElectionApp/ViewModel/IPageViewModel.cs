namespace ElectionApp.ViewModel
{
    public interface IPageViewModel
    {
        string Title { get; }
        IBannerViewModel GetBanner();
    }
}
