namespace AdapterPatternSample.HDMI
{
    /// <summary>
    /// 新的螢幕
    /// </summary>
    public class NewScreen : IHDMI
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            Console.WriteLine("HDMI螢幕連接成功");
            IsConnected = true;
        }

        public void Disconnect()
        {
            Console.WriteLine("HDMI螢幕已斷開連接");
            IsConnected = false;
        }

        public string GetConnectionStatus()
        {
            return IsConnected ? "HDMI螢幕連接正常" : "HDMI螢幕未連接";
        }
    }
}
