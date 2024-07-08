using Bridge.interfaces;

namespace Bridge.implementations;

public class AdvancedRemote : BasicRemote
{
    public AdvancedRemote(IDevice device) : base(device) { }

    public void Mute()
    {
        _device.SetVolume(0);
        Console.WriteLine(_device);
    }
}