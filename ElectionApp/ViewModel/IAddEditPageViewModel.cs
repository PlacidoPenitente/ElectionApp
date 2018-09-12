namespace ElectionApp.ViewModel
{
    public interface IAddEditPageViewModel<in T> : IPageViewModel
    {
        void Save(T entity);
        void Cancel();
    }
}
