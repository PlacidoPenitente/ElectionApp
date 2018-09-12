namespace ElectionApp.ViewModel
{
    public interface IViewPageViewModel<in T> : IWorkspacePageViewModel
    {
        void Load();
        void Edit(T entity);
        void Delete(T entity);
    }
}
