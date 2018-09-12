namespace ElectionApp.ViewModel
{
    public interface IWorkspaceViewModel : IPageViewModel
    {
        IWorkspacePageViewModel CurrentPage { get; }
    }
}
