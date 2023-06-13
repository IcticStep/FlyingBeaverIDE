namespace FlyingBeaverIDE.Logic.Api;

public interface IDataReceiver<T>
{
    public event Action<T>? OnDataReceived;
}