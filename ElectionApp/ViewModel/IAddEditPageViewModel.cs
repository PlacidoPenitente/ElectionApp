namespace ElectionApp.ViewModel
{
    public interface IAddEditPageViewModel<in T> : IWorkspacePageViewModel
    {
        void Save(T entity);
        void Cancel();
    }
}
