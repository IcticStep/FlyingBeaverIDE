namespace FlyingBeaverIDE.Logic.API;

public interface IRawDataReceivedSignaller
{
    public event Action? OnRawDataReceived;
}