using AdapterPatternSample.DVI;

namespace AdapterPatternSample.Host
{
    /// <summary>
    /// 主機
    /// </summary>
    public class MyHost
    {
        private readonly IDVI _dvi;

        /// <summary>
        /// 使用DVI接口
        /// </summary>
        public MyHost(IDVI dvi)
        {
            _dvi = dvi ?? throw new ArgumentNullException(nameof(dvi));
            Console.WriteLine("PC端DVI接口連接成功");
        }

        /// <summary>
        /// 開機
        /// </summary>
        public void Open()
        {
            Console.WriteLine("正在開機...");
            _dvi.Connect();
            
            if (_dvi.IsConnected)
            {
                Console.WriteLine("螢幕已就緒，系統啟動完成");
            }
            else
            {
                Console.WriteLine("警告：螢幕連接異常，請檢查連接");
            }
        }

        /// <summary>
        /// 關機
        /// </summary>
        public void Shutdown()
        {
            Console.WriteLine("正在關機...");
            _dvi.Disconnect();
            Console.WriteLine("系統已關閉");
        }

        /// <summary>
        /// 檢查連接狀態
        /// </summary>
        public void CheckStatus()
        {
            Console.WriteLine($"連接狀態: {_dvi.GetConnectionStatus()}");
        }
    }
}
