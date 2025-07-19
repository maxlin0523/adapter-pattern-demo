namespace AdapterPatternSample.DVI
{
    /// <summary>
    /// DVI規格
    /// </summary>
    public interface IDVI
    {
        void Connect();
        void Disconnect();
        bool IsConnected { get; }
        string GetConnectionStatus();
    }
}
