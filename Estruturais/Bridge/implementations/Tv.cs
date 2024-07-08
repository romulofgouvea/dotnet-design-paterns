using Bridge.interfaces;

namespace Bridge.implementations;

public class Tv : IDevice
{
    private bool _on = false;
    private int _volume = 0;
    private int _channel = 1;

    public bool IsEnabled() => _on;
    public void Enable() => _on = true;
    public void Disable() => _on = false;
    public int GetVolume() => _volume;
    public void SetVolume(int percent) => _volume = Math.Max(0, Math.Min(100, percent));
    public int GetChannel() => _channel;
    public void SetChannel(int channel) => _channel = channel;

    public override string ToString() => $"TV: {(_on ? "ligada" : "desligada")}, Volume: {_volume}, Canal: {_channel}";
}