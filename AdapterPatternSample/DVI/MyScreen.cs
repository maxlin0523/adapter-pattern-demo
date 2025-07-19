namespace AdapterPatternSample.DVI
{
    /// <summary>
    /// 我的螢幕
    /// </summary>
    public class MyScreen : IDVI
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            Console.WriteLine("螢幕故障連接失敗");
            IsConnected = false;
        }

        public void Disconnect()
        {
            Console.WriteLine("螢幕已斷開連接");
            IsConnected = false;
        }

        public string GetConnectionStatus()
        {
            return IsConnected ? "DVI螢幕連接正常" : "DVI螢幕連接失敗或未連接";
        }
    }
}
