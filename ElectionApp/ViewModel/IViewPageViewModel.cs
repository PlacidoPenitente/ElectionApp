namespace ElectionApp.ViewModel
{
    public interface IViewPageViewModel<in T> : IPageViewModel
    {
        void Load();
        void Edit(T entity);
        void Delete(T entity);
    }
}
