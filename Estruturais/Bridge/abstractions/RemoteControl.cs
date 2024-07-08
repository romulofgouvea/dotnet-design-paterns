using Bridge.interfaces;

namespace Bridge.abstractions;

public abstract class RemoteControl
{
    protected IDevice _device;

    public RemoteControl(IDevice device)
    {
        _device = device;
    }

    public abstract void TogglePower();
    public abstract void VolumeUp();
    public abstract void VolumeDown();
    public abstract void ChannelUp();
    public abstract void ChannelDown();
}