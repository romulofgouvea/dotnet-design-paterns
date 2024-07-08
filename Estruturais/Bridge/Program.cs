using Bridge.abstractions;
using Bridge.implementations;
using Bridge.interfaces;

namespace Bridge;

static class Program
{
    static void Main(string[] args)
    {
        IDevice tv = new Tv();
        RemoteControl remoteTv = new BasicRemote(tv);
        remoteTv.TogglePower();
        remoteTv.VolumeUp();
        remoteTv.ChannelUp();

        Console.WriteLine();

        IDevice radio = new Radio();
        AdvancedRemote remoteRadio = new AdvancedRemote(radio);
        remoteRadio.TogglePower();
        remoteRadio.VolumeUp();
        remoteRadio.VolumeUp();
        remoteRadio.Mute();
    }
}