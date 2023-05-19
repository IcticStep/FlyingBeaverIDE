namespace DataBaseConnector;

public interface IRepository<T>
{
    public void Add(T value);
    public void Remove(T index);
    public int Count();
    public bool IsEmpty();
    public T FindFirst(Predicate<T> predicate);
}