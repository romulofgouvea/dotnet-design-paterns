using Bridge.abstractions;
using Bridge.interfaces;

namespace Bridge.implementations;

public class BasicRemote : RemoteControl
{
    public BasicRemote(IDevice device) : base(device) { }

    public override void TogglePower()
    {
        if (_device.IsEnabled()) _device.Disable();
        else _device.Enable();
        Console.WriteLine(_device);
    }

    public override void VolumeUp()
    {
        _device.SetVolume(_device.GetVolume() + 10);
        Console.WriteLine(_device);
    }

    public override void VolumeDown()
    {
        _device.SetVolume(_device.GetVolume() - 10);
        Console.WriteLine(_device);
    }

    public override void ChannelUp()
    {
        _device.SetChannel(_device.GetChannel() + 1);
        Console.WriteLine(_device);
    }

    public override void ChannelDown()
    {
        _device.SetChannel(_device.GetChannel() - 1);
        Console.WriteLine(_device);
    }
}