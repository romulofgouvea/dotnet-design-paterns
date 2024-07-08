namespace Bridge.interfaces;

public interface IDevice
{
    bool IsEnabled();
    void Enable();
    void Disable();
    int GetVolume();
    void SetVolume(int percent);
    int GetChannel();
    void SetChannel(int channel);
}