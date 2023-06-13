using System.Timers;
using FlyingBeaverIDE.Logic.Api;
using Timer = System.Timers.Timer;

namespace FlyingBeaverIDE.Logic.Services;

public class DataReceivingDelayer<T>
{
    public DataReceivingDelayer(IDataReceiver<T> receiver) => 
        receiver.OnDataReceived += DelayDataReceiving;

    public uint Delay
    {
        get => _delay;
        set
        {
            if(value == 0)
                throw new ArgumentOutOfRangeException(nameof(Delay));
            _delay = value;
        }
    }

    private long _elapsedMilliseconds;
    private Timer _timer;
    private T _currentData;
    private uint _delay = 500;

    public event Action<T> OnDelayedReceive;

    private void DelayDataReceiving(T data)
    {
        if (_timer is not null)
        {
            _timer.Stop();
            _timer.Dispose();
            _timer = null;
        }
        
        _currentData = data;
        _timer = new(TimeSpan.FromMilliseconds(Delay));
        _timer.Elapsed += FinishDelayReceiving;
        _timer.Start();
    }

    private void FinishDelayReceiving(object? sender, ElapsedEventArgs elapsedEventArgs)
    {
        OnDelayedReceive?.Invoke(_currentData);
        _currentData = default;
        _timer = null;
    }
}