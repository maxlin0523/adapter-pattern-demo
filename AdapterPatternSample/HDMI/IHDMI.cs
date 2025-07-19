namespace AdapterPatternSample.HDMI
{
    /// <summary>
    /// HDMI規格
    /// </summary>
    public interface IHDMI
    {
        void Connect();
        void Disconnect();
        bool IsConnected { get; }
        string GetConnectionStatus();
    }
}
